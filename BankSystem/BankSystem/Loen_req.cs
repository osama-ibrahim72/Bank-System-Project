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
    public partial class Loen_req : Form
    {
        public Loen_req()
        {
            InitializeComponent();
        }

        private void Loen_req_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-6O7UHGK;Initial Catalog=Bank;Integrated Security=True");
            SqlCommand command = new SqlCommand();
            command.Connection = con;
            con.Open();
            command.CommandText = "SELECT * FROM Loan WHERE request is null ";
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            command.ExecuteNonQuery();
            con.Close();
            req.DataSource = ds.Tables[0];
            req.DisplayMember= "LNUM" + "Type";
            req.ValueMember = "LNUM";
            MessageBox.Show("Success");
        }

        private void accept_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-6O7UHGK;Initial Catalog=Bank;Integrated Security=True");
            SqlCommand command = new SqlCommand();
            command.Connection = con;
            con.Open();
            command.CommandText = "UPDATE Loan SET request = 1  WHERE LNUM = '"+req.SelectedValue+"' ";
            command.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Success");
        }

        private void reject_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-6O7UHGK;Initial Catalog=Bank;Integrated Security=True");
            SqlCommand command = new SqlCommand();
            command.Connection = con;
            con.Open();
            command.CommandText = "DELETE FROM Loan  WHERE LNUM = '" + req.SelectedValue + "' ";
            command.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Success");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Employee f3 = new BankSystem.Employee();
            f3.ShowDialog();
            this.Close();
        }
    }
}
