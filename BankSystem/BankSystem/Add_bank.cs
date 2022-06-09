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
    public partial class Add_bank : Form
    {
        public Add_bank()
        {
            InitializeComponent();
        }

        private void Add_bank_Load(object sender, EventArgs e)
        {

        }

        private void insert_bank_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-6O7UHGK;Initial Catalog=Bank;Integrated Security=True");
            SqlCommand command = new SqlCommand();
            command.Connection= con;
            con.Open();
            command.CommandText = "INSERT INTO Bank VALUES('" + code.Text+ "','" + name.Text + "','" + state.Text + "') ";
            command.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Success");
        }

        private void update_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-6O7UHGK;Initial Catalog=Bank;Integrated Security=True");
            SqlCommand command = new SqlCommand();
            command.Connection = con;
            con.Open();
            command.CommandText = "UPDATE Bank SET Name = '" + name.Text + "'  , State = '" + state.Text + "' WHERE code =  '" + code.Text + "' ";
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
            command.CommandText = "DELETE FROM Bank WHERE Code = '" + code.Text + "'";
            command.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Success");
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin f3 = new BankSystem.Admin();
            f3.ShowDialog();
            this.Close();
        }
    }
}
