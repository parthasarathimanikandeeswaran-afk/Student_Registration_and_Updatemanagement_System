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
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {

            Delete r = new Delete();
            r.Close();
            Form1 f1 = new Form1();
            f1.Show();
        }
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=msdb;Integrated Security=True;");

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Idinput.Text))
            {
                MessageBox.Show("Please enter an ID to delete.");
                return;
            }

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM StudentDetails WHERE Id = @Id", con);
                cmd.Parameters.AddWithValue("@Id", Idinput.Text);

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Record deleted successfully!");
                    Idinput.Clear();
                }
                else
                {
                    MessageBox.Show("No record found with that ID.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
