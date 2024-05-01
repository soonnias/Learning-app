namespace Програма_для_вивчення_нових_термінів
{
    partial class SignUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpForm));
            this.labelSignUp = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.signUpButton = new System.Windows.Forms.Button();
            this.labelQuestion = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.exitLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.dateOfBirthTimePicker = new System.Windows.Forms.DateTimePicker();
            this.showPasswordCB = new System.Windows.Forms.CheckBox();
            this.passwordConfirmationTextBox = new System.Windows.Forms.TextBox();
            this.labelErrors = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelSignUp
            // 
            this.labelSignUp.AutoSize = true;
            this.labelSignUp.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.labelSignUp.Location = new System.Drawing.Point(181, 49);
            this.labelSignUp.Name = "labelSignUp";
            this.labelSignUp.Size = new System.Drawing.Size(138, 41);
            this.labelSignUp.TabIndex = 0;
            this.labelSignUp.Text = "SIGN UP";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailTextBox.ForeColor = System.Drawing.Color.DarkGray;
            this.emailTextBox.Location = new System.Drawing.Point(135, 199);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(231, 34);
            this.emailTextBox.TabIndex = 2;
            this.emailTextBox.Text = "Email";
            this.emailTextBox.Enter += new System.EventHandler(this.emailTextBox_Enter);
            this.emailTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.emailTextBox_KeyPress);
            this.emailTextBox.Leave += new System.EventHandler(this.emailTextBox_Leave);
            // 
            // signUpButton
            // 
            this.signUpButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(173)))), ((int)(((byte)(161)))));
            this.signUpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signUpButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(10)))), ((int)(((byte)(5)))));
            this.signUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signUpButton.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.signUpButton.Location = new System.Drawing.Point(164, 425);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(172, 53);
            this.signUpButton.TabIndex = 6;
            this.signUpButton.Text = "SIGN UP";
            this.signUpButton.UseVisualStyleBackColor = false;
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // labelQuestion
            // 
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelQuestion.Location = new System.Drawing.Point(133, 488);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(234, 28);
            this.labelQuestion.TabIndex = 9;
            this.labelQuestion.Text = "Already have an account?";
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(173)))), ((int)(((byte)(161)))));
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(10)))), ((int)(((byte)(5)))));
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginButton.Location = new System.Drawing.Point(164, 531);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(172, 53);
            this.loginButton.TabIndex = 7;
            this.loginButton.Text = "LOG IN";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // exitLabel
            // 
            this.exitLabel.AutoSize = true;
            this.exitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitLabel.Location = new System.Drawing.Point(456, 9);
            this.exitLabel.Name = "exitLabel";
            this.exitLabel.Size = new System.Drawing.Size(32, 31);
            this.exitLabel.TabIndex = 10;
            this.exitLabel.Text = "X";
            this.exitLabel.Click += new System.EventHandler(this.exitLabel_Click);
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usernameTextBox.ForeColor = System.Drawing.Color.DarkGray;
            this.usernameTextBox.Location = new System.Drawing.Point(134, 108);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(233, 34);
            this.usernameTextBox.TabIndex = 0;
            this.usernameTextBox.Text = "User Name";
            this.usernameTextBox.Enter += new System.EventHandler(this.usernameTextBox_Enter);
            this.usernameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.usernameTextBox_KeyPress);
            this.usernameTextBox.Leave += new System.EventHandler(this.usernameTextBox_Leave);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordTextBox.ForeColor = System.Drawing.Color.DarkGray;
            this.passwordTextBox.Location = new System.Drawing.Point(134, 245);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(233, 34);
            this.passwordTextBox.TabIndex = 3;
            this.passwordTextBox.Text = "Password";
            this.passwordTextBox.Enter += new System.EventHandler(this.passwordTextBox_Enter);
            this.passwordTextBox.Leave += new System.EventHandler(this.passwordTextBox_Leave);
            // 
            // dateOfBirthTimePicker
            // 
            this.dateOfBirthTimePicker.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateOfBirthTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateOfBirthTimePicker.Location = new System.Drawing.Point(237, 153);
            this.dateOfBirthTimePicker.Name = "dateOfBirthTimePicker";
            this.dateOfBirthTimePicker.Size = new System.Drawing.Size(129, 34);
            this.dateOfBirthTimePicker.TabIndex = 1;
            // 
            // showPasswordCB
            // 
            this.showPasswordCB.AutoSize = true;
            this.showPasswordCB.Checked = true;
            this.showPasswordCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showPasswordCB.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showPasswordCB.Location = new System.Drawing.Point(165, 330);
            this.showPasswordCB.Name = "showPasswordCB";
            this.showPasswordCB.Size = new System.Drawing.Size(170, 31);
            this.showPasswordCB.TabIndex = 5;
            this.showPasswordCB.Text = "Show password";
            this.showPasswordCB.UseVisualStyleBackColor = true;
            this.showPasswordCB.CheckedChanged += new System.EventHandler(this.showPasswordCB_CheckedChanged);
            // 
            // passwordConfirmationTextBox
            // 
            this.passwordConfirmationTextBox.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordConfirmationTextBox.ForeColor = System.Drawing.Color.DarkGray;
            this.passwordConfirmationTextBox.Location = new System.Drawing.Point(134, 286);
            this.passwordConfirmationTextBox.Name = "passwordConfirmationTextBox";
            this.passwordConfirmationTextBox.Size = new System.Drawing.Size(233, 34);
            this.passwordConfirmationTextBox.TabIndex = 4;
            this.passwordConfirmationTextBox.Text = "Password confirmation";
            this.passwordConfirmationTextBox.Enter += new System.EventHandler(this.textBoxPasswordConfirmation_Enter);
            this.passwordConfirmationTextBox.Leave += new System.EventHandler(this.textBoxPasswordConfirmation_Leave);
            // 
            // labelErrors
            // 
            this.labelErrors.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelErrors.AutoSize = true;
            this.labelErrors.Font = new System.Drawing.Font("Segoe UI Variable Text", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelErrors.ForeColor = System.Drawing.Color.Maroon;
            this.labelErrors.Location = new System.Drawing.Point(238, 22);
            this.labelErrors.Name = "labelErrors";
            this.labelErrors.Size = new System.Drawing.Size(0, 17);
            this.labelErrors.TabIndex = 16;
            this.labelErrors.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.labelErrors, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 360);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(476, 61);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(133, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 28);
            this.label1.TabIndex = 18;
            this.label1.Text = "D.O.B.";
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(214)))), ((int)(((byte)(210)))));
            this.ClientSize = new System.Drawing.Size(500, 600);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.passwordConfirmationTextBox);
            this.Controls.Add(this.showPasswordCB);
            this.Controls.Add(this.dateOfBirthTimePicker);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.exitLabel);
            this.Controls.Add(this.labelQuestion);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.signUpButton);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.labelSignUp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SignUpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUp";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSignUp;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Button signUpButton;
        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label exitLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.DateTimePicker dateOfBirthTimePicker;
        private System.Windows.Forms.CheckBox showPasswordCB;
        private System.Windows.Forms.TextBox passwordConfirmationTextBox;
        private System.Windows.Forms.Label labelErrors;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
    }
}