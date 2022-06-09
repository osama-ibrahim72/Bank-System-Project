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
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void add_acc_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_acc f3 = new BankSystem.Add_acc();
            f3.ShowDialog();
            this.Close();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home f3 = new BankSystem.Home();
            f3.ShowDialog();
            this.Close();
        }

        private void add_loen_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_loen f3 = new BankSystem.Add_loen();
            f3.ShowDialog();
            this.Close();
        }
    }
}
