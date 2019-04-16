using System;
using System.Collections.Generic;
using System.Drawing;
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

            for (int i = 0; i < GameArea.ColumnCount; i++)
            {
                for (int j = 0; j < GameArea.RowCount; j++)
                {
                    GameArea[i, j].Value = 0;
                }
            }
        }
        private void GameArea_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GameArea[e.ColumnIndex, e.RowIndex].Value = "X";

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

            for (int i = 0; i < 8; i++)
            {
                if (e.ColumnIndex + direct[i][0] >= 0 && e.RowIndex + direct[i][1] >= 0 &&
                     e.ColumnIndex + direct[i][0] < GameArea.ColumnCount && e.RowIndex + direct[i][1] < GameArea.RowCount)
                {
                    if (GameArea[e.ColumnIndex + direct[i][0], e.RowIndex + direct[i][1]].Value.ToString() != "X")
                    {
                        GameArea[e.ColumnIndex + direct[i][0], e.RowIndex + direct[i][1]].Value =
                        Convert.ToInt32(GameArea[e.ColumnIndex + direct[i][0], e.RowIndex + direct[i][1]].Value.ToString()) + 1;
                    }
                }
            }
        }

        public void PushToAreaMines()
        {
            int row = 0;
            int column = 0;
            Random r = new Random();

            for (int j = 0; j < 86; j++)
            {
                int i = r.Next(433);
                if (i % 24 >= 0)
                {

                }
                else
                {

                }
            }

        }

        private Dictionary<int, string> ColorsDictionary = new Dictionary<int, string>()
        {
            { 0,"White" },{ 1,"Blue" },{ 2,"Green" },{ 3,"Red" },
            { 4,"DarkViolet" },{ 5,"DarkOrange" },{ 6,"HotPink" },{ 7,"Brown" },{ 8,"DarkSeaGreen" }
        };

        private void GameArea_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (GameArea[e.ColumnIndex, e.RowIndex].Value.ToString() != "X")
            {
                GameArea[e.ColumnIndex, e.RowIndex].Style.ForeColor =
                    Color.FromName(ColorsDictionary[Convert.ToInt32(GameArea[e.ColumnIndex, e.RowIndex].Value.ToString())]);
            }
            else
            {
                GameArea[e.ColumnIndex, e.RowIndex].Style.ForeColor = Color.Black;
            }
        }
    }  //-----------------------------------

}
