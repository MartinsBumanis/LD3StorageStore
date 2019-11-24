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
    public partial class Produkti : Form
    {
        BindingSource bs = new BindingSource();
        DataSet ds = new DataSet();

        public Produkti()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Products_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stockDataSet.Produkti' table. You can move, or remove it, as needed.
            this.produktiTableAdapter.Fill(this.stockDataSet.Produkti);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Products_FormClosing(object sender, FormClosingEventArgs e)
        {

            Application.Exit();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            ds.Reset();
            dataGridView1.Update();
            dataGridView1.RefreshEdit();

            SqlConnection con = new SqlConnection("Data Source = localhost; Initial Catalog = Stock; Integrated Security = True");
            con.Open();

            //var dateString = dateTimePicker1.Value.ToShortDateString();
            var dateStringDb = dateTimePicker1.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
            SqlCommand cmd = new SqlCommand(@"INSERT INTO[dbo].[Produkti]
        ([ProduktaID]
          ,[ProduktaVards]
          ,[Veids]
          ,[Cena]
          ,[Daudzums]
          ,[Piegadatajs]
          ,[DerigumaTermins])
    VALUES
          ('" + textBox1.Text + "','"
            + textBox2.Text + "','"
            + textBox5.Text + "','"
            + textBox4.Text + "','"
            + textBox6.Text + "','"
            + textBox6.Text + "','"
            + dateStringDb + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            dataGridView1.DataSource = null;
            string connectionString = ("Data Source = localhost; Initial Catalog = Stock; Integrated Security = True");
            string sql = @"SELECT [ProduktaID]
      ,[ProduktaVards]
      ,[Veids]
      ,[Cena]
      ,[Daudzums]
      ,[Piegadatajs]
      ,[DerigumaTermins]
  FROM[dbo].[Produkti]";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
            connection.Open();
            dataadapter.Fill(ds, "Produkti");
            connection.Close();

            dataGridView1.DataSource = ds.Tables[0];
            int rowCountData = dataGridView1.RowCount;
            // rowCountData--;
            textBox1.Text = rowCountData.ToString();


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

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
      ,[Veids]
      ,[Cena]
      ,[Daudzums]
      ,[Piegadatajs]
      ,[DerigumaTermins]
  FROM[dbo].[Produkti]";
                SqlConnection connection = new SqlConnection(connectionString);
                SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
                connection.Open();
                dataadapter.Fill(ds, "Produkti");
                connection.Close();

                dataGridView1.DataSource = ds.Tables[0];
            int rowCountData = dataGridView1.RowCount;
            // rowCountData--;
            textBox1.Text = rowCountData.ToString();


        }

        private void atskaiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports pro = new Reports();
            // pro.MdiParent = this;
            this.Hide();
            pro.Show();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void noToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Noliktava pro = new Noliktava();
            this.Hide();
            pro.Show();
        }

        private void galvenāLapaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockMain pro = new StockMain();
            this.Hide();
            pro.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
           int rowCountData =  dataGridView1.RowCount;
            rowCountData--;
            textBox1.Text = rowCountData.ToString();
          
         
        }
    }
}
