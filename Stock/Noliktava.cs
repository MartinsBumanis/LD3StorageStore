using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock
{
    public partial class Noliktava : Form
    {
       
        DataSet ds = new DataSet();
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
;

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

        private void veikalaPrecesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Produkti pro = new Produkti();
            this.Hide();
            pro.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource = null;
            ds.Reset();
            dataGridView1.Update();
            dataGridView1.RefreshEdit();
            SqlConnection con = new SqlConnection("Data Source = localhost; Initial Catalog = Stock; Integrated Security = True");
            con.Open();

            string dateStringDb = dateTimePicker1.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
            SqlCommand cmd = new SqlCommand(@"INSERT INTO[dbo].[Noliktava]
        ([ProduktaID]
          ,[ProduktaVards]
          ,[Daudzums]
          ,[DerigumaTermins]
          ,[Veids])
    VALUES
          ('" + textBox1.Text + "','"
            + textBox2.Text + "','"
            + textBox6.Text + "','"
            + dateStringDb + "','"
            + textBox3.Text+ "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            dataGridView1.DataSource = null;
            string connectionString = ("Data Source = localhost; Initial Catalog = Stock; Integrated Security = True");
            string sql = @"SELECT [ProduktaID]
      ,[ProduktaVards]
      ,[Daudzums]
      ,[DerigumaTermins]
      ,[Veids]
  FROM [dbo].[Noliktava]";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
            connection.Open();
            dataadapter.Fill(ds, "Noliktava");
            connection.Close();

            dataGridView1.DataSource = ds.Tables[0];
            int rowCountData = dataGridView1.RowCount;
            // rowCountData--;
            textBox1.Text = rowCountData.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            ds.Reset();
            dataGridView1.Update();
            dataGridView1.RefreshEdit();
            string connectionString = ("Data Source = localhost; Initial Catalog = Stock; Integrated Security = True");
            string sql = @"SELECT [ProduktaID]
      ,[ProduktaVards]
      ,[Daudzums]
      ,[DerigumaTermins]
      ,[Veids]
  FROM [dbo].[Noliktava]";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
            connection.Open();
            dataadapter.Fill(ds, "Nolktava");
            connection.Close();

            dataGridView1.DataSource = ds.Tables[0];
            int rowCountData = dataGridView1.RowCount;
            // rowCountData--;
            textBox1.Text = rowCountData.ToString();
        }

        private void galvenāLapaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockMain pro = new StockMain();
            this.Hide();
            pro.Show();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int rowCountData = dataGridView1.RowCount;
           // rowCountData--;
            textBox1.Text = rowCountData.ToString();
        }

      
    }
}
