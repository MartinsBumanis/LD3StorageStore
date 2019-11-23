using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock
{
    public partial class Greeting : Form
    {
        public Greeting()
        {
            InitializeComponent();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Greeting_Load(object sender, EventArgs e)
        {

        }

        private void saktDarbu_Click(object sender, EventArgs e)
        {
            Login pro = new Login();
            // pro.MdiParent = this;
            this.Hide();
            pro.Show();
        }

        private void Greeting_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
