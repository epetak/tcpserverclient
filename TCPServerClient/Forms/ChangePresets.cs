using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCPServerClient.Classes;

namespace TCPServerClient.Forms
{
    public partial class ChangePresets : Form
    {
        private UserData CurrentUser;
        public ChangePresets(UserData user)
        {
            InitializeComponent();
            CurrentUser = user;
        }

        private void setUserData()
        {
            txtBoxName.Text = CurrentUser.Name;
            txtBoxPort.Text = CurrentUser.Port.ToString();
            txtBoxIpAddress.Text = CurrentUser.getIpAddress();
        }

        private void ChangePresets_Load(object sender, EventArgs e)
        {
            setUserData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (txtBoxName.Text.Length > 0 && txtBoxPort.Text.Length > 3 && txtBoxPort.Text.Length < 7)
            {
                CurrentUser.Name = txtBoxName.Text;
                CurrentUser.Port = int.Parse(txtBoxPort.Text);
                this.Close();
            }
            else
            {
                MessageBox.Show("Can't set parameters");
            }
        }
    }
}
