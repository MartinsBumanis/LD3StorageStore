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
    public partial class Noliktava : Form
    {
        public Noliktava()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Noliktava_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stockDataSet1.Noliktava' table. You can move, or remove it, as needed.
            this.noliktavaTableAdapter.Fill(this.stockDataSet1.Noliktava);

        }

        private void atskaitesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports pro = new Reports();
            // pro.MdiParent = this;
            this.Hide();
            pro.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Noliktava_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
