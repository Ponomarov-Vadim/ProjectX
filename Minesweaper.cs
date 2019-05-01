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

        private string[][] Shadow_GameArea; //массив мин

        private void Mineswaeper_Load(object sender, EventArgs e)
        {
            Shadow_GameArea = new string[24][];
            for (int i = 0; i < 24; i++)
            {
                GameArea.Columns.Add(i.ToString(), "");
                Shadow_GameArea[i] = new string[18];
            }
            GameArea.Rows.Add(18);

            FillEmptyValueGameArea();
        }

        private void FillEmptyValueGameArea()
        {
            //DataGridViewButtonColumn btn_info = new DataGridViewButtonColumn();
            //GameArea.Columns.Add(btn_info); btn_info.HeaderText = "Инфо."; btn_info.Text = "Инфо."; btn_info.Name = "info";
            //btn_info.UseColumnTextForButtonValue = true; btn_info.Width = 50;

            MinesCounter.Text = "86";
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

            // New fitures in this place needed

        }
        // Установка мины и заполнение вокруг цифрой присутствия \/ \/ \/ \/ \/
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

            GameArea[ColumnIndex, RowIndex].Value = "X";


            for (int i = 0; i < 8; i++)
            {
                if (ColumnIndex + direct[i][0] >= 0 && RowIndex + direct[i][1] >= 0 &&
                     ColumnIndex + direct[i][0] < GameArea.ColumnCount && RowIndex + direct[i][1] < GameArea.RowCount)
                {
                    if (GameArea[ColumnIndex + direct[i][0], RowIndex + direct[i][1]].Value.ToString() != "X")
                    {
                        if (GameArea[ColumnIndex + direct[i][0], RowIndex + direct[i][1]].Value.ToString() == "")
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
        // Установка мины и заполнение вокруг цифрой присутствия /\ /\ /\ /\ /\

        // Рандомайзер расположения мин \/ \/ \/ \/ \/
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
                    if ((r / 24) > 0)
                    {
                        row = (r / 24);
                    }
                    else
                    {
                        row = 0;
                    }
                    if ((r % 24) > 0)
                    {
                        column = (r % 24);
                    }
                    else
                    {
                        column = 0;
                    }
                }
                if (r > 408)
                {
                    row = 17;
                }

                if (GameArea[column, row].Value.ToString() != "X")
                {
                    //writeouts(row, column, r); // just for test
                    FillMethod(row, column);
                }
                else
                {
                    j--;
                }
            }
        }
        // Рандомайзер расположения мин /\ /\ /\ /\ /\

        /*Just for test
        public void writeouts(int row, int colum, int rand)
        {
            string str = "Rows num =" + row + "; Colums num = " + colum + "; Rand num = " + rand + ";\n";
            using (StreamWriter s = new StreamWriter("info.txt", true))
            {
                s.WriteLine(str);
            }
        }
        */

        private Dictionary<int, string> ColorsDictionary = new Dictionary<int, string>()
        {
            { 0,"Pink" },{ 1,"Blue" },{ 2,"Green" },{ 3,"Red" },
            { 4,"DarkViolet" },{ 5,"DarkOrange" },{ 6,"HotPink" },{ 7,"Brown" },{ 8,"DarkSeaGreen" }
        };  // Цветовосприятие цифр на поле

        // Раскраска цифр \/ \/ \/ \/ \/
        private void GameArea_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (GameArea[e.ColumnIndex, e.RowIndex].Value.ToString() != "X" &&
                !string.IsNullOrEmpty(GameArea[e.ColumnIndex, e.RowIndex].Value.ToString()))
            {
                GameArea[e.ColumnIndex, e.RowIndex].Style.ForeColor =
                    Color.FromName(ColorsDictionary[Convert.ToInt32(GameArea[e.ColumnIndex, e.RowIndex].Value.ToString())]);
            }
            else
            {
                GameArea[e.ColumnIndex, e.RowIndex].Style.ForeColor = Color.Black;
            }
        }
        // Раскраска цифр /\ /\ /\ /\ /\

        private void ButtonClearArea_Click(object sender, EventArgs e)
        {
            FillEmptyValueGameArea();
        }

        // логика отклика на нажатие кнопок мыши \/ \/ \/ \/ \/
        private void GameArea_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button.Equals(MouseButtons.Right))
            {
                MinesCounter.Text = (Convert.ToInt32(MinesCounter.Text) - 1).ToString();

            }
            if (e.Button.Equals(MouseButtons.Left))
            {
                if (GameArea[e.ColumnIndex, e.RowIndex].Value.ToString() == "")
                {
                    GameArea[e.ColumnIndex, e.RowIndex].Value = "0";
                    ValidationCoopMembers(e.RowIndex, e.ColumnIndex);
                }
                else if (GameArea[e.ColumnIndex, e.RowIndex].Value is int)
                {
                    GameArea[e.ColumnIndex, e.RowIndex].Value = "8";
                }
            }
        }
        // логика отклика на нажатие кнопок мыши /\ /\ /\ /\ /\

        private void ValidationCoopMembers(int RowIndex, int ColumnIndex)
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

            // Ищет соседние с кликом пустые места и заполняет 0

            for (int i = 0; i < 8; i++)
            {
                if (ColumnIndex + direct[i][0] >= 0 && RowIndex + direct[i][1] >= 0 &&
                     ColumnIndex + direct[i][0] < GameArea.ColumnCount && RowIndex + direct[i][1] < GameArea.RowCount) //вне поля?
                {
                    // заполняет соседние пустые ячейки \/                     
                    if (GameArea[ColumnIndex + direct[i][0], RowIndex + direct[i][1]].Value.ToString() == "")    
                    {   
                            GameArea[ColumnIndex + direct[i][0], RowIndex + direct[i][1]].Value = "0";
                            ValidationCoopMembers(RowIndex + direct[i][1], ColumnIndex + direct[i][0]);
                    }
                    // заполняет соседние пустые ячейки /\

                    // заполняет соседние с пустыми цифровые ячейки \/
                    if (GameArea[ColumnIndex + direct[i][0], RowIndex + direct[i][1]].Value is int)
                    {
                        GameArea[ColumnIndex + direct[i][0], RowIndex + direct[i][1]].Value = "8";
                    }
                    // заполняет соседние с пустыми цифровые ячейки /\
                }
            }
        }

        private void ButtonFull_Click(object sender, EventArgs e)
        {
            PushToAreaMines();
            for (int i = 0; i < 24; i++)
            {
                for (int j = 0; j < 18; j++)
                {
                    Shadow_GameArea[i][j] = GameArea[i, j].Value.ToString(); // записывается тень поля с минами и их окружение
                }
            }
        }
    }
    //-----------------------------------
}