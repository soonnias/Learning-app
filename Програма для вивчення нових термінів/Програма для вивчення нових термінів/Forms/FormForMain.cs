using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Програма_для_вивчення_нових_термінів
{
    public partial class FormForMain : Form
    {
        public static ProgramState programState = ProgramState.Running;

        //public bool closeAllProgram = true;
        //public string closeAllProgram = "true";
        public FormForMain()
        {
            InitializeComponent(); 
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(1920, 1080);
            MainForm mainForm = new MainForm();
            OpenChildForm(mainForm);
        }

        private Form activeForm;
        private void FormForMain_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
         }

        public void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPanel.Controls.Add(childForm);
            this.panelDesktopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void FormForMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if(closeAllProgram == "true") Application.Exit();
            //if (closeAllProgram != "none")
            //{
            //    AccountManager accountManager = new AccountManager();
            //    accountManager.UpdateUser(AppContext.Instance.CurrentUser, AppContext.Instance.CurrentUser.UserName);
            //}

            if (programState == ProgramState.Running)
            {
                Application.Exit();
            }

            if (programState != ProgramState.DeleteAccount)
            {
                AccountManager accountManager = new AccountManager();
                accountManager.UpdateUser(AppContext.Instance.CurrentUser, AppContext.Instance.CurrentUser.UserName);
            }

            programState = ProgramState.Running;

        }

        private void buttonStudySet_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            OpenChildForm(mainForm);
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            SettingForm setForm = new SettingForm();
            OpenChildForm(setForm);
        }
    }
}
