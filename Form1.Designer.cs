namespace ProjectX
{
    partial class Mineswaeper
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GameArea = new System.Windows.Forms.DataGridView();
            this.MinesLeft = new System.Windows.Forms.Label();
            this.MinesCounter = new System.Windows.Forms.Label();
            this.buttonClearArea = new System.Windows.Forms.Button();
            this.pictureMines = new System.Windows.Forms.PictureBox();
            this.buttonFull = new System.Windows.Forms.Button();
            this.labelOut = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GameArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMines)).BeginInit();
            this.SuspendLayout();
            // 
            // GameArea
            // 
            this.GameArea.AllowUserToAddRows = false;
            this.GameArea.AllowUserToDeleteRows = false;
            this.GameArea.AllowUserToResizeColumns = false;
            this.GameArea.AllowUserToResizeRows = false;
            this.GameArea.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GameArea.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GameArea.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.GameArea.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GameArea.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GameArea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GameArea.ColumnHeadersVisible = false;
            this.GameArea.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GameArea.DefaultCellStyle = dataGridViewCellStyle2;
            this.GameArea.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.GameArea.Location = new System.Drawing.Point(181, 27);
            this.GameArea.MultiSelect = false;
            this.GameArea.Name = "GameArea";
            this.GameArea.ReadOnly = true;
            this.GameArea.RowHeadersVisible = false;
            this.GameArea.RowHeadersWidth = 40;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.GameArea.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.GameArea.RowTemplate.Height = 20;
            this.GameArea.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.GameArea.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.GameArea.Size = new System.Drawing.Size(507, 363);
            this.GameArea.TabIndex = 0;
            this.GameArea.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GameArea_CellClick);
            this.GameArea.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GameArea_CellMouseClick);
            this.GameArea.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.GameArea_CellValueChanged);
            // 
            // MinesLeft
            // 
            this.MinesLeft.AutoSize = true;
            this.MinesLeft.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinesLeft.Location = new System.Drawing.Point(31, 44);
            this.MinesLeft.Name = "MinesLeft";
            this.MinesLeft.Size = new System.Drawing.Size(90, 21);
            this.MinesLeft.TabIndex = 1;
            this.MinesLeft.Text = "Mines Left\r\n";
            // 
            // MinesCounter
            // 
            this.MinesCounter.AutoSize = true;
            this.MinesCounter.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinesCounter.Location = new System.Drawing.Point(141, 44);
            this.MinesCounter.Name = "MinesCounter";
            this.MinesCounter.Size = new System.Drawing.Size(0, 21);
            this.MinesCounter.TabIndex = 2;
            // 
            // buttonClearArea
            // 
            this.buttonClearArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClearArea.Location = new System.Drawing.Point(35, 80);
            this.buttonClearArea.Name = "buttonClearArea";
            this.buttonClearArea.Size = new System.Drawing.Size(86, 32);
            this.buttonClearArea.TabIndex = 3;
            this.buttonClearArea.Text = "Clear";
            this.buttonClearArea.UseVisualStyleBackColor = true;
            this.buttonClearArea.Click += new System.EventHandler(this.ButtonClearArea_Click);
            // 
            // pictureMines
            // 
            this.pictureMines.BackColor = System.Drawing.Color.Transparent;
            this.pictureMines.Image = global::ProjectX.Properties.Resources.Mines;
            this.pictureMines.Location = new System.Drawing.Point(12, 44);
            this.pictureMines.Name = "pictureMines";
            this.pictureMines.Size = new System.Drawing.Size(15, 15);
            this.pictureMines.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureMines.TabIndex = 4;
            this.pictureMines.TabStop = false;
            // 
            // buttonFull
            // 
            this.buttonFull.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFull.Location = new System.Drawing.Point(35, 134);
            this.buttonFull.Name = "buttonFull";
            this.buttonFull.Size = new System.Drawing.Size(86, 32);
            this.buttonFull.TabIndex = 5;
            this.buttonFull.Text = "Full";
            this.buttonFull.UseVisualStyleBackColor = true;
            this.buttonFull.Click += new System.EventHandler(this.ButtonFull_Click);
            // 
            // labelOut
            // 
            this.labelOut.AutoSize = true;
            this.labelOut.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOut.Location = new System.Drawing.Point(12, 202);
            this.labelOut.Name = "labelOut";
            this.labelOut.Size = new System.Drawing.Size(19, 21);
            this.labelOut.TabIndex = 6;
            this.labelOut.Text = "0";
            // 
            // Mineswaeper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelOut);
            this.Controls.Add(this.buttonFull);
            this.Controls.Add(this.pictureMines);
            this.Controls.Add(this.buttonClearArea);
            this.Controls.Add(this.MinesCounter);
            this.Controls.Add(this.MinesLeft);
            this.Controls.Add(this.GameArea);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "Mineswaeper";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Minesweeper";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GameArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMines)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GameArea;
        private System.Windows.Forms.Label MinesLeft;
        private System.Windows.Forms.Label MinesCounter;
        private System.Windows.Forms.Button buttonClearArea;
        private System.Windows.Forms.PictureBox pictureMines;
        private System.Windows.Forms.Button buttonFull;
        private System.Windows.Forms.Label labelOut;
    }
}

