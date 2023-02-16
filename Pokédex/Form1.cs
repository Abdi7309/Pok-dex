namespace Pokédex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox30_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox29_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox31_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new Form4();
            form2.Closed += (s, args) => this.Close();
            form2.Show();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new Form7();
            form2.Closed += (s, args) => this.Close();
            form2.Show();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new Form2();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }
    }
}
