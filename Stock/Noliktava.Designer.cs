namespace Stock
{
    partial class Noliktava
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Noliktava));
            this.produktiTableAdapter = new Stock.StockDataSetTableAdapters.ProduktiTableAdapter();
            this.produktiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockDataSet = new Stock.StockDataSet();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.derigumaTerminsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.daudzumsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.veidsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produktaVardsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produktaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.noliktavaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockDataSet1 = new Stock.StockDataSet1();
            this.noliktavaTableAdapter = new Stock.StockDataSet1TableAdapters.NoliktavaTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.atskaitesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.produktiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noliktavaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockDataSet1)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // produktiTableAdapter
            // 
            this.produktiTableAdapter.ClearBeforeFill = true;
            // 
            // produktiBindingSource
            // 
            this.produktiBindingSource.DataMember = "Produkti";
            this.produktiBindingSource.DataSource = this.stockDataSet;
            // 
            // stockDataSet
            // 
            this.stockDataSet.DataSetName = "StockDataSet";
            this.stockDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(586, 152);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 30;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Rimi",
            "Maxima",
            "Cenuklubs",
            "Samsung",
            "Valmieras piens"});
            this.comboBox2.Location = new System.Drawing.Point(452, 151);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 29;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(309, 151);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 27;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(146, 152);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(102, 20);
            this.textBox2.TabIndex = 25;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 152);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(583, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Derīguma termiņš";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(449, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Piegādātājs";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(306, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Daudzums";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Produkta vārds";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Produkta identifikators";
            // 
            // derigumaTerminsDataGridViewTextBoxColumn
            // 
            this.derigumaTerminsDataGridViewTextBoxColumn.DataPropertyName = "DerigumaTermins";
            this.derigumaTerminsDataGridViewTextBoxColumn.HeaderText = "DerigumaTermins";
            this.derigumaTerminsDataGridViewTextBoxColumn.Name = "derigumaTerminsDataGridViewTextBoxColumn";
            // 
            // daudzumsDataGridViewTextBoxColumn
            // 
            this.daudzumsDataGridViewTextBoxColumn.DataPropertyName = "Daudzums";
            this.daudzumsDataGridViewTextBoxColumn.HeaderText = "Daudzums";
            this.daudzumsDataGridViewTextBoxColumn.Name = "daudzumsDataGridViewTextBoxColumn";
            // 
            // veidsDataGridViewTextBoxColumn
            // 
            this.veidsDataGridViewTextBoxColumn.DataPropertyName = "Veids";
            this.veidsDataGridViewTextBoxColumn.HeaderText = "Veids";
            this.veidsDataGridViewTextBoxColumn.Name = "veidsDataGridViewTextBoxColumn";
            // 
            // produktaVardsDataGridViewTextBoxColumn
            // 
            this.produktaVardsDataGridViewTextBoxColumn.DataPropertyName = "ProduktaVards";
            this.produktaVardsDataGridViewTextBoxColumn.HeaderText = "ProduktaVards";
            this.produktaVardsDataGridViewTextBoxColumn.Name = "produktaVardsDataGridViewTextBoxColumn";
            // 
            // produktaIDDataGridViewTextBoxColumn
            // 
            this.produktaIDDataGridViewTextBoxColumn.DataPropertyName = "ProduktaID";
            this.produktaIDDataGridViewTextBoxColumn.HeaderText = "ProduktaID";
            this.produktaIDDataGridViewTextBoxColumn.Name = "produktaIDDataGridViewTextBoxColumn";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.produktaIDDataGridViewTextBoxColumn,
            this.produktaVardsDataGridViewTextBoxColumn,
            this.veidsDataGridViewTextBoxColumn,
            this.daudzumsDataGridViewTextBoxColumn,
            this.derigumaTerminsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.noliktavaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(15, 231);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 252);
            this.dataGridView1.TabIndex = 31;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // noliktavaBindingSource
            // 
            this.noliktavaBindingSource.DataMember = "Noliktava";
            this.noliktavaBindingSource.DataSource = this.stockDataSet1;
            // 
            // stockDataSet1
            // 
            this.stockDataSet1.DataSetName = "StockDataSet1";
            this.stockDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // noliktavaTableAdapter
            // 
            this.noliktavaTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(962, 24);
            this.menuStrip1.TabIndex = 32;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atskaitesToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(962, 24);
            this.menuStrip2.TabIndex = 33;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // atskaitesToolStripMenuItem
            // 
            this.atskaitesToolStripMenuItem.Name = "atskaitesToolStripMenuItem";
            this.atskaitesToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.atskaitesToolStripMenuItem.Text = "Atskaites";
            this.atskaitesToolStripMenuItem.Click += new System.EventHandler(this.atskaitesToolStripMenuItem_Click);
            // 
            // Noliktava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 585);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Noliktava";
            this.Text = "Noliktava";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Noliktava_FormClosing);
            this.Load += new System.EventHandler(this.Noliktava_Load);
            ((System.ComponentModel.ISupportInitialize)(this.produktiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noliktavaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockDataSet1)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private StockDataSetTableAdapters.ProduktiTableAdapter produktiTableAdapter;
        private System.Windows.Forms.BindingSource produktiBindingSource;
        private StockDataSet stockDataSet;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn derigumaTerminsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn daudzumsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn veidsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn produktaVardsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn produktaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private StockDataSet1 stockDataSet1;
        private System.Windows.Forms.BindingSource noliktavaBindingSource;
        private StockDataSet1TableAdapters.NoliktavaTableAdapter noliktavaTableAdapter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem atskaitesToolStripMenuItem;
    }
}