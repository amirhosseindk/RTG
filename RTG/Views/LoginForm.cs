using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RTG.Views
{
    public partial class LoginForm : RTG.Infrastructure.Base.Forms.BaseForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            bool i = false;
            try
            {
                if ((UserTxt.Text == string.Empty) || (PassTxt.Text == string.Empty))
                {
                    MessageBox.Show("Please Enter Username And Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    UserTxt.Focus();
                }

                i = Persistence.Data.CRUD.Login(UserTxt.Text, PassTxt.Text);

                if (i)
                {
                    MessageBox.Show("Login Succesfull", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Persistence.Data.DataContainer.user = Persistence.Data.CRUD.GetUser(UserTxt.Text);
                    if (Persistence.Data.CRUD.CheckVS(Persistence.Data.DataContainer.user.Id) == true)
                    {
                        Persistence.Data.DataContainer.now = Persistence.Data.GetInfo.GetServerDateNow();
                        this.Hide();

                        MainForm mainForm = new MainForm();

                        mainForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("This Username Is Registerd On Other System", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Username Or Password Is Wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                UserTxt.Text = "";
                PassTxt.Text = "";

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

            finally
            {
                i = false;
            }
        }

        private void UserTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                PassTxt.Focus();
            }
        }

        private void PassTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                LoginBtn_Click(sender,e);
            }
        }
    }
}
