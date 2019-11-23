namespace Stock
{
    partial class Reports
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reports));
            this.produktiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.StockDataSet = new Stock.StockDataSet();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ProduktiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ProduktiTableAdapter = new Stock.StockDataSetTableAdapters.ProduktiTableAdapter();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.produktiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noliktavaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sumVeikals = new System.Windows.Forms.Button();
            this.reportButtonStorage = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.StockDataSet1 = new Stock.StockDataSet1();
            this.NoliktavaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NoliktavaTableAdapter = new Stock.StockDataSet1TableAdapters.NoliktavaTableAdapter();
            this.stockDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.noliktavaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.daudzumsUnder = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.produktiBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StockDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProduktiBindingSource)).BeginInit();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StockDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NoliktavaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noliktavaBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // produktiBindingSource1
            // 
            this.produktiBindingSource1.DataMember = "Produkti";
            this.produktiBindingSource1.DataSource = this.StockDataSet;
            // 
            // StockDataSet
            // 
            this.StockDataSet.DataSetName = "StockDataSet";
            this.StockDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(825, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "ReportSumProdukti";
            reportDataSource1.Value = this.produktiBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Stock.ReportSumProdukti.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 48);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(825, 423);
            this.reportViewer1.TabIndex = 1;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // ProduktiBindingSource
            // 
            this.ProduktiBindingSource.DataMember = "Produkti";
            this.ProduktiBindingSource.DataSource = this.StockDataSet;
            // 
            // ProduktiTableAdapter
            // 
            this.ProduktiTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produktiToolStripMenuItem,
            this.noliktavaToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(825, 24);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // produktiToolStripMenuItem
            // 
            this.produktiToolStripMenuItem.Name = "produktiToolStripMenuItem";
            this.produktiToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.produktiToolStripMenuItem.Text = "Produkti";
            this.produktiToolStripMenuItem.Click += new System.EventHandler(this.produktiToolStripMenuItem_Click);
            // 
            // noliktavaToolStripMenuItem
            // 
            this.noliktavaToolStripMenuItem.Name = "noliktavaToolStripMenuItem";
            this.noliktavaToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.noliktavaToolStripMenuItem.Text = "Noliktava";
            this.noliktavaToolStripMenuItem.Click += new System.EventHandler(this.noliktavaToolStripMenuItem_Click);
            // 
            // sumVeikals
            // 
            this.sumVeikals.Location = new System.Drawing.Point(184, 9);
            this.sumVeikals.Name = "sumVeikals";
            this.sumVeikals.Size = new System.Drawing.Size(119, 33);
            this.sumVeikals.TabIndex = 3;
            this.sumVeikals.Text = "Preču skaits veikalā";
            this.sumVeikals.UseVisualStyleBackColor = true;
            this.sumVeikals.Click += new System.EventHandler(this.button1_Click);
            // 
            // reportButtonStorage
            // 
            this.reportButtonStorage.Location = new System.Drawing.Point(309, 9);
            this.reportButtonStorage.Name = "reportButtonStorage";
            this.reportButtonStorage.Size = new System.Drawing.Size(119, 33);
            this.reportButtonStorage.TabIndex = 4;
            this.reportButtonStorage.Text = "Preču skaits noliktavā";
            this.reportButtonStorage.UseVisualStyleBackColor = true;
            this.reportButtonStorage.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(434, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 33);
            this.button2.TabIndex = 5;
            this.button2.Text = "Meklēt preces";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // StockDataSet1
            // 
            this.StockDataSet1.DataSetName = "StockDataSet1";
            this.StockDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // NoliktavaBindingSource
            // 
            this.NoliktavaBindingSource.DataMember = "Noliktava";
            this.NoliktavaBindingSource.DataSource = this.StockDataSet1;
            // 
            // NoliktavaTableAdapter
            // 
            this.NoliktavaTableAdapter.ClearBeforeFill = true;
            // 
            // stockDataSetBindingSource
            // 
            this.stockDataSetBindingSource.DataSource = this.StockDataSet;
            this.stockDataSetBindingSource.Position = 0;
            // 
            // noliktavaBindingSource1
            // 
            this.noliktavaBindingSource1.DataMember = "Noliktava";
            this.noliktavaBindingSource1.DataSource = this.StockDataSet1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(559, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Preces daudzums mazāks kā";
            // 
            // daudzumsUnder
            // 
            this.daudzumsUnder.Location = new System.Drawing.Point(562, 24);
            this.daudzumsUnder.Name = "daudzumsUnder";
            this.daudzumsUnder.Size = new System.Drawing.Size(100, 20);
            this.daudzumsUnder.TabIndex = 7;
            this.daudzumsUnder.TextChanged += new System.EventHandler(this.daudzumsUnder_TextChanged);
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 471);
            this.Controls.Add(this.daudzumsUnder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.reportButtonStorage);
            this.Controls.Add(this.sumVeikals);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Reports";
            this.Text = "Reports";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Reports_FormClosing);
            this.Load += new System.EventHandler(this.Reports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.produktiBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StockDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProduktiBindingSource)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StockDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NoliktavaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noliktavaBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ProduktiBindingSource;
        private StockDataSet StockDataSet;
        private StockDataSetTableAdapters.ProduktiTableAdapter ProduktiTableAdapter;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem produktiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noliktavaToolStripMenuItem;
        private System.Windows.Forms.Button sumVeikals;
        private System.Windows.Forms.Button reportButtonStorage;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource NoliktavaBindingSource;
        private StockDataSet1 StockDataSet1;
        private StockDataSet1TableAdapters.NoliktavaTableAdapter NoliktavaTableAdapter;
        private System.Windows.Forms.BindingSource stockDataSetBindingSource;
        private System.Windows.Forms.BindingSource noliktavaBindingSource1;
        private System.Windows.Forms.BindingSource produktiBindingSource1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox daudzumsUnder;
    }
}