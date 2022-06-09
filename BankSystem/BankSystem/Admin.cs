using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void add_bank_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_bank f3 = new BankSystem.Add_bank();
            f3.ShowDialog();
            this.Close();
        }

        private void add_branch_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_branch f3 = new BankSystem.Add_branch();
            f3.ShowDialog();
            this.Close();
        }

        private void add_emp_Click(object sender, EventArgs e)
        {
            this.Hide();
            add_employe f3 = new BankSystem.add_employe();
            f3.ShowDialog();
            this.Close();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home f3 = new BankSystem.Home();
            f3.ShowDialog();
            this.Close();
        }
    }
}
