using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Register
{
    public partial class Read : Form
    {
        public Read()
        {
            InitializeComponent();

        }

        private void Read_Load(object sender, EventArgs e)
        {

        }
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=msdb;Integrated Security=True;");


        public void SearchById()
        {
            try
            {
                con.Open();
                string query = "SELECT * FROM StudentDetails WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Id", Idinput.Text);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    // Display the column values in labels or textboxes
                    lname.Text = reader["Name"].ToString();
                    lDegeree.Text = reader["Degree"].ToString();
                    lSpecific.Text = reader["Specification"].ToString();
                    courselabel.Text = reader["Course"].ToString();
                }
                else
                {
                    MessageBox.Show("No record found with that ID.");
                }

                reader.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void Searchbtn_Click(object sender, EventArgs e)
        {
            SearchById();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {

            Read r = new Read();

            r.Hide();
            Form1 f1 = new Form1();
            f1.Show();
           
        }
    }
}
