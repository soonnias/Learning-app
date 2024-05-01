namespace Програма_для_вивчення_нових_термінів
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.labelTitle = new System.Windows.Forms.Label();
            this.richTextBoxSearch = new System.Windows.Forms.RichTextBox();
            this.panelForSets = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxCombine = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBoxAddNewSet = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxFilter = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxSort = new System.Windows.Forms.ComboBox();
            this.buttonClearSearch = new System.Windows.Forms.PictureBox();
            this.buttonSearch = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCombine)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAddNewSet)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonClearSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonSearch)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.Location = new System.Drawing.Point(25, 23);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(114, 61);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Sets";
            // 
            // richTextBoxSearch
            // 
            this.richTextBoxSearch.Font = new System.Drawing.Font("Segoe UI Variable Text", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxSearch.Location = new System.Drawing.Point(161, 115);
            this.richTextBoxSearch.Name = "richTextBoxSearch";
            this.richTextBoxSearch.Size = new System.Drawing.Size(394, 41);
            this.richTextBoxSearch.TabIndex = 1;
            this.richTextBoxSearch.Text = "";
            // 
            // panelForSets
            // 
            this.panelForSets.AutoScroll = true;
            this.panelForSets.AutoScrollMargin = new System.Drawing.Size(5, 0);
            this.panelForSets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(214)))), ((int)(((byte)(210)))));
            this.panelForSets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForSets.Location = new System.Drawing.Point(3, 202);
            this.panelForSets.Name = "panelForSets";
            this.panelForSets.Size = new System.Drawing.Size(1684, 706);
            this.panelForSets.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBoxCombine);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(3, 914);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1684, 109);
            this.panel1.TabIndex = 4;
            // 
            // pictureBoxCombine
            // 
            this.pictureBoxCombine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(214)))), ((int)(((byte)(210)))));
            this.pictureBoxCombine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxCombine.Image = global::Програма_для_вивчення_нових_термінів.Properties.Resources.free_icon_intersection_1555701;
            this.pictureBoxCombine.Location = new System.Drawing.Point(1468, 10);
            this.pictureBoxCombine.Name = "pictureBoxCombine";
            this.pictureBoxCombine.Size = new System.Drawing.Size(90, 90);
            this.pictureBoxCombine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCombine.TabIndex = 3;
            this.pictureBoxCombine.TabStop = false;
            this.pictureBoxCombine.Click += new System.EventHandler(this.combineSets_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBoxAddNewSet);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1568, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(116, 109);
            this.panel3.TabIndex = 3;
            // 
            // pictureBoxAddNewSet
            // 
            this.pictureBoxAddNewSet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(214)))), ((int)(((byte)(210)))));
            this.pictureBoxAddNewSet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxAddNewSet.Image = global::Програма_для_вивчення_нових_термінів.Properties.Resources.free_icon_add_button_2740600;
            this.pictureBoxAddNewSet.Location = new System.Drawing.Point(7, 7);
            this.pictureBoxAddNewSet.Name = "pictureBoxAddNewSet";
            this.pictureBoxAddNewSet.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxAddNewSet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAddNewSet.TabIndex = 2;
            this.pictureBoxAddNewSet.TabStop = false;
            this.pictureBoxAddNewSet.Click += new System.EventHandler(this.AddNewSet_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(214)))), ((int)(((byte)(210)))));
            this.panel2.Controls.Add(this.labelTitle);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.comboBoxFilter);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.comboBoxSort);
            this.panel2.Controls.Add(this.buttonClearSearch);
            this.panel2.Controls.Add(this.buttonSearch);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.richTextBoxSearch);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1684, 171);
            this.panel2.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(1260, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 41);
            this.label4.TabIndex = 9;
            this.label4.Text = "Filter:";
            // 
            // comboBoxFilter
            // 
            this.comboBoxFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFilter.Font = new System.Drawing.Font("Segoe UI Variable Text", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxFilter.FormattingEnabled = true;
            this.comboBoxFilter.Items.AddRange(new object[] {
            "All sets",
            "Language sets",
            "Simple sets"});
            this.comboBoxFilter.Location = new System.Drawing.Point(1370, 114);
            this.comboBoxFilter.Name = "comboBoxFilter";
            this.comboBoxFilter.Size = new System.Drawing.Size(285, 41);
            this.comboBoxFilter.TabIndex = 3;
            this.comboBoxFilter.SelectedIndexChanged += new System.EventHandler(this.comboBoxSort_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(767, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 41);
            this.label3.TabIndex = 7;
            this.label3.Text = "Sort:";
            // 
            // comboBoxSort
            // 
            this.comboBoxSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSort.Font = new System.Drawing.Font("Segoe UI Variable Text", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxSort.FormattingEnabled = true;
            this.comboBoxSort.Items.AddRange(new object[] {
            "Date (newest -> latest)",
            "Date (latest -> newest)",
            "Title (A -> Z)",
            "Title (Z -> A)",
            "Count terms (max -> min)",
            "Count terms (min -> max)"});
            this.comboBoxSort.Location = new System.Drawing.Point(857, 114);
            this.comboBoxSort.Name = "comboBoxSort";
            this.comboBoxSort.Size = new System.Drawing.Size(352, 41);
            this.comboBoxSort.TabIndex = 2;
            this.comboBoxSort.SelectedIndexChanged += new System.EventHandler(this.comboBoxSort_SelectedIndexChanged);
            // 
            // buttonClearSearch
            // 
            this.buttonClearSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClearSearch.Image = global::Програма_для_вивчення_нових_термінів.Properties.Resources.close;
            this.buttonClearSearch.Location = new System.Drawing.Point(639, 110);
            this.buttonClearSearch.Name = "buttonClearSearch";
            this.buttonClearSearch.Size = new System.Drawing.Size(45, 45);
            this.buttonClearSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonClearSearch.TabIndex = 5;
            this.buttonClearSearch.TabStop = false;
            this.buttonClearSearch.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSearch.Image = global::Програма_для_вивчення_нових_термінів.Properties.Resources.search;
            this.buttonSearch.Location = new System.Drawing.Point(577, 111);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(42, 42);
            this.buttonSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonSearch.TabIndex = 4;
            this.buttonSearch.TabStop = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(29, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 41);
            this.label2.TabIndex = 2;
            this.label2.Text = "Search:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(214)))), ((int)(((byte)(210)))));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panelForSets, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.84413F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.15588F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 121F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1690, 1033);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1690, 1033);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCombine)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAddNewSet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonClearSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonSearch)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.RichTextBox richTextBoxSearch;
        private System.Windows.Forms.PictureBox pictureBoxAddNewSet;
        private System.Windows.Forms.Panel panelForSets;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox buttonSearch;
        private System.Windows.Forms.PictureBox buttonClearSearch;
        private System.Windows.Forms.ComboBox comboBoxSort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxFilter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBoxCombine;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}