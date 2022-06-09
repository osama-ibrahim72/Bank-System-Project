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
    public partial class Log_emp : Form
    {
        public Log_emp()
        {
            InitializeComponent();
        }

        private void log_Click(object sender, EventArgs e)
        {
            String us = id.Text;
            String ps = pass.Text;
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-6O7UHGK;Initial Catalog=Bank;Integrated Security=True");
            con.Open();
            using (SqlCommand StrQuer = new SqlCommand("SELECT * FROM Employee WHERE EID = '" + id.Text + "' AND password = '" + pass.Text + "'", con))
            {
                StrQuer.Parameters.AddWithValue("@username", us);
                StrQuer.Parameters.AddWithValue("@password", ps);
                SqlDataReader dr = StrQuer.ExecuteReader();
                if (dr.HasRows)
                {
                    MessageBox.Show("loginSuccess");
                    Employee ss = new BankSystem.Employee();
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
