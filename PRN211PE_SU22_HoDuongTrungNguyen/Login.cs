using Repositories.Models;
using Repositories.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRN211PE_SU22_HoDuongTrungNguyen
{
    public partial class Login : Form
    {
        private UserRepository _user;
        public Login()
        {
            InitializeComponent();
            _user = new UserRepository();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string Username = txtUsername.Text;
            string Password = txtPassword.Text;
            var listAccount = _user.GetAll();
            var account = (User) listAccount.FirstOrDefault(account => account.UserId == Username && account.Password == Password);
            if (account == null )
            {
                MessageBox.Show("Thông báo", "Wrong username or password!", MessageBoxButtons.OK);
            } else
            {
                this.Hide();
                Management managementForm = new Management(account);
                managementForm.ShowDialog();
            }
        }

    }
}
