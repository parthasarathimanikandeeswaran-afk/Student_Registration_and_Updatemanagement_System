namespace Register
{
    partial class Delete
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
            Deletebtn = new Button();
            Idinput = new TextBox();
            label6 = new Label();
            backbtn = new Button();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F);
            label5.Location = new Point(48, 9);
            label5.Name = "label5";
            label5.Size = new Size(269, 41);
            label5.TabIndex = 64;
            label5.Text = "Delete User Details";
            // 
            // Deletebtn
            // 
            Deletebtn.Location = new Point(112, 133);
            Deletebtn.Name = "Deletebtn";
            Deletebtn.Size = new Size(118, 55);
            Deletebtn.TabIndex = 76;
            Deletebtn.Text = "Delete";
            Deletebtn.UseVisualStyleBackColor = true;
            Deletebtn.Click += Deletebtn_Click;
            // 
            // Idinput
            // 
            Idinput.Location = new Point(103, 77);
            Idinput.Name = "Idinput";
            Idinput.Size = new Size(170, 27);
            Idinput.TabIndex = 75;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(50, 80);
            label6.Name = "label6";
            label6.Size = new Size(22, 20);
            label6.TabIndex = 74;
            label6.Text = "Id";
            // 
            // backbtn
            // 
            backbtn.Location = new Point(583, 350);
            backbtn.Name = "backbtn";
            backbtn.Size = new Size(143, 60);
            backbtn.TabIndex = 77;
            backbtn.Text = "Back";
            backbtn.UseVisualStyleBackColor = true;
            backbtn.Click += backbtn_Click;
            // 
            // Delete
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(backbtn);
            Controls.Add(Deletebtn);
            Controls.Add(Idinput);
            Controls.Add(label6);
            Controls.Add(label5);
            Name = "Delete";
            Text = "Delete";
            Load += Delete_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Button Deletebtn;
        private TextBox Idinput;
        private Label label6;
        private Button backbtn;
    }
}