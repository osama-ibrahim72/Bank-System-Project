using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BankSystem
{
    public partial class Log_cus : Form
    {
        public Log_cus()
        {
            InitializeComponent();
        }

        private void log_Click(object sender, EventArgs e)
        {
            String us = ssn.Text;
            String ps = pass.Text;
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-6O7UHGK;Initial Catalog=Bank;Integrated Security=True");
            con.Open();
            using (SqlCommand StrQuer = new SqlCommand("SELECT * FROM Customers WHERE SSN = '" + ssn.Text + "' AND password = '" + pass.Text + "'", con))
            {
                StrQuer.Parameters.AddWithValue("@username", us);
                StrQuer.Parameters.AddWithValue("@password", ps);
                SqlDataReader dr = StrQuer.ExecuteReader();
                if (dr.HasRows)
                {
                    MessageBox.Show("loginSuccess");
                    Customer ss = new BankSystem.Customer();
                    ss.Show();
                }
                else
                {
                    MessageBox.Show("loginfiled");
                }

            }
        }
    }
}
