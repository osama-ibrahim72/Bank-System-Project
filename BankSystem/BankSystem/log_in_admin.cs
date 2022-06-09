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
    public partial class log_in_admin : Form
    {
        public log_in_admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            String us =user.Text ;
            String ps = pass.Text ;
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-6O7UHGK;Initial Catalog=Bank;Integrated Security=True");
            con.Open();
            using (SqlCommand StrQuer = new SqlCommand("SELECT * FROM admins WHERE username = '" + user.Text + "' AND password = '" + pass.Text + "'", con))
            {
                StrQuer.Parameters.AddWithValue("@username", us);
                StrQuer.Parameters.AddWithValue("@password", ps);
                SqlDataReader dr = StrQuer.ExecuteReader();
                if (dr.HasRows)
                {
                    MessageBox.Show("loginSuccess");
                    Admin ss = new BankSystem.Admin();
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
