namespace Програма_для_вивчення_нових_термінів
{
    partial class FlashcardForm
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
            this.panelCard = new System.Windows.Forms.Panel();
            this.tableLayoutPanelCard1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelHint = new System.Windows.Forms.Label();
            this.labelD = new System.Windows.Forms.Label();
            this.labelDefinition1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelKnow = new System.Windows.Forms.Label();
            this.buttonStillLearning = new System.Windows.Forms.Button();
            this.buttonKnow = new System.Windows.Forms.Button();
            this.labelStillLearning = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelTitleAndCount = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonFlashcards = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonToStillLearning = new System.Windows.Forms.Button();
            this.buttonToKnow = new System.Windows.Forms.Button();
            this.buttonReturnToPreviousCard = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelDefinition2 = new System.Windows.Forms.Label();
            this.labelT2 = new System.Windows.Forms.Label();
            this.labelD2 = new System.Windows.Forms.Label();
            this.labelTerm2 = new System.Windows.Forms.Label();
            this.tableLayoutPanelCard2 = new System.Windows.Forms.TableLayoutPanel();
            this.panelCard.SuspendLayout();
            this.tableLayoutPanelCard1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanelCard2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCard
            // 
            this.panelCard.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelCard.Controls.Add(this.tableLayoutPanelCard1);
            this.panelCard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelCard.Location = new System.Drawing.Point(16, 75);
            this.panelCard.Name = "panelCard";
            this.panelCard.Size = new System.Drawing.Size(1438, 671);
            this.panelCard.TabIndex = 0;
            // 
            // tableLayoutPanelCard1
            // 
            this.tableLayoutPanelCard1.ColumnCount = 1;
            this.tableLayoutPanelCard1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelCard1.Controls.Add(this.labelHint, 0, 0);
            this.tableLayoutPanelCard1.Controls.Add(this.labelD, 0, 1);
            this.tableLayoutPanelCard1.Controls.Add(this.labelDefinition1, 0, 2);
            this.tableLayoutPanelCard1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tableLayoutPanelCard1.Location = new System.Drawing.Point(3, 0);
            this.tableLayoutPanelCard1.Name = "tableLayoutPanelCard1";
            this.tableLayoutPanelCard1.RowCount = 3;
            this.tableLayoutPanelCard1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanelCard1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelCard1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelCard1.Size = new System.Drawing.Size(1435, 668);
            this.tableLayoutPanelCard1.TabIndex = 0;
            this.tableLayoutPanelCard1.TabStop = true;
            this.tableLayoutPanelCard1.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.tableLayoutPanelCard1_CellPaint);
            this.tableLayoutPanelCard1.Click += new System.EventHandler(this.tableLayoutPanelCard_Click);
            // 
            // labelHint
            // 
            this.labelHint.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelHint.AutoSize = true;
            this.labelHint.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.labelHint.Font = new System.Drawing.Font("Segoe UI Semibold", 15F);
            this.labelHint.Location = new System.Drawing.Point(3, 7);
            this.labelHint.Name = "labelHint";
            this.labelHint.Size = new System.Drawing.Size(127, 35);
            this.labelHint.TabIndex = 2;
            this.labelHint.Text = "Get a hint";
            this.labelHint.Click += new System.EventHandler(this.labelHint_Click);
            // 
            // labelD
            // 
            this.labelD.AutoSize = true;
            this.labelD.BackColor = System.Drawing.SystemColors.ControlLight;
            this.labelD.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.labelD.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelD.Location = new System.Drawing.Point(3, 50);
            this.labelD.Name = "labelD";
            this.labelD.Padding = new System.Windows.Forms.Padding(5);
            this.labelD.Size = new System.Drawing.Size(71, 68);
            this.labelD.TabIndex = 1;
            this.labelD.Text = "D";
            // 
            // labelDefinition1
            // 
            this.labelDefinition1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDefinition1.AutoSize = true;
            this.labelDefinition1.Font = new System.Drawing.Font("Segoe UI Variable Text", 50F);
            this.labelDefinition1.Location = new System.Drawing.Point(424, 337);
            this.labelDefinition1.Name = "labelDefinition1";
            this.labelDefinition1.Size = new System.Drawing.Size(587, 112);
            this.labelDefinition1.TabIndex = 2;
            this.labelDefinition1.Text = "Definition  укр";
            this.labelDefinition1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDefinition1.Click += new System.EventHandler(this.labelDefinition1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.324219F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 92.67578F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 457F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel1.Controls.Add(this.labelKnow, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonStillLearning, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonKnow, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelStillLearning, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1444, 63);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // labelKnow
            // 
            this.labelKnow.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelKnow.AutoSize = true;
            this.labelKnow.Font = new System.Drawing.Font("Segoe UI Semibold", 15F);
            this.labelKnow.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelKnow.Location = new System.Drawing.Point(1276, 14);
            this.labelKnow.Name = "labelKnow";
            this.labelKnow.Size = new System.Drawing.Size(79, 35);
            this.labelKnow.TabIndex = 3;
            this.labelKnow.Text = "Know";
            // 
            // buttonStillLearning
            // 
            this.buttonStillLearning.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonStillLearning.Enabled = false;
            this.buttonStillLearning.Font = new System.Drawing.Font("Segoe UI Semibold", 15F);
            this.buttonStillLearning.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.buttonStillLearning.Location = new System.Drawing.Point(3, 10);
            this.buttonStillLearning.Name = "buttonStillLearning";
            this.buttonStillLearning.Size = new System.Drawing.Size(60, 42);
            this.buttonStillLearning.TabIndex = 0;
            this.buttonStillLearning.TabStop = false;
            this.buttonStillLearning.Text = "1";
            this.buttonStillLearning.UseVisualStyleBackColor = true;
            // 
            // buttonKnow
            // 
            this.buttonKnow.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonKnow.Enabled = false;
            this.buttonKnow.Font = new System.Drawing.Font("Segoe UI Semibold", 15F);
            this.buttonKnow.ForeColor = System.Drawing.Color.DarkGreen;
            this.buttonKnow.Location = new System.Drawing.Point(1382, 7);
            this.buttonKnow.Name = "buttonKnow";
            this.buttonKnow.Size = new System.Drawing.Size(59, 49);
            this.buttonKnow.TabIndex = 1;
            this.buttonKnow.TabStop = false;
            this.buttonKnow.Text = "1";
            this.buttonKnow.UseVisualStyleBackColor = true;
            // 
            // labelStillLearning
            // 
            this.labelStillLearning.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelStillLearning.AutoSize = true;
            this.labelStillLearning.Font = new System.Drawing.Font("Segoe UI Semibold", 15F);
            this.labelStillLearning.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.labelStillLearning.Location = new System.Drawing.Point(69, 14);
            this.labelStillLearning.Name = "labelStillLearning";
            this.labelStillLearning.Size = new System.Drawing.Size(159, 35);
            this.labelStillLearning.TabIndex = 2;
            this.labelStillLearning.Text = "Still learning";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.labelTitleAndCount, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonClose, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonFlashcards, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1896, 94);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // labelTitleAndCount
            // 
            this.labelTitleAndCount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitleAndCount.AutoSize = true;
            this.labelTitleAndCount.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.labelTitleAndCount.Location = new System.Drawing.Point(889, 24);
            this.labelTitleAndCount.Name = "labelTitleAndCount";
            this.labelTitleAndCount.Size = new System.Drawing.Size(117, 46);
            this.labelTitleAndCount.TabIndex = 0;
            this.labelTitleAndCount.Text = "label1";
            this.labelTitleAndCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(173)))), ((int)(((byte)(161)))));
            this.buttonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(10)))), ((int)(((byte)(5)))));
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.buttonClose.Location = new System.Drawing.Point(1786, 16);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(160, 3, 40, 3);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(70, 61);
            this.buttonClose.TabIndex = 10;
            this.buttonClose.Text = "Х";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonFlashcards
            // 
            this.buttonFlashcards.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonFlashcards.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(173)))), ((int)(((byte)(161)))));
            this.buttonFlashcards.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(10)))), ((int)(((byte)(5)))));
            this.buttonFlashcards.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFlashcards.Font = new System.Drawing.Font("Segoe UI Variable Text", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFlashcards.Location = new System.Drawing.Point(40, 16);
            this.buttonFlashcards.Margin = new System.Windows.Forms.Padding(40, 3, 3, 3);
            this.buttonFlashcards.Name = "buttonFlashcards";
            this.buttonFlashcards.Size = new System.Drawing.Size(326, 61);
            this.buttonFlashcards.TabIndex = 2;
            this.buttonFlashcards.TabStop = false;
            this.buttonFlashcards.Text = "Flashcards";
            this.buttonFlashcards.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 12;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel3.Controls.Add(this.buttonToStillLearning, 5, 0);
            this.tableLayoutPanel3.Controls.Add(this.buttonToKnow, 6, 0);
            this.tableLayoutPanel3.Controls.Add(this.buttonReturnToPreviousCard, 3, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 897);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 133F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1896, 133);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // buttonToStillLearning
            // 
            this.buttonToStillLearning.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonToStillLearning.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(173)))), ((int)(((byte)(161)))));
            this.buttonToStillLearning.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonToStillLearning.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(10)))), ((int)(((byte)(5)))));
            this.buttonToStillLearning.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.buttonToStillLearning.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonToStillLearning.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.buttonToStillLearning.Location = new System.Drawing.Point(816, 3);
            this.buttonToStillLearning.Name = "buttonToStillLearning";
            this.buttonToStillLearning.Size = new System.Drawing.Size(95, 79);
            this.buttonToStillLearning.TabIndex = 6;
            this.buttonToStillLearning.Text = "Х";
            this.buttonToStillLearning.UseVisualStyleBackColor = false;
            this.buttonToStillLearning.Click += new System.EventHandler(this.buttonToStillLearning_Click);
            // 
            // buttonToKnow
            // 
            this.buttonToKnow.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonToKnow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(173)))), ((int)(((byte)(161)))));
            this.buttonToKnow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonToKnow.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(10)))), ((int)(((byte)(5)))));
            this.buttonToKnow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.buttonToKnow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonToKnow.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.buttonToKnow.Location = new System.Drawing.Point(973, 3);
            this.buttonToKnow.Name = "buttonToKnow";
            this.buttonToKnow.Size = new System.Drawing.Size(95, 79);
            this.buttonToKnow.TabIndex = 7;
            this.buttonToKnow.Text = "✓";
            this.buttonToKnow.UseVisualStyleBackColor = false;
            // 
            // buttonReturnToPreviousCard
            // 
            this.buttonReturnToPreviousCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(173)))), ((int)(((byte)(161)))));
            this.buttonReturnToPreviousCard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReturnToPreviousCard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(10)))), ((int)(((byte)(5)))));
            this.buttonReturnToPreviousCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReturnToPreviousCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.buttonReturnToPreviousCard.Location = new System.Drawing.Point(474, 3);
            this.buttonReturnToPreviousCard.Name = "buttonReturnToPreviousCard";
            this.buttonReturnToPreviousCard.Size = new System.Drawing.Size(97, 79);
            this.buttonReturnToPreviousCard.TabIndex = 5;
            this.buttonReturnToPreviousCard.Text = "←";
            this.buttonReturnToPreviousCard.UseVisualStyleBackColor = false;
            this.buttonReturnToPreviousCard.Click += new System.EventHandler(this.buttonReturnToPreviousCard_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(214)))), ((int)(((byte)(210)))));
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 139F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1902, 1033);
            this.tableLayoutPanel4.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.panelCard);
            this.panel1.Location = new System.Drawing.Point(210, 117);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1482, 760);
            this.panel1.TabIndex = 6;
            // 
            // labelDefinition2
            // 
            this.labelDefinition2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDefinition2.AutoSize = true;
            this.labelDefinition2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.labelDefinition2.Location = new System.Drawing.Point(339, 162);
            this.labelDefinition2.Name = "labelDefinition2";
            this.labelDefinition2.Size = new System.Drawing.Size(219, 48);
            this.labelDefinition2.TabIndex = 4;
            this.labelDefinition2.Text = "Definition2";
            this.labelDefinition2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDefinition2.Click += new System.EventHandler(this.labelDefinition2_Click);
            // 
            // labelT2
            // 
            this.labelT2.AutoSize = true;
            this.labelT2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.labelT2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.labelT2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelT2.Location = new System.Drawing.Point(3, 304);
            this.labelT2.Name = "labelT2";
            this.labelT2.Padding = new System.Windows.Forms.Padding(5);
            this.labelT2.Size = new System.Drawing.Size(66, 68);
            this.labelT2.TabIndex = 3;
            this.labelT2.Text = "T";
            // 
            // labelD2
            // 
            this.labelD2.AutoSize = true;
            this.labelD2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.labelD2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.labelD2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelD2.Location = new System.Drawing.Point(3, 0);
            this.labelD2.Name = "labelD2";
            this.labelD2.Padding = new System.Windows.Forms.Padding(5);
            this.labelD2.Size = new System.Drawing.Size(71, 68);
            this.labelD2.TabIndex = 2;
            this.labelD2.Text = "D";
            // 
            // labelTerm2
            // 
            this.labelTerm2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTerm2.AutoSize = true;
            this.labelTerm2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.labelTerm2.Location = new System.Drawing.Point(334, 466);
            this.labelTerm2.Name = "labelTerm2";
            this.labelTerm2.Size = new System.Drawing.Size(230, 48);
            this.labelTerm2.TabIndex = 5;
            this.labelTerm2.Text = "labelTerm2";
            this.labelTerm2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTerm2.Click += new System.EventHandler(this.labelTerm2_Click);
            // 
            // tableLayoutPanelCard2
            // 
            this.tableLayoutPanelCard2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tableLayoutPanelCard2.ColumnCount = 1;
            this.tableLayoutPanelCard2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelCard2.Controls.Add(this.labelTerm2, 0, 3);
            this.tableLayoutPanelCard2.Controls.Add(this.labelD2, 0, 0);
            this.tableLayoutPanelCard2.Controls.Add(this.labelT2, 0, 2);
            this.tableLayoutPanelCard2.Controls.Add(this.labelDefinition2, 0, 1);
            this.tableLayoutPanelCard2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tableLayoutPanelCard2.Location = new System.Drawing.Point(72, 429);
            this.tableLayoutPanelCard2.Name = "tableLayoutPanelCard2";
            this.tableLayoutPanelCard2.RowCount = 4;
            this.tableLayoutPanelCard2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelCard2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelCard2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelCard2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelCard2.Size = new System.Drawing.Size(898, 608);
            this.tableLayoutPanelCard2.TabIndex = 1;
            this.tableLayoutPanelCard2.Visible = false;
            this.tableLayoutPanelCard2.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.tableLayoutPanelCard2_CellPaint);
            this.tableLayoutPanelCard2.Click += new System.EventHandler(this.tableLayoutPanelCard2_Click);
            // 
            // FlashcardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanelCard2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FlashcardForm";
            this.Text = "FlascardForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelCard.ResumeLayout(false);
            this.tableLayoutPanelCard1.ResumeLayout(false);
            this.tableLayoutPanelCard1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanelCard2.ResumeLayout(false);
            this.tableLayoutPanelCard2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCard;
        private System.Windows.Forms.Label labelHint;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonStillLearning;
        private System.Windows.Forms.Button buttonKnow;
        private System.Windows.Forms.Label labelStillLearning;
        private System.Windows.Forms.Label labelD;
        private System.Windows.Forms.Label labelKnow;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelCard1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label labelTitleAndCount;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button buttonToStillLearning;
        private System.Windows.Forms.Button buttonToKnow;
        private System.Windows.Forms.Button buttonReturnToPreviousCard;
        private System.Windows.Forms.Label labelDefinition1;
        private System.Windows.Forms.Button buttonFlashcards;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelDefinition2;
        private System.Windows.Forms.Label labelT2;
        private System.Windows.Forms.Label labelD2;
        private System.Windows.Forms.Label labelTerm2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelCard2;
    }
}