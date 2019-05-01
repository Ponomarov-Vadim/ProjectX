namespace ProjectX
{
    partial class Battleship
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GridYourShip = new System.Windows.Forms.DataGridView();
            this.GridOpponentShip = new System.Windows.Forms.DataGridView();
            this.label1SectionShip = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2SectionShip = new System.Windows.Forms.Label();
            this.label3SectionShip = new System.Windows.Forms.Label();
            this.label4SectionShip = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridYourShip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridOpponentShip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // GridYourShip
            // 
            this.GridYourShip.AllowUserToAddRows = false;
            this.GridYourShip.AllowUserToDeleteRows = false;
            this.GridYourShip.AllowUserToResizeColumns = false;
            this.GridYourShip.AllowUserToResizeRows = false;
            this.GridYourShip.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridYourShip.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GridYourShip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridYourShip.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridYourShip.DefaultCellStyle = dataGridViewCellStyle1;
            this.GridYourShip.Location = new System.Drawing.Point(179, 48);
            this.GridYourShip.MultiSelect = false;
            this.GridYourShip.Name = "GridYourShip";
            this.GridYourShip.ReadOnly = true;
            this.GridYourShip.RowHeadersVisible = false;
            this.GridYourShip.RowHeadersWidth = 23;
            this.GridYourShip.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.GridYourShip.Size = new System.Drawing.Size(240, 203);
            this.GridYourShip.TabIndex = 0;
            this.GridYourShip.CellStyleChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridYourShip_CellStyleChanged);
            this.GridYourShip.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GridYourShip_KeyDown);
            // 
            // GridOpponentShip
            // 
            this.GridOpponentShip.AllowUserToAddRows = false;
            this.GridOpponentShip.AllowUserToDeleteRows = false;
            this.GridOpponentShip.AllowUserToResizeColumns = false;
            this.GridOpponentShip.AllowUserToResizeRows = false;
            this.GridOpponentShip.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridOpponentShip.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GridOpponentShip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridOpponentShip.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridOpponentShip.DefaultCellStyle = dataGridViewCellStyle2;
            this.GridOpponentShip.Location = new System.Drawing.Point(454, 49);
            this.GridOpponentShip.MultiSelect = false;
            this.GridOpponentShip.Name = "GridOpponentShip";
            this.GridOpponentShip.ReadOnly = true;
            this.GridOpponentShip.RowHeadersVisible = false;
            this.GridOpponentShip.RowHeadersWidth = 23;
            this.GridOpponentShip.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.GridOpponentShip.Size = new System.Drawing.Size(240, 203);
            this.GridOpponentShip.TabIndex = 6;
            this.GridOpponentShip.TabStop = false;
            // 
            // label1SectionShip
            // 
            this.label1SectionShip.AutoSize = true;
            this.label1SectionShip.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1SectionShip.Location = new System.Drawing.Point(12, 48);
            this.label1SectionShip.Name = "label1SectionShip";
            this.label1SectionShip.Size = new System.Drawing.Size(20, 22);
            this.label1SectionShip.TabIndex = 7;
            this.label1SectionShip.Text = "4";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::ProjectX.Properties.Resources._4;
            this.pictureBox4.Location = new System.Drawing.Point(57, 217);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(96, 21);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.PictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ProjectX.Properties.Resources._3;
            this.pictureBox3.Location = new System.Drawing.Point(57, 161);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(72, 21);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.PictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProjectX.Properties.Resources._2;
            this.pictureBox2.Location = new System.Drawing.Point(57, 105);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 21);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjectX.Properties.Resources._1;
            this.pictureBox1.Location = new System.Drawing.Point(57, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // label2SectionShip
            // 
            this.label2SectionShip.AutoSize = true;
            this.label2SectionShip.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2SectionShip.Location = new System.Drawing.Point(12, 104);
            this.label2SectionShip.Name = "label2SectionShip";
            this.label2SectionShip.Size = new System.Drawing.Size(20, 22);
            this.label2SectionShip.TabIndex = 7;
            this.label2SectionShip.Text = "3";
            // 
            // label3SectionShip
            // 
            this.label3SectionShip.AutoSize = true;
            this.label3SectionShip.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3SectionShip.Location = new System.Drawing.Point(12, 160);
            this.label3SectionShip.Name = "label3SectionShip";
            this.label3SectionShip.Size = new System.Drawing.Size(20, 22);
            this.label3SectionShip.TabIndex = 7;
            this.label3SectionShip.Text = "2";
            // 
            // label4SectionShip
            // 
            this.label4SectionShip.AutoSize = true;
            this.label4SectionShip.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4SectionShip.Location = new System.Drawing.Point(12, 216);
            this.label4SectionShip.Name = "label4SectionShip";
            this.label4SectionShip.Size = new System.Drawing.Size(20, 22);
            this.label4SectionShip.TabIndex = 7;
            this.label4SectionShip.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(35, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Chose ship";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(254, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Your area";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(513, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Opponent Area";
            // 
            // Battleship
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4SectionShip);
            this.Controls.Add(this.label3SectionShip);
            this.Controls.Add(this.label2SectionShip);
            this.Controls.Add(this.label1SectionShip);
            this.Controls.Add(this.GridOpponentShip);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.GridYourShip);
            this.DoubleBuffered = true;
            this.Name = "Battleship";
            this.Text = "Battleship";
            this.Load += new System.EventHandler(this.Battleship_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Battleship_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.GridYourShip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridOpponentShip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridYourShip;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.DataGridView GridOpponentShip;
        private System.Windows.Forms.Label label1SectionShip;
        private System.Windows.Forms.Label label2SectionShip;
        private System.Windows.Forms.Label label3SectionShip;
        private System.Windows.Forms.Label label4SectionShip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}