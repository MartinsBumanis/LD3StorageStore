﻿namespace Stock
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
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
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
            this.veikalaPrecesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.galvenāLapaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
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
            this.dateTimePicker1.Location = new System.Drawing.Point(572, 75);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 30;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(339, 75);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 27;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(229, 75);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(102, 20);
            this.textBox2.TabIndex = 25;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(59, 75);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(164, 20);
            this.textBox1.TabIndex = 24;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label7.Location = new System.Drawing.Point(569, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 17);
            this.label7.TabIndex = 23;
            this.label7.Text = "Derīguma termiņš";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label5.Location = new System.Drawing.Point(335, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Daudzums";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label2.Location = new System.Drawing.Point(225, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Produkta vārds";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.Location = new System.Drawing.Point(56, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 17);
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
            this.dataGridView1.Location = new System.Drawing.Point(59, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(544, 334);
            this.dataGridView1.TabIndex = 31;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
        
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
            this.menuStrip1.Size = new System.Drawing.Size(820, 24);
            this.menuStrip1.TabIndex = 32;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atskaitesToolStripMenuItem,
            this.veikalaPrecesToolStripMenuItem,
            this.galvenāLapaToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(820, 24);
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
            // veikalaPrecesToolStripMenuItem
            // 
            this.veikalaPrecesToolStripMenuItem.Name = "veikalaPrecesToolStripMenuItem";
            this.veikalaPrecesToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.veikalaPrecesToolStripMenuItem.Text = "Veikala preces";
            this.veikalaPrecesToolStripMenuItem.Click += new System.EventHandler(this.veikalaPrecesToolStripMenuItem_Click);
            // 
            // galvenāLapaToolStripMenuItem
            // 
            this.galvenāLapaToolStripMenuItem.Name = "galvenāLapaToolStripMenuItem";
            this.galvenāLapaToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.galvenāLapaToolStripMenuItem.Text = "Galvenā lapa";
            this.galvenāLapaToolStripMenuItem.Click += new System.EventHandler(this.galvenāLapaToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(627, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 70);
            this.button1.TabIndex = 34;
            this.button1.Text = "Pievienot ierakstu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(59, 460);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 39);
            this.button3.TabIndex = 35;
            this.button3.Text = "Atjaunot DB informāciju";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(445, 75);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(121, 20);
            this.textBox3.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label3.Location = new System.Drawing.Point(442, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 37;
            this.label3.Text = "Veids";
            // 
            // Noliktava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 525);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Noliktava";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolStripMenuItem veikalaPrecesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem galvenāLapaToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
    }
}