namespace MineSweeper
{
    partial class MainMenu
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
            this.playerNameLbl = new System.Windows.Forms.Label();
            this.gridSizeLbl = new System.Windows.Forms.Label();
            this.PlayBtn = new System.Windows.Forms.Button();
            this.playerNameTxt = new System.Windows.Forms.TextBox();
            this.gridSizeTxt = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.mineNumberLbl = new System.Windows.Forms.Label();
            this.mineNumberTxt = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.DevInfoLbl = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // playerNameLbl
            // 
            this.playerNameLbl.AutoSize = true;
            this.playerNameLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playerNameLbl.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerNameLbl.Location = new System.Drawing.Point(4, 0);
            this.playerNameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.playerNameLbl.Name = "playerNameLbl";
            this.playerNameLbl.Size = new System.Drawing.Size(272, 44);
            this.playerNameLbl.TabIndex = 0;
            this.playerNameLbl.Text = "Oyuncu Adı :";
            this.playerNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gridSizeLbl
            // 
            this.gridSizeLbl.AutoSize = true;
            this.gridSizeLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridSizeLbl.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridSizeLbl.Location = new System.Drawing.Point(4, 44);
            this.gridSizeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gridSizeLbl.Name = "gridSizeLbl";
            this.gridSizeLbl.Size = new System.Drawing.Size(272, 44);
            this.gridSizeLbl.TabIndex = 1;
            this.gridSizeLbl.Text = "Grid Boyutu :";
            this.gridSizeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PlayBtn
            // 
            this.PlayBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlayBtn.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayBtn.Location = new System.Drawing.Point(0, 0);
            this.PlayBtn.Margin = new System.Windows.Forms.Padding(4);
            this.PlayBtn.Name = "PlayBtn";
            this.PlayBtn.Size = new System.Drawing.Size(563, 54);
            this.PlayBtn.TabIndex = 2;
            this.PlayBtn.Text = "OYNA";
            this.PlayBtn.UseVisualStyleBackColor = true;
            this.PlayBtn.Click += new System.EventHandler(this.PlayBtn_Click);
            // 
            // playerNameTxt
            // 
            this.playerNameTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playerNameTxt.Location = new System.Drawing.Point(284, 4);
            this.playerNameTxt.Margin = new System.Windows.Forms.Padding(4);
            this.playerNameTxt.Name = "playerNameTxt";
            this.playerNameTxt.Size = new System.Drawing.Size(272, 22);
            this.playerNameTxt.TabIndex = 3;
            // 
            // gridSizeTxt
            // 
            this.gridSizeTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridSizeTxt.Location = new System.Drawing.Point(284, 48);
            this.gridSizeTxt.Margin = new System.Windows.Forms.Padding(4);
            this.gridSizeTxt.Name = "gridSizeTxt";
            this.gridSizeTxt.Size = new System.Drawing.Size(272, 22);
            this.gridSizeTxt.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.PlayBtn);
            this.panel2.Location = new System.Drawing.Point(16, 158);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(563, 54);
            this.panel2.TabIndex = 6;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.playerNameLbl, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gridSizeTxt, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.gridSizeLbl, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.playerNameTxt, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.mineNumberLbl, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.mineNumberTxt, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(16, 15);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(560, 132);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // mineNumberLbl
            // 
            this.mineNumberLbl.AutoSize = true;
            this.mineNumberLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mineNumberLbl.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mineNumberLbl.Location = new System.Drawing.Point(4, 88);
            this.mineNumberLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mineNumberLbl.Name = "mineNumberLbl";
            this.mineNumberLbl.Size = new System.Drawing.Size(272, 44);
            this.mineNumberLbl.TabIndex = 5;
            this.mineNumberLbl.Text = "Mayın Sayısı :";
            this.mineNumberLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mineNumberTxt
            // 
            this.mineNumberTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mineNumberTxt.Location = new System.Drawing.Point(284, 92);
            this.mineNumberTxt.Margin = new System.Windows.Forms.Padding(4);
            this.mineNumberTxt.Name = "mineNumberTxt";
            this.mineNumberTxt.Size = new System.Drawing.Size(272, 22);
            this.mineNumberTxt.TabIndex = 6;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.DevInfoLbl, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(16, 220);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(563, 46);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // DevInfoLbl
            // 
            this.DevInfoLbl.AutoSize = true;
            this.DevInfoLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DevInfoLbl.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DevInfoLbl.Location = new System.Drawing.Point(4, 0);
            this.DevInfoLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DevInfoLbl.Name = "DevInfoLbl";
            this.DevInfoLbl.Size = new System.Drawing.Size(555, 46);
            this.DevInfoLbl.TabIndex = 0;
            this.DevInfoLbl.Text = "Irmak Yılmaz - 230229038";
            this.DevInfoLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 276);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mayın Tarlası";
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label playerNameLbl;
        private System.Windows.Forms.Label gridSizeLbl;
        private System.Windows.Forms.Button PlayBtn;
        private System.Windows.Forms.TextBox playerNameTxt;
        private System.Windows.Forms.TextBox gridSizeTxt;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label DevInfoLbl;
        private System.Windows.Forms.Label mineNumberLbl;
        private System.Windows.Forms.TextBox mineNumberTxt;
    }
}

