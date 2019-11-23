using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();

        }

        private void Reports_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'StockDataSet1.Noliktava' table. You can move, or remove it, as needed.
            this.NoliktavaTableAdapter.Fill(this.StockDataSet1.Noliktava);
            // TODO: This line of code loads data into the 'StockDataSet.Produkti' table. You can move, or remove it, as needed.
            this.ProduktiTableAdapter.Fill(this.StockDataSet.Produkti);

            this.reportViewer1.RefreshReport();
        }

        private void produktiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Produkti pro = new Produkti();
            // pro.MdiParent = this;
            this.Hide();
            pro.Show();
        }

        private void noliktavaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Noliktava pro = new Noliktava();
            // pro.MdiParent = this;
            this.Hide();
            pro.Show();
        }

        private void Reports_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reportViewer1.Reset();
            reportViewer1.LocalReport.DataSources.Clear();
            SqlConnection con = new SqlConnection("Data Source = localhost; Initial Catalog = Stock; Integrated Security = True");
            SqlDataAdapter sda = new SqlDataAdapter(@"SELECT * FROM [dbo].[Produkti]", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            ReportDataSource rds = new ReportDataSource("ReportSumProdukti", dt);
            reportViewer1.LocalReport.ReportEmbeddedResource = "Stock.ReportSumProdukti.rdlc";
            reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //reportViewer1.Reset();
            //ReportDataSource rds = new ReportDataSource("ReportSumNoliktava");
            //reportViewer1.LocalReport.DataSources.Clear();
            //reportViewer1.LocalReport.DataSources.Add(rds);
            //reportViewer1.LocalReport.Refresh();

            //string reportPath = "ReportSumNoliktava.rdlc";

            //// Set the active report path of the ReportViewer object
            //reportViewer1.Reset();
            //reportViewer1.LocalReport.ReportPath = reportPath;
            //reportViewer1.LocalReport.ReportEmbeddedResource = "ReportSumNoliktava.rdlc";
            //reportViewer1.LocalReport.Refresh();



            //  reportViewer1.Reset();

            //TODO: Check login username & Password
            reportViewer1.Reset();
            reportViewer1.LocalReport.DataSources.Clear();
            SqlConnection con = new SqlConnection("Data Source = localhost; Initial Catalog = Stock; Integrated Security = True");
            SqlDataAdapter sda = new SqlDataAdapter(@"SELECT * FROM [dbo].[Noliktava]", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            ReportDataSource rds = new ReportDataSource("ReportSumNoliktava", dt);
            reportViewer1.LocalReport.ReportEmbeddedResource = "Stock.ReportSumNoliktava.rdlc";
            reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string currentReport = this.reportViewer1.LocalReport.ReportEmbeddedResource;
          //  string ctrlName = ((Control)reportViewer1.LocalReport.DataSources).Name;
          //  reportViewer1.Reset();
           // reportViewer1.LocalReport.DataSources.Clear();
            SqlConnection con = new SqlConnection("Data Source = localhost; Initial Catalog = Stock; Integrated Security = True");
            // SqlDataAdapter sda = new SqlDataAdapter(@"SELECT * FROM [dbo].[Produkti] WHERE Daudzums<=" +daudzumsUnder.Text+"", con);



            if (currentReport == "Stock.ReportSumNoliktava.rdlc")
            {
                SqlDataAdapter sda = new SqlDataAdapter(@"SELECT * FROM [dbo].[Noliktava] WHERE Daudzums<=" + daudzumsUnder.Text + "", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                ReportDataSource rds = new ReportDataSource("ReportSumNoliktava", dt);
                reportViewer1.LocalReport.ReportEmbeddedResource = "Stock.ReportSumNoliktava.rdlc";
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);
                this.reportViewer1.RefreshReport();
              
            }
            else
            {
                SqlDataAdapter sda = new SqlDataAdapter(@"SELECT * FROM [dbo].[Produkti] WHERE Daudzums<=" + daudzumsUnder.Text + "", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                ReportDataSource rds = new ReportDataSource("ReportSumProdukti", dt);
                reportViewer1.LocalReport.ReportEmbeddedResource = "Stock.ReportSumProdukti.rdlc";
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);
                this.reportViewer1.RefreshReport();
                
            }



        }

        private void daudzumsUnder_TextChanged(object sender, EventArgs e)
        {

        }

        private void galvenāLapaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockMain pro = new StockMain();
            this.Hide();
            pro.Show();
        }
    }
}
