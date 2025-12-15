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
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=msdb;Integrated Security=True;");

        private void Searchbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(Idinput.Text))
                {
                    MessageBox.Show("Please enter a valid ID to search.");
                    return;
                }

                con.Open();
                string query = "SELECT * FROM StudentDetails WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Id", Idinput.Text);

                SqlDataReader dr = cmd.ExecuteReader();

                if (!dr.HasRows)
                {
                    MessageBox.Show("❌ No record found for this ID!");
                    ClearFields();
                    dr.Close();
                    con.Close();
                    return;
                }

                if (dr.Read())
                {
                    name.Text = dr["Name"].ToString();
                    specificationinput.Text = dr["Specification"].ToString();

                    // ✅ Set degree radio button (works even if inside GroupBox)
                    string degree = dr["Degree"].ToString();
                    SetDegreeRadioButton(degree);

                    // ✅ Set checked courses
                    string courses = dr["Course"].ToString();
                    SetCheckedCourses(courses);

                    MessageBox.Show("✅ Record found successfully!");
                }

                dr.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                con.Close();
            }
        }








        // 🔹 Mark the degree radio button as checked
        private void SetDegreeRadioButton(string degree)
        {
            foreach (RadioButton rb in GetAll(this, typeof(RadioButton)))
            {
                rb.Checked = (rb.Text == degree);
            }
        }

        // 🔹 Mark selected courses in CheckedListBox
        private void SetCheckedCourses(string courses)
        {
            for (int i = 0; i < coursecheck.Items.Count; i++)
            {
                coursecheck.SetItemChecked(i, false);
            }

            string[] selectedCourses = courses.Split(',')
                                              .Select(c => c.Trim())
                                              .ToArray();

            for (int i = 0; i < coursecheck.Items.Count; i++)
            {
                if (selectedCourses.Contains(coursecheck.Items[i].ToString()))
                {
                    coursecheck.SetItemChecked(i, true);
                }
            }
        }

        // 🔹 Recursive helper to find all controls (inside GroupBoxes/Panels too)
        private IEnumerable<Control> GetAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();
            return controls.SelectMany(ctrl => GetAll(ctrl, type))
                           .Concat(controls)
                           .Where(c => c.GetType() == type);
        }

        // 🔹 Clear fields (optional)
        private void ClearFields()
        {
            Idinput.Clear();
            name.Clear();
            specificationinput.Clear();

            foreach (RadioButton rb in GetAll(this, typeof(RadioButton)))
                rb.Checked = false;

            for (int i = 0; i < coursecheck.Items.Count; i++)
                coursecheck.SetItemChecked(i, false);
        }

        private void submitbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(Idinput.Text))
                {
                    MessageBox.Show("⚠️ Please enter a valid ID before updating.");
                    return;
                }

                // ✅ Get selected Degree
                string degree = GetAll(this, typeof(RadioButton))
                                .OfType<RadioButton>()
                                .FirstOrDefault(r => r.Checked)?.Text ?? "";

                // ✅ Get selected Courses from CheckedListBox
                string courses = string.Join(", ",
                    coursecheck.CheckedItems
                        .OfType<string>()
                        .ToArray());

                // ✅ Validate input
                if (string.IsNullOrWhiteSpace(name.Text) ||
                    string.IsNullOrWhiteSpace(specificationinput.Text) ||
                    string.IsNullOrWhiteSpace(degree) ||
                    string.IsNullOrWhiteSpace(courses))
                {
                    MessageBox.Show("⚠️ Please fill all fields before updating.");
                    return;
                }

                con.Open();

                string query = @"UPDATE StudentDetails 
                         SET Name=@Name, 
                             Degree=@Degree, 
                             Specification=@Specification, 
                             Course=@Course 
                         WHERE Id=@Id";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Name", name.Text.Trim());
                cmd.Parameters.AddWithValue("@Degree", degree.Trim());
                cmd.Parameters.AddWithValue("@Specification", specificationinput.Text.Trim());
                cmd.Parameters.AddWithValue("@Course", courses.Trim());
                cmd.Parameters.AddWithValue("@Id", Idinput.Text.Trim());

                int rows = cmd.ExecuteNonQuery();
                con.Close();

                if (rows > 0)
                {
                    MessageBox.Show("✅ Student details updated successfully!");
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("❌ Update failed! No record found for the given ID.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                con.Close();
            }
        }
    }
}
