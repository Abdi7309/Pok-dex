using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokédex
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            var pokemon1 = new Form1();
            pokemon1.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var pokemon1 = new Form8();
            pokemon1.Show();
        }


    }
}
