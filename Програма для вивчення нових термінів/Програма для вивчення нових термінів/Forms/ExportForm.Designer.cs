namespace Програма_для_вивчення_нових_термінів
{
    partial class ExportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExportForm));
            this.labelQuestion = new System.Windows.Forms.Label();
            this.radioButtonExcel = new System.Windows.Forms.RadioButton();
            this.radioButtonTxt = new System.Windows.Forms.RadioButton();
            this.buttonExport = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelQuestion
            // 
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.Font = new System.Drawing.Font("Segoe UI Variable Text", 15F);
            this.labelQuestion.Location = new System.Drawing.Point(16, 31);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(501, 33);
            this.labelQuestion.TabIndex = 0;
            this.labelQuestion.Text = "In what format you want to export your set?";
            // 
            // radioButtonExcel
            // 
            this.radioButtonExcel.AutoSize = true;
            this.radioButtonExcel.Checked = true;
            this.radioButtonExcel.Font = new System.Drawing.Font("Segoe UI Variable Text", 15F);
            this.radioButtonExcel.Location = new System.Drawing.Point(205, 72);
            this.radioButtonExcel.Name = "radioButtonExcel";
            this.radioButtonExcel.Size = new System.Drawing.Size(91, 37);
            this.radioButtonExcel.TabIndex = 1;
            this.radioButtonExcel.TabStop = true;
            this.radioButtonExcel.Text = "Excel";
            this.radioButtonExcel.UseVisualStyleBackColor = true;
            // 
            // radioButtonTxt
            // 
            this.radioButtonTxt.AutoSize = true;
            this.radioButtonTxt.Font = new System.Drawing.Font("Segoe UI Variable Text", 15F);
            this.radioButtonTxt.Location = new System.Drawing.Point(205, 108);
            this.radioButtonTxt.Name = "radioButtonTxt";
            this.radioButtonTxt.Size = new System.Drawing.Size(66, 37);
            this.radioButtonTxt.TabIndex = 2;
            this.radioButtonTxt.TabStop = true;
            this.radioButtonTxt.Text = "Txt";
            this.radioButtonTxt.UseVisualStyleBackColor = true;
            // 
            // buttonExport
            // 
            this.buttonExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(173)))), ((int)(((byte)(161)))));
            this.buttonExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExport.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.buttonExport.Location = new System.Drawing.Point(80, 160);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(162, 59);
            this.buttonExport.TabIndex = 3;
            this.buttonExport.Text = "Export";
            this.buttonExport.UseVisualStyleBackColor = false;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(173)))), ((int)(((byte)(161)))));
            this.buttonCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Segoe UI Variable Text", 15F);
            this.buttonCancel.Location = new System.Drawing.Point(284, 165);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(128, 49);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // ExportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(214)))), ((int)(((byte)(210)))));
            this.ClientSize = new System.Drawing.Size(542, 231);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonExport);
            this.Controls.Add(this.radioButtonTxt);
            this.Controls.Add(this.radioButtonExcel);
            this.Controls.Add(this.labelQuestion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ExportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Export set";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.RadioButton radioButtonExcel;
        private System.Windows.Forms.RadioButton radioButtonTxt;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.Button buttonCancel;
    }
}