namespace Register
{
    public partial class Form1 : Form
    {


        public void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            Update update = new Update();
            this.Close();
            update.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            Register register = new Register();
            this.Close();
            register.Show();

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            Read read = new Read();

            this.Close();
            read.Show();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            Delete Delete = new Delete();

            this.Close();
            Delete.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
