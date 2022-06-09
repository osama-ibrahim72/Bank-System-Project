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
    public partial class Add_loen : Form
    {
        public Add_loen()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customer f3 = new BankSystem.Customer();
            f3.ShowDialog();
            this.Close();
        }

        private void add_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-6O7UHGK;Initial Catalog=Bank;Integrated Security=True");
            SqlCommand command = new SqlCommand();
            command.Connection = con;
            con.Open();
            command.CommandText = "INSERT INTO Loan VALUES('" + lnum.Text + "','" + ssn.Text + "','" + loen_offer.SelectedText + "', null , '" + anum.Text + "','"+amount.Text+"',null) ";
            command.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Success");
        }

        private void Add_loen_Load(object sender, EventArgs e)
        {
            loen_offer.Items.Add("personal");
            loen_offer.Items.Add("car");
            loen_offer.Items.Add("small business");
            loen_offer.Items.Add("guarantorl");
            loen_offer.Items.Add("education");
            loen_offer.Items.Add("marriage");

        }
    }
}
