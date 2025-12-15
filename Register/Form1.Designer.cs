using Microsoft.Data.SqlClient;
using System.Data;

namespace Register
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        public Form1()
        {
            InitializeComponent();
            LoadData();
        }

        SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=msdb;Integrated Security=True;");

        public void LoadData()
        {
            try{
                con.Open();
                string query = "Select * from StudentDetails";

                SqlDataAdapter cmd = new SqlDataAdapter(query, con);

                DataTable r = new DataTable();
                cmd.Fill(r);
                detailsgrid.DataSource = r;
                con.Close();

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }











        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label6 = new Label();
            detailsgrid = new DataGridView();
            btn1 = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn4 = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)detailsgrid).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F);
            label6.Location = new Point(184, 31);
            label6.Name = "label6";
            label6.Size = new Size(218, 41);
            label6.TabIndex = 20;
            label6.Text = "Student Details";
            // 
            // detailsgrid
            // 
            detailsgrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            detailsgrid.Location = new Point(30, 132);
            detailsgrid.Name = "detailsgrid";
            detailsgrid.RowHeadersWidth = 51;
            detailsgrid.Size = new Size(495, 296);
            detailsgrid.TabIndex = 19;
            detailsgrid.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btn1
            // 
            btn1.Location = new Point(601, 123);
            btn1.Name = "btn1";
            btn1.Size = new Size(149, 47);
            btn1.TabIndex = 21;
            btn1.Text = "Register";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(601, 306);
            btn3.Name = "btn3";
            btn3.Size = new Size(149, 47);
            btn3.TabIndex = 22;
            btn3.Text = "Update";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += button2_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(601, 214);
            btn2.Name = "btn2";
            btn2.Size = new Size(149, 47);
            btn2.TabIndex = 23;
            btn2.Text = "Read";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(601, 381);
            btn4.Name = "btn4";
            btn4.Size = new Size(149, 47);
            btn4.TabIndex = 24;
            btn4.Text = "Delete";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // button1
            // 
            button1.Location = new Point(601, 31);
            button1.Name = "button1";
            button1.Size = new Size(149, 47);
            button1.TabIndex = 25;
            button1.Text = "Referesh";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(873, 450);
            Controls.Add(button1);
            Controls.Add(btn4);
            Controls.Add(btn2);
            Controls.Add(btn3);
            Controls.Add(btn1);
            Controls.Add(label6);
            Controls.Add(detailsgrid);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)detailsgrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label6;
        private DataGridView detailsgrid;
        private Button btn1;
        private Button btn3;
        private Button btn2;
        private Button btn4;
        private Button button1;
    }
}
