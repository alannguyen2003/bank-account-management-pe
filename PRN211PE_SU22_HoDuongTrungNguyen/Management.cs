using Microsoft.EntityFrameworkCore.Query.Internal;
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
    public partial class Management : Form
    {
        private BankAccountRepository _bankAccountRepository;
        private AccountTypeRepository _accountTypeRepository;
        public Management(User user)
        {
            InitializeComponent();
            _bankAccountRepository = new BankAccountRepository();
            _accountTypeRepository = new AccountTypeRepository();
            if (user.UserRole == 1)
            {
                lblMessage.Text = "You are allowed to manage these functions!";
                AdministratorRole();
                dgvBankAccount.DataSource = new BindingSource() { DataSource = _bankAccountRepository.GetAll() };
                cbType.DataSource = new BindingSource() { DataSource = _accountTypeRepository.GetAll() };
                cbType.DisplayMember = "TypeName";
                cbType.ValueMember = "TypeId";
            }
            else
            {
                OtherRole();
                lblMessage.Text = "You are not allowed to manage these functions!";
            }
        }

        private void AdministratorRole()
        {
            dgvBankAccount.IsAccessible = true;
            btnCreate.Enabled = true;
        }

        private void OtherRole()
        {
            dgvBankAccount.IsAccessible = false;
            btnCreate.Enabled = false;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            BankAccount bankAccount = new BankAccount();
            bankAccount.AccountId = txtAccountId.Text;
            bankAccount.AccountName = txtAccountName.Text;
            bankAccount.OpenDate = dtpDate.Value;
            bankAccount.BranchName = txtBranch.Text;
            var selectedItem = (AccountType) cbType.SelectedItem;
            bankAccount.TypeId = selectedItem.TypeId;
            if (!validateAccountId(bankAccount.AccountId))
            {
                _bankAccountRepository.Add(bankAccount);
                dgvBankAccount.DataSource = new BindingSource() { DataSource = _bankAccountRepository.GetAll() };
                MessageBox.Show("Add successful", "Thong bao", MessageBoxButtons.OK);
            } else
            {
                MessageBox.Show("Duplicate Account Id\n Please type again", "Thong bao", MessageBoxButtons.OK);
            }
        }

        private bool validateAccountId(string accountId)
        {
            var listAccount = _bankAccountRepository.GetAll();
            var account = (BankAccount) listAccount.FirstOrDefault(x => x.AccountId == accountId);
            if (account == null) return false;
            return true;
        }
    }
}
