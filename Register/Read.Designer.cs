namespace Register
{
    partial class Read
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lname = new Label();
            lDegeree = new Label();
            lSpecific = new Label();
            label6 = new Label();
            Idinput = new TextBox();
            Searchbtn = new Button();
            backbtn = new Button();
            courselabel = new Label();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F);
            label5.Location = new Point(63, 26);
            label5.Name = "label5";
            label5.Size = new Size(218, 41);
            label5.TabIndex = 50;
            label5.Text = "Student Details";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 331);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 49;
            label4.Text = "Course";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 244);
            label3.Name = "label3";
            label3.Size = new Size(95, 20);
            label3.TabIndex = 48;
            label3.Text = "Specification";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 168);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 47;
            label2.Text = "Degree";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 111);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 46;
            label1.Text = "Name";
            // 
            // lname
            // 
            lname.AutoSize = true;
            lname.Location = new Point(109, 111);
            lname.Name = "lname";
            lname.Size = new Size(0, 20);
            lname.TabIndex = 51;
            // 
            // lDegeree
            // 
            lDegeree.AutoSize = true;
            lDegeree.Location = new Point(109, 168);
            lDegeree.Name = "lDegeree";
            lDegeree.Size = new Size(0, 20);
            lDegeree.TabIndex = 52;
            // 
            // lSpecific
            // 
            lSpecific.AutoSize = true;
            lSpecific.Location = new Point(128, 244);
            lSpecific.Name = "lSpecific";
            lSpecific.Size = new Size(0, 20);
            lSpecific.TabIndex = 54;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(475, 43);
            label6.Name = "label6";
            label6.Size = new Size(22, 20);
            label6.TabIndex = 56;
            label6.Text = "Id";
            // 
            // Idinput
            // 
            Idinput.Location = new Point(528, 40);
            Idinput.Name = "Idinput";
            Idinput.Size = new Size(170, 27);
            Idinput.TabIndex = 57;
            // 
            // Searchbtn
            // 
            Searchbtn.Location = new Point(528, 82);
            Searchbtn.Name = "Searchbtn";
            Searchbtn.Size = new Size(118, 49);
            Searchbtn.TabIndex = 58;
            Searchbtn.Text = "Search";
            Searchbtn.UseVisualStyleBackColor = true;
            Searchbtn.Click += Searchbtn_Click;
            // 
            // backbtn
            // 
            backbtn.Location = new Point(598, 354);
            backbtn.Name = "backbtn";
            backbtn.Size = new Size(143, 60);
            backbtn.TabIndex = 59;
            backbtn.Text = "Back";
            backbtn.UseVisualStyleBackColor = true;
            backbtn.Click += backbtn_Click;
            // 
            // courselabel
            // 
            courselabel.AutoSize = true;
            courselabel.Location = new Point(128, 331);
            courselabel.Name = "courselabel";
            courselabel.Size = new Size(0, 20);
            courselabel.TabIndex = 60;
            // 
            // Read
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(courselabel);
            Controls.Add(backbtn);
            Controls.Add(Searchbtn);
            Controls.Add(Idinput);
            Controls.Add(label6);
            Controls.Add(lSpecific);
            Controls.Add(lDegeree);
            Controls.Add(lname);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Read";
            Text = "Read";
            Load += Read_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lname;
        private Label lDegeree;
        private Label lspecific;
        private Label lSpecific;
        private Label label6;
        private TextBox Idinput;
        private Button Searchbtn;
        private Button backbtn;
        private Label courselabel;
    }
}