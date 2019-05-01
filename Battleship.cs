using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectX
{
    public partial class Battleship : Form
    {
        public Battleship()
        {
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(Battleship_KeyDown);
        }

        private void Battleship_Load(object sender, EventArgs e)
        {

            for (int i = 0; i < 10; i++)
            {
                GridYourShip.Columns.Add(i.ToString(), "");
                GridOpponentShip.Columns.Add(i.ToString(), "");
            }
            GridYourShip.Rows.Add(10);
            GridOpponentShip.Rows.Add(10);
        }

        private void Battleship_KeyDown(object sender, KeyEventArgs e)
        {
            Refresh();
        }

        private void GridYourShip_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.R:
                    rotate = !rotate;

                    break;
                case Keys.Enter:
                    ClearArea(false);
                    break;
                case Keys.Escape:
                    ClearArea(true);
                    break;
                case Keys.Left:

                    break;
                case Keys.Up:

                    break;
                case Keys.Right:

                    break;
                case Keys.Down:

                    break;
                case Keys.Delete:

                    break;
                default:
                    break;
            }
        }

        private void MoveYourShape()
        {
            
        } 

        private void ClearArea(bool ClearSetShip)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                   if(GridYourShip[i,j].Style.BackColor == Color.Blue)
                    {
                        if (ClearSetShip)
                        {
                            GridYourShip[i, j].Style.BackColor = Color.White;
                        }
                        else
                        {
                            GridYourShip[i, j].Style.BackColor = Color.Black;
                        }
                    }
                }
            }           
        }

        private bool rotate = false;
        private void PictureBox1_Click(object sender, EventArgs e)
        {
            ClearArea(true);
            GridYourShip[0, 0].Style.BackColor = Color.Blue;
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            PictureBox1_Click(sender, e);
            if (rotate)
            {
                GridYourShip[1, 0].Style.BackColor = Color.Blue;
            }
            else
            {
                GridYourShip[0, 1].Style.BackColor = Color.Blue;
            }            
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            PictureBox2_Click(sender, e);
            if (rotate)
            {
                GridYourShip[2, 0].Style.BackColor = Color.Blue;
            }
            else
            {
                GridYourShip[0, 2].Style.BackColor = Color.Blue;
            }
            
        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {
            PictureBox3_Click(sender, e);
            if (rotate)
            {
                GridYourShip[3, 0].Style.BackColor = Color.Blue;
            }
            else
            {
                GridYourShip[0, 3].Style.BackColor = Color.Blue;
            }
            
        }

        private void GridYourShip_CellStyleChanged(object sender, DataGridViewCellEventArgs e)
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

            for (int i = 0; i < 8; i++)
            {
                if (e.ColumnIndex + direct[i][0] >= 0 && e.RowIndex + direct[i][1] >= 0 &&
                    e.ColumnIndex + direct[i][0] < GridYourShip.ColumnCount && e.RowIndex + direct[i][1] < GridYourShip.RowCount)
                {
                    if (GridYourShip[e.ColumnIndex + direct[i][0], e.RowIndex + direct[i][1]].Style.BackColor != Color.Black)
                    {
                        if (GridYourShip[e.ColumnIndex + direct[i][0], e.RowIndex + direct[i][1]].Value.ToString() != "*")
                        {
                            GridYourShip[e.ColumnIndex + direct[i][0], e.RowIndex + direct[i][1]].Value = "*";
                        }
                    }
                }
            }
        }
    }
}
