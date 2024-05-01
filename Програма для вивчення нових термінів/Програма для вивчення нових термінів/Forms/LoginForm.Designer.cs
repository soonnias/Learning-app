namespace Програма_для_вивчення_нових_термінів
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.loginButton = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.labelLogIn = new System.Windows.Forms.Label();
            this.labelQuestion = new System.Windows.Forms.Label();
            this.signUpButton = new System.Windows.Forms.Button();
            this.exitLabel = new System.Windows.Forms.Label();
            this.showPasswordCB = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(173)))), ((int)(((byte)(161)))));
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(10)))), ((int)(((byte)(5)))));
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginButton.Location = new System.Drawing.Point(108, 317);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(172, 53);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "LOG IN";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F);
            this.passwordTextBox.ForeColor = System.Drawing.Color.DarkGray;
            this.passwordTextBox.Location = new System.Drawing.Point(77, 157);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(235, 34);
            this.passwordTextBox.TabIndex = 2;
            this.passwordTextBox.Text = "Password";
            this.passwordTextBox.Enter += new System.EventHandler(this.passwordTextBox_Enter);
            this.passwordTextBox.Leave += new System.EventHandler(this.passwordTextBox_Leave);
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usernameTextBox.ForeColor = System.Drawing.Color.DarkGray;
            this.usernameTextBox.Location = new System.Drawing.Point(77, 110);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(235, 34);
            this.usernameTextBox.TabIndex = 1;
            this.usernameTextBox.Text = "User Name";
            this.usernameTextBox.Enter += new System.EventHandler(this.usernameTextBox_Enter);
            this.usernameTextBox.Leave += new System.EventHandler(this.usernameTextBox_Leave);
            // 
            // labelLogIn
            // 
            this.labelLogIn.AutoSize = true;
            this.labelLogIn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogIn.Location = new System.Drawing.Point(135, 48);
            this.labelLogIn.Name = "labelLogIn";
            this.labelLogIn.Size = new System.Drawing.Size(118, 41);
            this.labelLogIn.TabIndex = 4;
            this.labelLogIn.Text = "LOG IN";
            // 
            // labelQuestion
            // 
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelQuestion.Location = new System.Drawing.Point(70, 422);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(248, 27);
            this.labelQuestion.TabIndex = 5;
            this.labelQuestion.Text = "Don\'t have an account yet?";
            // 
            // signUpButton
            // 
            this.signUpButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(173)))), ((int)(((byte)(161)))));
            this.signUpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signUpButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(10)))), ((int)(((byte)(5)))));
            this.signUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signUpButton.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 10F);
            this.signUpButton.Location = new System.Drawing.Point(107, 463);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(172, 53);
            this.signUpButton.TabIndex = 5;
            this.signUpButton.Text = "SIGN UP";
            this.signUpButton.UseVisualStyleBackColor = false;
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // exitLabel
            // 
            this.exitLabel.AutoSize = true;
            this.exitLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitLabel.Location = new System.Drawing.Point(460, 9);
            this.exitLabel.Name = "exitLabel";
            this.exitLabel.Size = new System.Drawing.Size(32, 31);
            this.exitLabel.TabIndex = 7;
            this.exitLabel.Text = "X";
            this.exitLabel.Click += new System.EventHandler(this.exitLabel_Click);
            // 
            // showPasswordCB
            // 
            this.showPasswordCB.AutoSize = true;
            this.showPasswordCB.Checked = true;
            this.showPasswordCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showPasswordCB.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showPasswordCB.Location = new System.Drawing.Point(109, 210);
            this.showPasswordCB.Name = "showPasswordCB";
            this.showPasswordCB.Size = new System.Drawing.Size(170, 31);
            this.showPasswordCB.TabIndex = 3;
            this.showPasswordCB.Text = "Show password";
            this.showPasswordCB.UseVisualStyleBackColor = true;
            this.showPasswordCB.CheckedChanged += new System.EventHandler(this.showPasswordCB_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(214)))), ((int)(((byte)(210)))));
            this.panel1.Controls.Add(this.labelLogIn);
            this.panel1.Controls.Add(this.showPasswordCB);
            this.panel1.Controls.Add(this.loginButton);
            this.panel1.Controls.Add(this.passwordTextBox);
            this.panel1.Controls.Add(this.signUpButton);
            this.panel1.Controls.Add(this.usernameTextBox);
            this.panel1.Controls.Add(this.labelQuestion);
            this.panel1.Location = new System.Drawing.Point(57, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(386, 537);
            this.panel1.TabIndex = 9;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(214)))), ((int)(((byte)(210)))));
            this.ClientSize = new System.Drawing.Size(500, 600);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.exitLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label labelLogIn;
        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.Button signUpButton;
        private System.Windows.Forms.Label exitLabel;
        private System.Windows.Forms.CheckBox showPasswordCB;
        private System.Windows.Forms.Panel panel1;
    }
}

