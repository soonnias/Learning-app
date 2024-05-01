using System;
using System.Drawing;
using System.Linq;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Програма_для_вивчення_нових_термінів
{
    public partial class SignUpForm : Form
    {
        private AccountManager accountManager;

        public SignUpForm()
        {
            InitializeComponent();
            accountManager = new AccountManager();
            InitializeDateTimePicker();
        }

        private void InitializeDateTimePicker()
        {
            dateOfBirthTimePicker.MaxDate = DateTime.Now;
            dateOfBirthTimePicker.Format = DateTimePickerFormat.Custom;
            dateOfBirthTimePicker.CustomFormat = "dd/MM/yyyy";
            dateOfBirthTimePicker.ShowUpDown = true;
        }

        private void showPasswordCB_CheckedChanged(object sender, EventArgs e)
        {
            TogglePasswordVisibility(passwordTextBox, "Password");
            TogglePasswordVisibility(passwordConfirmationTextBox, "Password confirmation");
        }

        private void TogglePasswordVisibility(TextBox textBox, string defaultText)
        {
            if (showPasswordCB.Checked || textBox.Text == defaultText)
            {
                textBox.PasswordChar = '\0';
            }
            else
            {
                textBox.PasswordChar = '*'; 
            }
        }
        private void exitLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm newf = new LoginForm();
            newf.Show();
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            if (!AllEntriesValid())
            {
                //MessageBox.Show("Please fill in all fields correctly.");
                AppContext.ShowMessage("Please fill in all fields correctly.", "Error", MessageType.Error);
                labelErrors.Text = "Please fill in all fields correctly.";
                return;
            }

            if (passwordTextBox.Text != passwordConfirmationTextBox.Text)
            {
                //MessageBox.Show("Passwords do not match");
                AppContext.ShowMessage("Passwords do not match", "Error", MessageType.Error);
                labelErrors.Text = "Passwords do not match";
                return;
            }

            if (accountManager.SignUp(usernameTextBox.Text, dateOfBirthTimePicker.Value, emailTextBox.Text, passwordTextBox.Text))
            {
                loginButton_Click(sender, e);
            }
            else
            {
                usernameTextBox.Clear();
            }
        }

        private bool AllEntriesValid()
        {
            return !string.IsNullOrWhiteSpace(usernameTextBox.Text) && usernameTextBox.Text != "User Name" &&
                   !string.IsNullOrWhiteSpace(passwordTextBox.Text) && passwordTextBox.Text != "Password" &&
                   !string.IsNullOrWhiteSpace(passwordConfirmationTextBox.Text) && passwordConfirmationTextBox.Text != "Password confirmation" &&
                   !string.IsNullOrWhiteSpace(emailTextBox.Text) && emailTextBox.Text != "Email" && 
                   passwordTextBox.ForeColor != Color.Red && emailTextBox.ForeColor != Color.Red;
        }

        private void HandleTextBoxEnter(object sender, EventArgs e, string defaultText)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null && textBox.Text == defaultText)
            {
                textBox.Text = "";
                textBox.ForeColor = Color.Black;
                
                
                if(defaultText.Contains("Password"))
                    textBox.PasswordChar = '*';
                    if (showPasswordCB.Checked) textBox.PasswordChar = '\0';
            }
        }

        private void HandleTextBoxLeave(object sender, EventArgs e, string defaultText, Func<string, bool> validate = null)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {
                textBox.ForeColor = Color.Black;
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = defaultText;
                    textBox.ForeColor = Color.DarkGray;
                    textBox.PasswordChar = '\0';
                    
                }
                else if (validate != null && !validate(textBox.Text))
                {
                    textBox.ForeColor = Color.Red;
                    labelErrors.Text = GetValidationError(textBox.Name);
                }
                else if (validate != null)
                {
                    labelErrors.Text = "";
                }
            }
        }

        private string GetValidationError(string textBoxName)
        {
            switch (textBoxName)
            {
                case "passwordTextBox":
                    return "Password must be 6-20 characters long, include digits, upper and lower case letters.";
                case "emailTextBox":
                    return "Email must be a valid gmail address (example@gmail.com).";
                default:
                    return "";
            }
        }

        private void usernameTextBox_Enter(object sender, EventArgs e)
        {
            HandleTextBoxEnter(sender, e, "User Name");
        }

        private void usernameTextBox_Leave(object sender, EventArgs e)
        {
            HandleTextBoxLeave(sender, e, "User Name");
        }

        private void passwordTextBox_Enter(object sender, EventArgs e)
        {
            HandleTextBoxEnter(sender, e, "Password");
        }

        private void passwordTextBox_Leave(object sender, EventArgs e)
        {
            HandleTextBoxLeave(sender, e, "Password", IsPasswordValid);
        }

        private bool IsPasswordValid(string password)
        {
            return password.Length >= 6 && password.Length <= 20 &&
                   password.Any(char.IsDigit) &&
                   password.Any(char.IsLower) &&
                   password.Any(char.IsUpper);
        }

        private void emailTextBox_Enter(object sender, EventArgs e)
        {
            HandleTextBoxEnter(sender, e, "Email");
        }

        private void emailTextBox_Leave(object sender, EventArgs e)
        {
            HandleTextBoxLeave(sender, e, "Email", ValidateEmail);
        }

        private void textBoxPasswordConfirmation_Enter(object sender, EventArgs e)
        {
            HandleTextBoxEnter(sender, e, "Password confirmation");
        }
        private void textBoxPasswordConfirmation_Leave(object sender, EventArgs e)
        {
            HandleTextBoxLeave(sender, e, "Password confirmation");
        }

        //private bool ValidateEmail(string email)
        //{
        //    string emailPattern = @"^\S+@gmail\.com$";
        //    return Regex.IsMatch(email, emailPattern);
        //}

        bool ValidateEmail(string email)
        {
            var trimmedEmail = email.Trim();

            if (trimmedEmail.EndsWith("."))
            {
                return false; // suggested by @TK-421
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == trimmedEmail;
            }
            catch
            {
                return false;
            }
        }

        private void usernameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; 
            }
        }

        private void emailTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) &&
                e.KeyChar != '@' && e.KeyChar != '.')
            {
                e.Handled = true;  
            }
        }
    }
}
