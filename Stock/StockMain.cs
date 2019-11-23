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
    public partial class StockMain : Form
    {
       

        public StockMain()
        {
            InitializeComponent();
        }

  

        private void StockMain_Load(object sender, EventArgs e)
        {

        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Produkti pro = new Produkti();
            //pro.MdiParent = this;
            
            pro.Close();
            pro.Show();
        }

        private void StockMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Produkti pro = new Produkti();
            // pro.MdiParent = this;
            this.Hide();
            pro.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Noliktava pro = new Noliktava();
            // pro.MdiParent = this;
            this.Hide();
            pro.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Reports pro = new Reports();
            // pro.MdiParent = this;
            this.Hide();
            pro.Show();
        }
    }
}
