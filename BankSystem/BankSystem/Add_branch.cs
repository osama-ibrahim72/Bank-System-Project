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
    public partial class Add_branch : Form
    {
        public Add_branch()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin f3 = new BankSystem.Admin();
            f3.ShowDialog();
            this.Close();
        }

        private void update_Click(object sender, EventArgs e)
        {

        }

        private void inserrt_branch_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-6O7UHGK;Initial Catalog=Bank;Integrated Security=True");
            SqlCommand command = new SqlCommand();
            command.Connection = con;
            con.Open();
            command.CommandText = "INSERT INTO Branche VALUES('" + code.Text+ "' ,'" + bank.Text + "', '" + city.Text+"','"+street.Text+"') ";
            command.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Success");
        }

        private void delete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-6O7UHGK;Initial Catalog=Bank;Integrated Security=True");
            SqlCommand command = new SqlCommand();
            command.Connection = con;
            con.Open();
            command.CommandText = "DELETE FROM  Branche WHERE BNUM = '" + code.Text + "'  ";
            command.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Success");
        }
    }
}
