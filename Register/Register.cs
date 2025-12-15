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
using System.Xml.Linq;

namespace Register
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {


            Register r = new Register();
            r.Close();
            Form1 f1 = new Form1();
            f1.Show();
        }
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=msdb;Integrated Security=True;");
        private void submitbtn_Click(object sender, EventArgs e)
        {
            try
            {
                
                string degree = "";
                if (r1.Checked) degree = "B.Sc";
                else if (r2.Checked) degree = "BCA";
                else if (r5.Checked) degree = "B.E";
                else if (r7.Checked) degree = "B.Tech";
                else if (r3.Checked) degree = "M.Sc";
                else if (r4.Checked) degree = "MCA";
                else if (r6.Checked) degree = "M.E";
                else if (r8.Checked) degree = "M.Tech";

                string courses = string.Join(", ",
    coursecheck.CheckedItems
        .OfType<string>()  
        .ToArray());

               
                con.Open();
                string query = "INSERT INTO StudentDetails (Name, Degree, Specification, Course) VALUES (@Name, @Degree, @Specification, @Course)";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@Name", name.Text);
                cmd.Parameters.AddWithValue("@Degree", degree);
                cmd.Parameters.AddWithValue("@Specification", specificationinput.Text);
                cmd.Parameters.AddWithValue("@Course", courses);

                int rows = cmd.ExecuteNonQuery();
                con.Close();

                if (rows > 0)
                {
                    MessageBox.Show("✅ Student Registered Successfully!");
                    ClearFields();
                    coursecheck.ClearSelected();
                }
                else
                {
                    MessageBox.Show("❌ Registration Failed!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("⚠️ " + ex.Message);
                con.Close();
            }
        }
      
     private void ClearFields()
        {
            name.Clear();
            specificationinput.Clear();
            foreach (var rb in this.Controls.OfType<RadioButton>()) rb.Checked = false;
            foreach (var cb in this.Controls.OfType<CheckBox>()) cb.Checked = false;
        }



    }
}
