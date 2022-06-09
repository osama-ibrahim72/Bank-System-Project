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
    public partial class Add_acc : Form
    {
        public Add_acc()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-6O7UHGK;Initial Catalog=Bank;Integrated Security=True");
            SqlCommand command = new SqlCommand();
            command.Connection = con;
            con.Open();
            command.CommandText = "INSERT INTO Account VALUES('" + anum.Text + "','" + ssn.Text + "','" + balance.Text + "','"+comboBox1.SelectedText+"') ";
            command.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Success");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Add("business");
            comboBox1.Items.Add("Personal");
        }

        private void Add_acc_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("business");
            comboBox1.Items.Add("Personal");
        }

        private void update_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-6O7UHGK;Initial Catalog=Bank;Integrated Security=True");
            SqlCommand command = new SqlCommand();
            command.Connection = con;
            con.Open();
            command.CommandText = "UPDATE Account SET Balance = '" + balance.Text + "'  , AType = '" + comboBox1.SelectedText + "'  WHERE ANUM =  '" + anum.Text + "' ";
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
            command.CommandText = "DELETE FROM Account WHERE ANUM = '" + anum.Text + "'";
            command.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Success");
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customer f3 = new BankSystem.Customer();
            f3.ShowDialog();
            this.Close();
        }
    }
}
