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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Admin_Click(object sender, EventArgs e)
        {
            this.Hide();
            log_in_admin f3 = new BankSystem.log_in_admin();
            f3.ShowDialog();
            this.Close();

        }

        private void customer_Click(object sender, EventArgs e)
        {
            this.Hide();
            Log_cus f3 = new BankSystem.Log_cus();
            f3.ShowDialog();
            this.Close();
        }

        private void Employee_Click(object sender, EventArgs e)
        {
            this.Hide();
            Log_emp f3 = new BankSystem.Log_emp();
            f3.ShowDialog();
            this.Close();
        }
    }
}