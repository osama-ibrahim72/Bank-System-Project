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
    public partial class Add_cus : Form
    {
        public Add_cus()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-6O7UHGK;Initial Catalog=Bank;Integrated Security=True");
            SqlCommand command = new SqlCommand();
            command.Connection = con;
            con.Open();
            command.CommandText = "INSERT INTO Customers VALUES('" + ssn.Text + "','" + name.Text + "','" + phone.Text + "','" + city.Text + "', '" + street.Text + "','" + state.Text + "','" + no.Text + "','" + pass.Text + "') ";
            command.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Success");
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Employee f3 = new BankSystem.Employee();
            f3.ShowDialog();
            this.Close();
        }
    }
    
}
