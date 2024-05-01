namespace Програма_для_вивчення_нових_термінів
{
    partial class MiniGame
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonMiniGame = new System.Windows.Forms.Button();
            this.labelWrongLetters = new System.Windows.Forms.Label();
            this.richTextBoxWrongLetters = new System.Windows.Forms.RichTextBox();
            this.secretWord = new System.Windows.Forms.Label();
            this.labelEnterASymbol = new System.Windows.Forms.Label();
            this.textBoxEnterSymbol = new System.Windows.Forms.TextBox();
            this.buttonCheckSymbol = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(214)))), ((int)(((byte)(210)))));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.labelTitle, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonClose, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonMiniGame, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1884, 100);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.labelTitle.Location = new System.Drawing.Point(883, 27);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(117, 46);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "label1";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(173)))), ((int)(((byte)(161)))));
            this.buttonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(10)))), ((int)(((byte)(5)))));
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Segoe UI Semibold", 15F);
            this.buttonClose.Location = new System.Drawing.Point(1774, 19);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(3, 3, 40, 3);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(70, 61);
            this.buttonClose.TabIndex = 3;
            this.buttonClose.Text = "Х";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonMiniGame
            // 
            this.buttonMiniGame.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonMiniGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(173)))), ((int)(((byte)(161)))));
            this.buttonMiniGame.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(10)))), ((int)(((byte)(5)))));
            this.buttonMiniGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMiniGame.Font = new System.Drawing.Font("Segoe UI Variable Text", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMiniGame.Location = new System.Drawing.Point(40, 19);
            this.buttonMiniGame.Margin = new System.Windows.Forms.Padding(40, 3, 3, 3);
            this.buttonMiniGame.Name = "buttonMiniGame";
            this.buttonMiniGame.Size = new System.Drawing.Size(326, 61);
            this.buttonMiniGame.TabIndex = 2;
            this.buttonMiniGame.TabStop = false;
            this.buttonMiniGame.Text = "Minigame";
            this.buttonMiniGame.UseVisualStyleBackColor = false;
            // 
            // labelWrongLetters
            // 
            this.labelWrongLetters.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelWrongLetters.AutoSize = true;
            this.labelWrongLetters.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.labelWrongLetters.Location = new System.Drawing.Point(40, 10);
            this.labelWrongLetters.Name = "labelWrongLetters";
            this.labelWrongLetters.Size = new System.Drawing.Size(261, 46);
            this.labelWrongLetters.TabIndex = 5;
            this.labelWrongLetters.Text = "Wrong symbols";
            this.labelWrongLetters.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // richTextBoxWrongLetters
            // 
            this.richTextBoxWrongLetters.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxWrongLetters.Location = new System.Drawing.Point(39, 60);
            this.richTextBoxWrongLetters.Name = "richTextBoxWrongLetters";
            this.richTextBoxWrongLetters.ReadOnly = true;
            this.richTextBoxWrongLetters.Size = new System.Drawing.Size(856, 111);
            this.richTextBoxWrongLetters.TabIndex = 6;
            this.richTextBoxWrongLetters.TabStop = false;
            this.richTextBoxWrongLetters.Text = "";
            // 
            // secretWord
            // 
            this.secretWord.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.secretWord.AutoSize = true;
            this.secretWord.Font = new System.Drawing.Font("Segoe UI Semibold", 30F, System.Drawing.FontStyle.Bold);
            this.secretWord.Location = new System.Drawing.Point(18, 52);
            this.secretWord.MaximumSize = new System.Drawing.Size(800, 0);
            this.secretWord.Name = "secretWord";
            this.secretWord.Size = new System.Drawing.Size(475, 67);
            this.secretWord.TabIndex = 8;
            this.secretWord.Text = "Word:   _ _ _ _ _ _ _ _";
            this.secretWord.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelEnterASymbol
            // 
            this.labelEnterASymbol.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelEnterASymbol.AutoSize = true;
            this.labelEnterASymbol.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.labelEnterASymbol.Location = new System.Drawing.Point(20, 29);
            this.labelEnterASymbol.Name = "labelEnterASymbol";
            this.labelEnterASymbol.Size = new System.Drawing.Size(265, 46);
            this.labelEnterASymbol.TabIndex = 9;
            this.labelEnterASymbol.Text = "Enter a symbol: ";
            this.labelEnterASymbol.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxEnterSymbol
            // 
            this.textBoxEnterSymbol.Font = new System.Drawing.Font("Segoe UI Variable Text", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxEnterSymbol.Location = new System.Drawing.Point(325, 27);
            this.textBoxEnterSymbol.Name = "textBoxEnterSymbol";
            this.textBoxEnterSymbol.Size = new System.Drawing.Size(387, 52);
            this.textBoxEnterSymbol.TabIndex = 0;
            this.textBoxEnterSymbol.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxEnterSymbol_KeyPress);
            // 
            // buttonCheckSymbol
            // 
            this.buttonCheckSymbol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(173)))), ((int)(((byte)(161)))));
            this.buttonCheckSymbol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCheckSymbol.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(10)))), ((int)(((byte)(5)))));
            this.buttonCheckSymbol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCheckSymbol.Font = new System.Drawing.Font("Segoe UI Semibold", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCheckSymbol.Location = new System.Drawing.Point(741, 21);
            this.buttonCheckSymbol.Name = "buttonCheckSymbol";
            this.buttonCheckSymbol.Size = new System.Drawing.Size(178, 57);
            this.buttonCheckSymbol.TabIndex = 1;
            this.buttonCheckSymbol.Text = "Check";
            this.buttonCheckSymbol.UseVisualStyleBackColor = false;
            this.buttonCheckSymbol.Click += new System.EventHandler(this.buttonCheckSymbol_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonCheckSymbol);
            this.panel1.Controls.Add(this.labelEnterASymbol);
            this.panel1.Controls.Add(this.textBoxEnterSymbol);
            this.panel1.Location = new System.Drawing.Point(41, 438);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(933, 100);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelWrongLetters);
            this.panel2.Controls.Add(this.richTextBoxWrongLetters);
            this.panel2.Location = new System.Drawing.Point(41, 611);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(933, 193);
            this.panel2.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.secretWord);
            this.panel3.Location = new System.Drawing.Point(41, 35);
            this.panel3.MaximumSize = new System.Drawing.Size(900, 1000);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(900, 364);
            this.panel3.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::Програма_для_вивчення_нових_термінів.Properties.Resources._0;
            this.pictureBox1.Location = new System.Drawing.Point(1094, 67);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(717, 735);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1015, 880);
            this.panel4.TabIndex = 16;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(214)))), ((int)(((byte)(210)))));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.24628F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.75372F));
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 100);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1884, 886);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // MiniGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1884, 986);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MiniGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MiniGame";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonMiniGame;
        private System.Windows.Forms.Label labelWrongLetters;
        private System.Windows.Forms.RichTextBox richTextBoxWrongLetters;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label secretWord;
        private System.Windows.Forms.Label labelEnterASymbol;
        private System.Windows.Forms.TextBox textBoxEnterSymbol;
        private System.Windows.Forms.Button buttonCheckSymbol;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}