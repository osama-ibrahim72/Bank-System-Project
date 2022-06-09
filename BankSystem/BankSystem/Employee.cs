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
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home f3 = new BankSystem.Home();
            f3.ShowDialog();
            this.Close();
        }

        private void add_coust_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_cus f3 = new BankSystem.Add_cus();
            f3.ShowDialog();
            this.Close();
        }

        private void leon_req_Click(object sender, EventArgs e)
        {
            this.Hide();
            Loen_req f3 = new BankSystem.Loen_req();
            f3.ShowDialog();
            this.Close();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-6O7UHGK;Initial Catalog=Bank;Integrated Security=True");
            SqlCommand command = new SqlCommand();
            command.Connection = con;
            con.Open();
            command.CommandText = "SELECT * FROM Customers ";
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable ds = new DataTable();
            adapter.Fill(ds);
            command.ExecuteNonQuery();
            con.Close();
            for (int i = 0; i < ds.Rows.Count; i++)
            {
                DataRow dr = ds.Rows[i];
                ListViewItem listitem = new ListViewItem(dr["name"].ToString());
                cus.Items.Add(listitem);
            }
            con.Open();
            command.CommandText = "SELECT * FROM Loan ";
            adapter = new SqlDataAdapter(command);
            ds = new DataTable();
            adapter.Fill(ds);
            command.ExecuteNonQuery();
            con.Close();
            for (int i = 0; i < ds.Rows.Count; i++)
            {
                DataRow dr = ds.Rows[i];
                ListViewItem listitem = new ListViewItem(dr["LNUM"].ToString());
                loens.Items.Add(listitem);
            }
        }
    }
}
