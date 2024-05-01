namespace Програма_для_вивчення_нових_термінів
{
    partial class SetsForCombine
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.button = new System.Windows.Forms.Button();
            this.pictureCombine = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCombine)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20F);
            this.label1.Location = new System.Drawing.Point(799, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // button
            // 
            this.button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(173)))), ((int)(((byte)(161)))));
            this.button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(10)))), ((int)(((byte)(5)))));
            this.button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button.Location = new System.Drawing.Point(24, 22);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(732, 85);
            this.button.TabIndex = 2;
            this.button.Text = "button1";
            this.button.UseVisualStyleBackColor = false;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // pictureCombine
            // 
            this.pictureCombine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureCombine.Image = global::Програма_для_вивчення_нових_термінів.Properties.Resources.free_icon_add_button_2740600;
            this.pictureCombine.Location = new System.Drawing.Point(1051, 22);
            this.pictureCombine.Name = "pictureCombine";
            this.pictureCombine.Size = new System.Drawing.Size(84, 85);
            this.pictureCombine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureCombine.TabIndex = 4;
            this.pictureCombine.TabStop = false;
            this.pictureCombine.Click += new System.EventHandler(this.pictureCombine_Click);
            // 
            // SetsForCombine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(214)))), ((int)(((byte)(210)))));
            this.Controls.Add(this.pictureCombine);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button);
            this.Name = "SetsForCombine";
            this.Size = new System.Drawing.Size(1177, 136);
            ((System.ComponentModel.ISupportInitialize)(this.pictureCombine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.PictureBox pictureCombine;
    }
}
