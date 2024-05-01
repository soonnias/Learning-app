using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Програма_для_вивчення_нових_термінів
{
    public partial class SettingForm : Form
    {
        User currentUser;
        public SettingForm()
        {
            InitializeComponent();
            currentUser = AppContext.Instance.CurrentUser;
            dateOfBirthPicker.MaxDate = DateTime.Today;
            updateLabel();
        }
        private void updateLabel()
        {
            userNameUserLabel.Text = currentUser.UserName;
            dateOfBirthUserLabel.Text = currentUser.DateOfBirth.Date.ToShortDateString();
            emailUserLabel.Text = currentUser.Email;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            buttonEdit.Visible = buttonLogOut.Visible = buttonDelete.Visible = false;
            buttonCancel.Visible = buttonSave.Visible = true;

            dateOfBirthUserLabel.Visible = userNameUserLabel.Visible = emailUserLabel.Visible = false;
            dateOfBirthPicker.Visible = textBoxEmail.Visible = textBoxUsername.Visible = true;
            textBoxUsername.Text = currentUser.UserName;
            dateOfBirthPicker.Value = currentUser.DateOfBirth.Date;
            textBoxEmail.Text = currentUser.Email;
        }

        private void LogoutOrDeleteAction(ProgramState newState)
        {
            var result = MessageBox.Show(newState == ProgramState.Logout ?
                "Are you sure you want to log out of your account?" :
                "Are you sure you want to delete your account?",
                "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                if (newState == ProgramState.DeleteAccount)
                {
                    AccountManager manager = new AccountManager();
                    manager.DeleteCurrentUser();
                }
                FormForMain mainForm = Application.OpenForms.OfType<FormForMain>().FirstOrDefault(f => f.Name == "FormForMain");
                if (mainForm != null)
                {
                    FormForMain.programState = newState;
                    LoginForm loginForm = new LoginForm();
                    loginForm.Show();
                    mainForm.Close();
                }
            }
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            LogoutOrDeleteAction(ProgramState.Logout);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            LogoutOrDeleteAction(ProgramState.DeleteAccount);
        }

        //private void buttonLogOut_Click(object sender, EventArgs e)
        //{
        //    DialogResult result = MessageBox.Show("Are you sure you want to log out of your account?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

        //    if (result == DialogResult.OK)
        //    {
        //        LoginForm loginForm = new LoginForm();            
        //        FormForMain mainForm = Application.OpenForms.OfType<FormForMain>().Where(x => x.Name == "FormForMain").FirstOrDefault();
        //        //mainForm.closeAllProgram = "false";
        //        FormForMain.programState = ProgramState.Logout;
        //        loginForm.Show();
        //        mainForm.Close();               
        //    }
        //}

        //private void buttonDelete_Click(object sender, EventArgs e)
        //{
        //    DialogResult result = MessageBox.Show("Are you sure you want to delete your account?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

        //    if (result == DialogResult.OK)
        //    {
        //        AccountManager manager = new AccountManager();
        //        manager.DeleteCurrentUser();
        //        LoginForm loginForm = new LoginForm();
        //        FormForMain mainForm = Application.OpenForms.OfType<FormForMain>().Where(x => x.Name == "FormForMain").FirstOrDefault();
        //        //mainForm.closeAllProgram = "none";
        //        FormForMain.programState = ProgramState.DeleteAccount;
        //        loginForm.Show();
        //        mainForm.Close();

        //    }
        //}

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            buttonEdit.Visible = buttonLogOut.Visible = buttonDelete.Visible = true;
            buttonCancel.Visible = buttonSave.Visible = false;

            dateOfBirthUserLabel.Visible = userNameUserLabel.Visible = emailUserLabel.Visible = true;
            dateOfBirthPicker.Visible = textBoxEmail.Visible = textBoxUsername.Visible = false;
        }

        private const string EmailPattern = @"^\S+@gmail\.com$";

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string userName = textBoxUsername.Text;
            string enteredEmail = textBoxEmail.Text.Trim();

            if (!ValidateUserName(userName) || !ValidateEmail(enteredEmail))
            {
                return;
            }

            UpdateUserDetails(userName, enteredEmail);
            //MessageBox.Show("Changes are saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            AppContext.ShowMessage("Changes are saved", "Success", MessageType.Success);
            buttonCancel_Click(sender, e);
            updateLabel();
        }

        private bool ValidateUserName(string userName)
        {
            if (userName != AppContext.Instance.CurrentUser.UserName)
            {
                AccountManager manager = new AccountManager();
                if (manager.DoesExistName(userName))
                {
                    AppContext.ShowMessage("User with this username already exists.", "Error", MessageType.Error);
                    return false;
                }
            }
            return true;
        }

        private bool ValidateEmail(string email)
        {
            if (!Regex.IsMatch(email, EmailPattern))
            {
                AppContext.ShowMessage("Please enter a valid Gmail.com email address.", "Error", MessageType.Error);
                return false;
            }
            return true;
        }

        private void UpdateUserDetails(string userName, string email)
        {
            string previousname = userNameUserLabel.Text;
            AppContext.Instance.CurrentUser.UserName = userName;
            AppContext.Instance.CurrentUser.DateOfBirth = dateOfBirthPicker.Value;
            AppContext.Instance.CurrentUser.Email = email;

            AccountManager accountManager = new AccountManager();
            accountManager.UpdateUser(AppContext.Instance.CurrentUser, previousname);
        }

    }
}
