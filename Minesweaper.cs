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

        //private bool FirstClick = true;

        private void Mineswaeper_Load(object sender, EventArgs e)
        {
            Shadow_GameArea = new string[24][];
            for (int i = 0; i < 24; i++)
            {
                GameArea.Columns.Add(i.ToString(), "");
                Shadow_GameArea[i] = new string[18];
            }
            GameArea.Rows.Add(18);
            FillArea();
        }

        private void FillEmptyValueGameArea()
        {            
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
            MinesCounter.Text = (Convert.ToInt32(MinesCounter.Text.ToString()) + 1).ToString();

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
        } // needed refactoring
        // Установка мины и заполнение вокруг цифрой присутствия /\ /\ /\ /\ /\

        // Рандомайзер расположения мин \/ \/ \/ \/ \/
        public void PushToAreaMines()
        {
            int row = 0;
            int column = 0;
            Random rand = new Random();

            for (int j = 0; j < 86; j++)
            {                
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
                    FillMethod(row, column);
                }
                else
                {
                    j--;
                }
            }
        }

        private Dictionary<int, string> ColorsDictionary = new Dictionary<int, string>()
        {
            { 0,"Pink" },{ 1,"Blue" },{ 2,"Green" },{ 3,"Red" },
            { 4,"DarkViolet" },{ 5,"DarkOrange" },{ 6,"HotPink" },{ 7,"Brown" },{ 8,"DarkSeaGreen" }
        };  // Цветовосприятие цифр на поле

        // Раскраска цифр \/ \/ \/ \/ \/
        private void GameArea_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (GameArea[e.ColumnIndex, e.RowIndex].Value.ToString() != "X" &&
                !string.IsNullOrEmpty(GameArea[e.ColumnIndex, e.RowIndex].Value.ToString()) &&
                GameArea[e.ColumnIndex, e.RowIndex].Value.ToString() != "  ")
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
                if (GameArea[e.ColumnIndex, e.RowIndex].Style.BackColor != Color.Red) // дописать больше вариация просчета мин что бы все совпадало
                {
                    MinesCounter.Text = (Convert.ToInt32(MinesCounter.Text) - 1).ToString();
                    GameArea[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.Red;
                }
            }
            if (e.Button.Equals(MouseButtons.Left))
            {
                InsertDataInGameArea(e.ColumnIndex, e.RowIndex);
            }
        }

        private void InsertDataInGameArea(int columnIndex, int rowIndex)
        {
            if (Shadow_GameArea[columnIndex][rowIndex] != "X")
            {
                if (Shadow_GameArea[columnIndex][rowIndex] == "")
                {
                    GameArea[columnIndex, rowIndex].Value = "  ";
                    GameArea[columnIndex, rowIndex].Style.BackColor = Color.White;
                    Shadow_GameArea[columnIndex][rowIndex] = "  ";
                    AroundSearch(columnIndex, rowIndex);
                }
                else
                {
                    GameArea[columnIndex, rowIndex].Value = Shadow_GameArea[columnIndex][rowIndex];
                    GameArea[columnIndex, rowIndex].Style.BackColor = Color.White;
                }
            }
            else
            {
               DialogResult butt = MessageBox.Show("GAME OVER", "End Game", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                if (butt == DialogResult.Retry)
                {
                    FillArea();
                }
            }
        }

        private void AroundSearch(int columnIndex, int rowIndex)
        {
            for (int i = -1; i < 2; i++)
            {
                for (int j = -1; j < 2; j++)
                {
                    if (i != 0)
                    {
                        if (columnIndex + i >= 0 && columnIndex + i < GameArea.ColumnCount &&
                            rowIndex + j >= 0 && rowIndex + j < GameArea.RowCount)
                        {
                            InsertDataInGameArea(columnIndex + i, rowIndex + j);
                        }
                    }
                    else if (j != 0)
                    {
                        if (columnIndex + i >= 0 && columnIndex + i < GameArea.ColumnCount &&
                        rowIndex + j >= 0 && rowIndex + j < GameArea.RowCount)
                        {
                            InsertDataInGameArea(columnIndex + i, rowIndex + j);
                        }
                    }
                }
            }
        }

        // логика отклика на нажатие кнопок мыши /\ /\ /\ /\ /\


        // записываем тень поля но поле не заполняем
        private void ButtonFull_Click(object sender, EventArgs e)
        {
            FillArea();
        }

        private void FillArea()
        {
            GameArea.RowsDefaultCellStyle.BackColor = Color.Gray;
            
            MinesCounter.Text = "0";
            FillEmptyValueGameArea();
            PushToAreaMines();
           
            for (int i = 0; i < 24; i++)
            {
                for (int j = 0; j < 18; j++)
                {
                    Shadow_GameArea[i][j] = GameArea[i, j].Value.ToString(); // записывается тень поля с минами и их окружение
                }
            }
            FillEmptyValueGameArea();
            DefaultColor();
        }

        public void DefaultColor ()
        {
            for (int i = 0; i < 24; i++)
            {
                for (int j = 0; j < 18; j++)
                {
                    GameArea[i, j].Style.BackColor = Color.Gray;
                }
            }
        }
    }
    //-----------------------------------
}