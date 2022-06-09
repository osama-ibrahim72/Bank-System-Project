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
    public partial class add_employe : Form
    {
        public add_employe()
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

        private void add_employe_Load(object sender, EventArgs e)
        {
            
        }

        private void insert_emp_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-6O7UHGK;Initial Catalog=Bank;Integrated Security=True");
            SqlCommand command = new SqlCommand();
            command.Connection = con;
            con.Open();
            command.CommandText = "INSERT INTO Employee VALUES('" + eid.Text + "','"+branch.Text+"','" + name.Text + "','" + pass.Text + "') ";
            command.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Success");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-6O7UHGK;Initial Catalog=Bank;Integrated Security=True");
            SqlCommand command = new SqlCommand();
            command.Connection = con;
            con.Open();
            command.CommandText = "UPDATE Employee SET Name = '" + name.Text + "'  , BNUM = '" + branch.Text + "' , password = '"+pass.Text+"' WHERE EID =  '" + eid.Text + "' ";
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
            command.CommandText = "DELETE FROM Employee WHERE EID = '" + eid.Text + "'";
            command.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Success");
        }
    }
}
