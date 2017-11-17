using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OVRMS.BLL;
using System.Windows.Forms;

namespace OVRMS.Forms
{
    public partial class LoginForm : Form
    {
        LoginBLL ctr = new LoginBLL();
        RecordBLL rec = new RecordBLL();
        OVRMSDCDataContext db = new OVRMSDCDataContext();
        public LoginForm()
        {
            InitializeComponent();
        }
        private void loginButton_Click(object sender, EventArgs e)
        {
            string uid = userIdTextBox.Text.Trim();
            string password = passwordTextBox.Text;

            if (!ctr.idValidator(uid))
            {
                MessageBox.Show("User id should be 1-6 numbers.", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                userIdTextBox.Clear();
                userIdTextBox.Focus();
            }
            else if (!ctr.passwordValidator(password))
            {
                MessageBox.Show("Password should be 6-22 characters.", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                passwordTextBox.Clear();
                passwordTextBox.Focus();
            }
            else if (!rec.checkUser(int.Parse(uid), password))
            {
                MessageBox.Show("User id or password is incorrect, please try again.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                passwordTextBox.Clear();
                passwordTextBox.Focus();
            }
            else
            {
                Employee emp = rec.getEmployee(int.Parse(uid));
                User.Instance.UserID = emp.IdEmp;
                User.Instance.IdUserRole = emp.IdRole;
                User.Instance.UserFullName = emp.FirstName + " " + emp.LastName;

                MDIForm mf = new MDIForm();
                this.Hide();
                mf.ShowDialog();
                this.Close();

            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
