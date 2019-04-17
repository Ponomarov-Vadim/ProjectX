using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ProjectX
{
    public partial class Mineswaeper : Form
    {
        public Mineswaeper()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 24; i++)
            {
                GameArea.Columns.Add(i.ToString(), "");
            }
            GameArea.Rows.Add(18);

            FillEmptyValueGameArea();
        }

        private void FillEmptyValueGameArea()
        {
            MinesCounter.Text = "9"; // 86
            for (int i = 0; i < GameArea.ColumnCount; i++)
            {
                for (int j = 0; j < GameArea.RowCount; j++)
                {
                    GameArea[i, j].Value = "";
                }
            }
        }

        private void GameArea_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            //FillMethod(e.RowIndex, e.ColumnIndex);

            //int[][] direct = new int[8][];

            //for (int i = 0; i < 8; i++)
            //{
            //    direct[i] = new int[2];
            //}

            //direct[0][0] = -1; direct[0][1] = -1;
            //direct[1][0] = -1; direct[1][1] = 0;
            //direct[2][0] = -1; direct[2][1] = 1;
            //direct[3][0] = 0; direct[3][1] = -1;
            //direct[4][1] = 0; direct[4][1] = +1;
            //direct[5][0] = 1; direct[5][1] = -1;
            //direct[6][0] = 1; direct[6][1] = 0;
            //direct[7][0] = 1; direct[7][1] = 1;

            //if (Convert.ToInt32(MinesCounter.Text) > 0 && GameArea[e.ColumnIndex, e.RowIndex].Value.ToString() != "X")
            //{
            //    GameArea[e.ColumnIndex, e.RowIndex].Style.ForeColor = Color.Black;
            //    GameArea[e.ColumnIndex, e.RowIndex].Value = "X";

            //    MinesCounter.Text = (Convert.ToInt32(MinesCounter.Text) - 1).ToString(); 

            //    for (int i = 0; i < 8; i++)
            //    {
            //        if (e.ColumnIndex + direct[i][0] >= 0 && e.RowIndex + direct[i][1] >= 0 &&
            //             e.ColumnIndex + direct[i][0] < GameArea.ColumnCount && e.RowIndex + direct[i][1] < GameArea.RowCount)
            //        {
            //            if (GameArea[e.ColumnIndex + direct[i][0], e.RowIndex + direct[i][1]].Value.ToString() != "X")
            //            {
            //                GameArea[e.ColumnIndex + direct[i][0], e.RowIndex + direct[i][1]].Value =
            //                Convert.ToInt32(GameArea[e.ColumnIndex + direct[i][0], e.RowIndex + direct[i][1]].Value.ToString()) + 1;
            //            }
            //        }
            //    }
            //}
        }

        public void FillMethod(int RowIndex, int ColumnIndex)
        {
            int[][] direct = new int[8][];

            for (int i = 0; i < 8; i++)
            {
                direct[i] = new int[2];
            }

            direct[0][0] = -1; direct[0][1] = -1;
            direct[1][0] = -1; direct[1][1] = 0;
            direct[2][0] = -1; direct[2][1] = 1;
            direct[3][0] = 0; direct[3][1] = -1;
            direct[4][1] = 0; direct[4][1] = +1;
            direct[5][0] = 1; direct[5][1] = -1;
            direct[6][0] = 1; direct[6][1] = 0;
            direct[7][0] = 1; direct[7][1] = 1;

            GameArea[ColumnIndex, RowIndex].Style.ForeColor = Color.Black;
            GameArea[ColumnIndex, RowIndex].Value = "X";


            for (int i = 0; i < 8; i++)
            {
                if (ColumnIndex + direct[i][0] >= 0 && RowIndex + direct[i][1] >= 0 &&
                     ColumnIndex + direct[i][0] < GameArea.ColumnCount && RowIndex + direct[i][1] < GameArea.RowCount)
                {
                    if (GameArea[ColumnIndex + direct[i][0], RowIndex + direct[i][1]].Value.ToString() != "X")
                    {
                        if (GameArea[ColumnIndex + direct[i][0], RowIndex + direct[i][1]].Value.ToString()=="")
                        {
                            GameArea[ColumnIndex + direct[i][0], RowIndex + direct[i][1]].Value = 1;
                        }
                        else
                        {
                            GameArea[ColumnIndex + direct[i][0], RowIndex + direct[i][1]].Value =
                            Convert.ToInt32(GameArea[ColumnIndex + direct[i][0], RowIndex + direct[i][1]].Value.ToString()) + 1;
                        }
                    }
                }
            }

        }

        public void PushToAreaMines()
        {
            int row = 0;
            int column = 0;
            Random rand = new Random();

            for (int j = 0; j < 86; j++)
            {
                labelOut.Text = (Convert.ToInt32(labelOut.Text.ToString()) + 1).ToString();
                int r = rand.Next(433);                
                if (r < 24)
                {
                    row = 0;
                    column = r;
                }
                else
                {
                    if (((r / 24) - 1) > 0)
                    {
                        row = (r / 24) -1  ;
                    }
                    else
                    {
                        row = 0;
                    }
                    if (((r % 24) - 1) > 0) //--
                    {
                        column = (r % 24) ;//--
                    }
                    else
                    {
                        column = 0;
                    }
                }
                if (GameArea[column, row].Value.ToString() != "X")
                {
                    writeouts(row, column, r);
                    FillMethod(row, column);
                }
                else
                {
                    j--;

                }
            }
        }

        public void writeouts(int row, int colum, int rand)
        {
            string str = "Rows num =" + row + "; Colums num = " + colum + "; Rand num = " + rand + ";\n";
            using (StreamWriter s = new StreamWriter("info.txt", true))
            {

                s.WriteLine(str);
            }
        }

        private Dictionary<int, string> ColorsDictionary = new Dictionary<int, string>()
        {
            { 0,"White" },{ 1,"Blue" },{ 2,"Green" },{ 3,"Red" },
            { 4,"DarkViolet" },{ 5,"DarkOrange" },{ 6,"HotPink" },{ 7,"Brown" },{ 8,"DarkSeaGreen" }
        };

        private void GameArea_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (GameArea[e.ColumnIndex, e.RowIndex].Value.ToString() != "X" &&
                !string.IsNullOrEmpty(GameArea[e.ColumnIndex, e.RowIndex].Value.ToString())) //------------
            {
                GameArea[e.ColumnIndex, e.RowIndex].Style.ForeColor =
                    Color.FromName(ColorsDictionary[Convert.ToInt32(GameArea[e.ColumnIndex, e.RowIndex].Value.ToString())]);
            }
            else
            {
                GameArea[e.ColumnIndex, e.RowIndex].Style.ForeColor = Color.Black;
            }
        }

        private void ButtonClearArea_Click(object sender, EventArgs e)
        {
            FillEmptyValueGameArea();
        }

        private void GameArea_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //MouseButtons.
            //e.Button.
        }

        private void ButtonFull_Click(object sender, EventArgs e)
        {
            PushToAreaMines();
        }
    }
    //-----------------------------------
}