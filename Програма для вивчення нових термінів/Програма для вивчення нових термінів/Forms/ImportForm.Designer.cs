namespace Програма_для_вивчення_нових_термінів
{
    partial class ImportForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonImport = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.symbolForSeparate = new System.Windows.Forms.TextBox();
            this.separatorCustom = new System.Windows.Forms.RadioButton();
            this.separatorComma = new System.Windows.Forms.RadioButton();
            this.separatorTab = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.importedData = new System.Windows.Forms.RichTextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(214)))), ((int)(((byte)(210)))));
            this.panel1.Controls.Add(this.buttonCancel);
            this.panel1.Controls.Add(this.buttonImport);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.importedData);
            this.panel1.Controls.Add(this.labelDescription);
            this.panel1.Controls.Add(this.labelTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1682, 953);
            this.panel1.TabIndex = 0;
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(173)))), ((int)(((byte)(161)))));
            this.buttonCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(10)))), ((int)(((byte)(5)))));
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancel.Location = new System.Drawing.Point(424, 814);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(199, 48);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonImport
            // 
            this.buttonImport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(173)))), ((int)(((byte)(161)))));
            this.buttonImport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonImport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(10)))), ((int)(((byte)(5)))));
            this.buttonImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonImport.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonImport.Location = new System.Drawing.Point(75, 800);
            this.buttonImport.Name = "buttonImport";
            this.buttonImport.Size = new System.Drawing.Size(269, 74);
            this.buttonImport.TabIndex = 5;
            this.buttonImport.Text = "IMPORT";
            this.buttonImport.UseVisualStyleBackColor = false;
            this.buttonImport.Click += new System.EventHandler(this.buttonImport_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.symbolForSeparate);
            this.groupBox1.Controls.Add(this.separatorCustom);
            this.groupBox1.Controls.Add(this.separatorComma);
            this.groupBox1.Controls.Add(this.separatorTab);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(75, 645);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(548, 127);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Separator";
            // 
            // symbolForSeparate
            // 
            this.symbolForSeparate.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.symbolForSeparate.Location = new System.Drawing.Point(413, 54);
            this.symbolForSeparate.Name = "symbolForSeparate";
            this.symbolForSeparate.ReadOnly = true;
            this.symbolForSeparate.Size = new System.Drawing.Size(100, 41);
            this.symbolForSeparate.TabIndex = 4;
            this.symbolForSeparate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.symbolForSeparate_KeyPress);
            // 
            // separatorCustom
            // 
            this.separatorCustom.AutoSize = true;
            this.separatorCustom.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.separatorCustom.Location = new System.Drawing.Point(285, 54);
            this.separatorCustom.Name = "separatorCustom";
            this.separatorCustom.Size = new System.Drawing.Size(121, 39);
            this.separatorCustom.TabIndex = 3;
            this.separatorCustom.Text = "Custom";
            this.separatorCustom.UseVisualStyleBackColor = true;
            this.separatorCustom.CheckedChanged += new System.EventHandler(this.separatorCustom_CheckedChanged);
            // 
            // separatorComma
            // 
            this.separatorComma.AutoSize = true;
            this.separatorComma.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.separatorComma.Location = new System.Drawing.Point(145, 54);
            this.separatorComma.Name = "separatorComma";
            this.separatorComma.Size = new System.Drawing.Size(123, 39);
            this.separatorComma.TabIndex = 2;
            this.separatorComma.TabStop = true;
            this.separatorComma.Text = "Comma";
            this.separatorComma.UseVisualStyleBackColor = true;
            // 
            // separatorTab
            // 
            this.separatorTab.AutoSize = true;
            this.separatorTab.Checked = true;
            this.separatorTab.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.separatorTab.Location = new System.Drawing.Point(42, 54);
            this.separatorTab.Name = "separatorTab";
            this.separatorTab.Size = new System.Drawing.Size(74, 39);
            this.separatorTab.TabIndex = 1;
            this.separatorTab.TabStop = true;
            this.separatorTab.Text = "Tab";
            this.separatorTab.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 20F);
            this.label3.Location = new System.Drawing.Point(68, 580);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(468, 46);
            this.label3.TabIndex = 3;
            this.label3.Text = "Between Term and Definition";
            // 
            // importedData
            // 
            this.importedData.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.importedData.Location = new System.Drawing.Point(75, 170);
            this.importedData.Name = "importedData";
            this.importedData.Size = new System.Drawing.Size(953, 390);
            this.importedData.TabIndex = 0;
            this.importedData.Text = "";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.labelDescription.Location = new System.Drawing.Point(68, 112);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(1038, 46);
            this.labelDescription.TabIndex = 1;
            this.labelDescription.Text = "Copy and Paste your data here (from Word, Excel, Google Docs, etc.)";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.labelTitle.Location = new System.Drawing.Point(66, 39);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(405, 62);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Import your data";
            // 
            // ImportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1682, 953);
            this.Controls.Add(this.panel1);
            this.Name = "ImportForm";
            this.Text = "ImportForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.RichTextBox importedData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonImport;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton separatorComma;
        private System.Windows.Forms.RadioButton separatorTab;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.RadioButton separatorCustom;
        private System.Windows.Forms.TextBox symbolForSeparate;
    }
}