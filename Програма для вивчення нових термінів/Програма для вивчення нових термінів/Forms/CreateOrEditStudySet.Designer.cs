namespace Програма_для_вивчення_нових_термінів
{
    partial class CreateOrEditStudySet
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TitleFormLabel = new System.Windows.Forms.Label();
            this.descriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.checkBoxLanguageSet = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxLanguag2 = new System.Windows.Forms.ComboBox();
            this.comboBoxLanguag1 = new System.Windows.Forms.ComboBox();
            this.buttonImportCardToSet = new System.Windows.Forms.Button();
            this.dataGridViewCards = new System.Windows.Forms.DataGridView();
            this.Term = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Definition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAddItem = new System.Windows.Forms.Button();
            this.buttonDeleteItem = new System.Windows.Forms.Button();
            this.buttonFlipTD = new System.Windows.Forms.Button();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.buttonCreateOrSaveSet = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCards)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleFormLabel
            // 
            this.TitleFormLabel.AutoSize = true;
            this.TitleFormLabel.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitleFormLabel.Location = new System.Drawing.Point(99, 53);
            this.TitleFormLabel.Name = "TitleFormLabel";
            this.TitleFormLabel.Size = new System.Drawing.Size(520, 62);
            this.TitleFormLabel.TabIndex = 0;
            this.TitleFormLabel.Text = "Create a new study set";
            // 
            // descriptionRichTextBox
            // 
            this.descriptionRichTextBox.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F);
            this.descriptionRichTextBox.Location = new System.Drawing.Point(108, 300);
            this.descriptionRichTextBox.Name = "descriptionRichTextBox";
            this.descriptionRichTextBox.Size = new System.Drawing.Size(1023, 104);
            this.descriptionRichTextBox.TabIndex = 2;
            this.descriptionRichTextBox.Text = "";
            // 
            // checkBoxLanguageSet
            // 
            this.checkBoxLanguageSet.AutoSize = true;
            this.checkBoxLanguageSet.Font = new System.Drawing.Font("Segoe UI Variable Text", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxLanguageSet.Location = new System.Drawing.Point(14, 22);
            this.checkBoxLanguageSet.Name = "checkBoxLanguageSet";
            this.checkBoxLanguageSet.Size = new System.Drawing.Size(187, 37);
            this.checkBoxLanguageSet.TabIndex = 3;
            this.checkBoxLanguageSet.Text = "Language Set";
            this.checkBoxLanguageSet.UseVisualStyleBackColor = true;
            this.checkBoxLanguageSet.CheckedChanged += new System.EventHandler(this.languageCB_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxLanguag2);
            this.groupBox1.Controls.Add(this.comboBoxLanguag1);
            this.groupBox1.Controls.Add(this.checkBoxLanguageSet);
            this.groupBox1.Font = new System.Drawing.Font("Ebrima", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(108, 432);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(573, 74);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // comboBoxLanguag2
            // 
            this.comboBoxLanguag2.Enabled = false;
            this.comboBoxLanguag2.Font = new System.Drawing.Font("Segoe UI Variable Text", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxLanguag2.FormattingEnabled = true;
            this.comboBoxLanguag2.Items.AddRange(new object[] {
            "Ukrainian",
            "Polish",
            "English"});
            this.comboBoxLanguag2.Location = new System.Drawing.Point(397, 22);
            this.comboBoxLanguag2.Name = "comboBoxLanguag2";
            this.comboBoxLanguag2.Size = new System.Drawing.Size(152, 41);
            this.comboBoxLanguag2.TabIndex = 5;
            // 
            // comboBoxLanguag1
            // 
            this.comboBoxLanguag1.Enabled = false;
            this.comboBoxLanguag1.Font = new System.Drawing.Font("Segoe UI Variable Text", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxLanguag1.FormattingEnabled = true;
            this.comboBoxLanguag1.Items.AddRange(new object[] {
            "Ukrainian",
            "Polish",
            "English"});
            this.comboBoxLanguag1.Location = new System.Drawing.Point(223, 22);
            this.comboBoxLanguag1.Name = "comboBoxLanguag1";
            this.comboBoxLanguag1.Size = new System.Drawing.Size(157, 41);
            this.comboBoxLanguag1.TabIndex = 4;
            // 
            // buttonImportCardToSet
            // 
            this.buttonImportCardToSet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(173)))), ((int)(((byte)(161)))));
            this.buttonImportCardToSet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonImportCardToSet.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(10)))), ((int)(((byte)(5)))));
            this.buttonImportCardToSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonImportCardToSet.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonImportCardToSet.Location = new System.Drawing.Point(922, 432);
            this.buttonImportCardToSet.Name = "buttonImportCardToSet";
            this.buttonImportCardToSet.Size = new System.Drawing.Size(209, 74);
            this.buttonImportCardToSet.TabIndex = 6;
            this.buttonImportCardToSet.Text = "Import data";
            this.buttonImportCardToSet.UseVisualStyleBackColor = false;
            this.buttonImportCardToSet.Click += new System.EventHandler(this.buttonImport_Click);
            // 
            // dataGridViewCards
            // 
            this.dataGridViewCards.AllowUserToAddRows = false;
            this.dataGridViewCards.AllowUserToDeleteRows = false;
            this.dataGridViewCards.AllowUserToOrderColumns = true;
            this.dataGridViewCards.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCards.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCards.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Term,
            this.Definition});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Variable Text", 15F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 5, 5, 7);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(173)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(10)))), ((int)(((byte)(5)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCards.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewCards.Location = new System.Drawing.Point(110, 583);
            this.dataGridViewCards.Name = "dataGridViewCards";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCards.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewCards.RowHeadersVisible = false;
            this.dataGridViewCards.RowHeadersWidth = 51;
            this.dataGridViewCards.RowTemplate.Height = 24;
            this.dataGridViewCards.Size = new System.Drawing.Size(1021, 359);
            this.dataGridViewCards.TabIndex = 7;
            // 
            // Term
            // 
            this.Term.HeaderText = "Term";
            this.Term.MinimumWidth = 6;
            this.Term.Name = "Term";
            // 
            // Definition
            // 
            this.Definition.HeaderText = "Definition";
            this.Definition.MinimumWidth = 6;
            this.Definition.Name = "Definition";
            // 
            // buttonAddItem
            // 
            this.buttonAddItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(173)))), ((int)(((byte)(161)))));
            this.buttonAddItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddItem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(10)))), ((int)(((byte)(5)))));
            this.buttonAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddItem.Font = new System.Drawing.Font("Segoe UI Variable Text", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddItem.Location = new System.Drawing.Point(50, 583);
            this.buttonAddItem.Name = "buttonAddItem";
            this.buttonAddItem.Size = new System.Drawing.Size(288, 66);
            this.buttonAddItem.TabIndex = 8;
            this.buttonAddItem.Text = "+ Add item";
            this.buttonAddItem.UseVisualStyleBackColor = false;
            this.buttonAddItem.Click += new System.EventHandler(this.buttonAddItem_Click);
            // 
            // buttonDeleteItem
            // 
            this.buttonDeleteItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(173)))), ((int)(((byte)(161)))));
            this.buttonDeleteItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDeleteItem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(10)))), ((int)(((byte)(5)))));
            this.buttonDeleteItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.buttonDeleteItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteItem.Font = new System.Drawing.Font("Segoe UI Variable Text", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDeleteItem.Location = new System.Drawing.Point(50, 655);
            this.buttonDeleteItem.Name = "buttonDeleteItem";
            this.buttonDeleteItem.Size = new System.Drawing.Size(288, 66);
            this.buttonDeleteItem.TabIndex = 9;
            this.buttonDeleteItem.Text = " - Delete selected item";
            this.buttonDeleteItem.UseVisualStyleBackColor = false;
            this.buttonDeleteItem.Click += new System.EventHandler(this.buttonDeleteItem_Click);
            // 
            // buttonFlipTD
            // 
            this.buttonFlipTD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(173)))), ((int)(((byte)(161)))));
            this.buttonFlipTD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFlipTD.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(10)))), ((int)(((byte)(5)))));
            this.buttonFlipTD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFlipTD.Font = new System.Drawing.Font("Segoe UI Variable Text", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFlipTD.Location = new System.Drawing.Point(50, 727);
            this.buttonFlipTD.Name = "buttonFlipTD";
            this.buttonFlipTD.Size = new System.Drawing.Size(288, 86);
            this.buttonFlipTD.TabIndex = 10;
            this.buttonFlipTD.Text = "Flip term and definition";
            this.buttonFlipTD.UseVisualStyleBackColor = false;
            this.buttonFlipTD.Click += new System.EventHandler(this.buttonFlipTD_Click);
            // 
            // titleTextBox
            // 
            this.titleTextBox.Font = new System.Drawing.Font("Segoe UI Variable Text", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleTextBox.Location = new System.Drawing.Point(108, 175);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(1023, 43);
            this.titleTextBox.TabIndex = 1;
            this.titleTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.titleTextBox_KeyDown);
            // 
            // buttonCreateOrSaveSet
            // 
            this.buttonCreateOrSaveSet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(173)))), ((int)(((byte)(161)))));
            this.buttonCreateOrSaveSet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCreateOrSaveSet.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(10)))), ((int)(((byte)(5)))));
            this.buttonCreateOrSaveSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateOrSaveSet.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCreateOrSaveSet.Location = new System.Drawing.Point(50, 237);
            this.buttonCreateOrSaveSet.Name = "buttonCreateOrSaveSet";
            this.buttonCreateOrSaveSet.Size = new System.Drawing.Size(288, 103);
            this.buttonCreateOrSaveSet.TabIndex = 11;
            this.buttonCreateOrSaveSet.Text = "Create Set";
            this.buttonCreateOrSaveSet.UseVisualStyleBackColor = false;
            this.buttonCreateOrSaveSet.Click += new System.EventHandler(this.buttonCreateOrSaveSet_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(173)))), ((int)(((byte)(161)))));
            this.buttonCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(10)))), ((int)(((byte)(5)))));
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Segoe UI Variable Text", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancel.Location = new System.Drawing.Point(94, 365);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(214, 56);
            this.buttonCancel.TabIndex = 12;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(214)))), ((int)(((byte)(210)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1556, 1055);
            this.panel1.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(214)))), ((int)(((byte)(210)))));
            this.panel3.Controls.Add(this.descriptionLabel);
            this.panel3.Controls.Add(this.titleLabel);
            this.panel3.Controls.Add(this.TitleFormLabel);
            this.panel3.Controls.Add(this.descriptionRichTextBox);
            this.panel3.Controls.Add(this.titleTextBox);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.buttonImportCardToSet);
            this.panel3.Controls.Add(this.dataGridViewCards);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1149, 1055);
            this.panel3.TabIndex = 14;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionLabel.Location = new System.Drawing.Point(103, 262);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(155, 33);
            this.descriptionLabel.TabIndex = 12;
            this.descriptionLabel.Text = "Description:";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleLabel.Location = new System.Drawing.Point(103, 142);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(72, 33);
            this.titleLabel.TabIndex = 11;
            this.titleLabel.Text = "Title:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(214)))), ((int)(((byte)(210)))));
            this.panel2.Controls.Add(this.buttonCreateOrSaveSet);
            this.panel2.Controls.Add(this.buttonCancel);
            this.panel2.Controls.Add(this.buttonFlipTD);
            this.panel2.Controls.Add(this.buttonDeleteItem);
            this.panel2.Controls.Add(this.buttonAddItem);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1152, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(404, 1055);
            this.panel2.TabIndex = 13;
            // 
            // CreateOrEditStudySet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1556, 1055);
            this.Controls.Add(this.panel1);
            this.Name = "CreateOrEditStudySet";
            this.Text = "CreateNewStudySet";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCards)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TitleFormLabel;
        private System.Windows.Forms.RichTextBox descriptionRichTextBox;
        private System.Windows.Forms.CheckBox checkBoxLanguageSet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxLanguag1;
        private System.Windows.Forms.ComboBox comboBoxLanguag2;
        private System.Windows.Forms.Button buttonImportCardToSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Term;
        private System.Windows.Forms.DataGridViewTextBoxColumn Definition;
        private System.Windows.Forms.DataGridView dataGridViewCards;
        private System.Windows.Forms.Button buttonAddItem;
        private System.Windows.Forms.Button buttonDeleteItem;
        private System.Windows.Forms.Button buttonFlipTD;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Button buttonCreateOrSaveSet;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label titleLabel;
    }
}