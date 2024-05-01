using System;
using System.Drawing;
using System.Windows.Forms;

namespace Програма_для_вивчення_нових_термінів
{
    public partial class LoginForm : Form
    {
        private AccountManager _accountManager;

        public LoginForm()
        {
            InitializeComponent();
            _accountManager = new AccountManager();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (!IsInputValid())
            {
                //MessageBox.Show("Please fill in all fields.");
                AppContext.ShowMessage("Please fill in all fields.", "Error", MessageType.Error);
                return;
            }

            AttemptLogin(usernameTextBox.Text, passwordTextBox.Text);
        }

        private bool IsInputValid()
        {
            return usernameTextBox.Text != "User Name" && passwordTextBox.Text != "Password";
        }

        private void AttemptLogin(string userName, string password)
        {
            User loggedInUser = _accountManager.SignIn(userName, password);
            if (loggedInUser != null)
            {
                AppContext.Instance.SetCurrentUser(loggedInUser);
                OpenMainForm();
            }
            //else
            //{
            //    //MessageBox.Show("Login failed. Please check your username and password.");
            //    AppContext.ShowMessage("Login failed. Please check your username and password.", "Error", MessageType.Error);
            //}
        }

        private void OpenMainForm()
        {
            this.Hide();
            var mainForm = new FormForMain();
            mainForm.Show();
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            OpenSignUpForm();
        }

        private void OpenSignUpForm()
        {
            this.Hide();
            var signUpForm = new SignUpForm();
            signUpForm.Show();
        }

        private void exitLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void usernameTextBox_Enter(object sender, EventArgs e)
        {
            ResetTextBox(usernameTextBox, "User Name");
        }

        private void usernameTextBox_Leave(object sender, EventArgs e)
        {
            SetDefaultText(usernameTextBox, "User Name");
        }

        private void passwordTextBox_Enter(object sender, EventArgs e)
        {
            ResetTextBox(passwordTextBox, "Password");
        }

        private void passwordTextBox_Leave(object sender, EventArgs e)
        {
            SetDefaultText(passwordTextBox, "Password");      
        }

        private void showPasswordCB_CheckedChanged(object sender, EventArgs e)
        {
            if (showPasswordCB.Checked || passwordTextBox.Text == "Password")
            {
                passwordTextBox.PasswordChar = '\0';
            }
            else
            {
                passwordTextBox.PasswordChar = '*';
            }
        }

        private void ResetTextBox(TextBox textBox, string defaultText)
        {
            if (textBox.Text == defaultText)
            {
                textBox.Clear();
                textBox.ForeColor = Color.Black;
                textBox.PasswordChar = showPasswordCB.Checked ? '\0' : '*';
            }
        }

        private void SetDefaultText(TextBox textBox, string defaultText)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = defaultText;
                textBox.ForeColor = Color.DarkGray;
                textBox.PasswordChar = '\0';
            }
            else textBox.PasswordChar = showPasswordCB.Checked ? '\0' : '*';
        }
    }
}
