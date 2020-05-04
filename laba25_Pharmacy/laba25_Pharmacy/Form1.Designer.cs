namespace laba25_Pharmacy
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.medicineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wareHouseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SellbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pharmacyDataSet = new laba25_Pharmacy.PharmacyDataSet();
            this.WarehouseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sellTableAdapter = new laba25_Pharmacy.PharmacyDataSetTableAdapters.SellTableAdapter();
            this.warehouseTableAdapter = new laba25_Pharmacy.PharmacyDataSetTableAdapters.WarehouseTableAdapter();
            this.MedicineBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.medicineTableAdapter = new laba25_Pharmacy.PharmacyDataSetTableAdapters.MedicineTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SellbindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WarehouseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MedicineBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 69);
            this.button1.TabIndex = 0;
            this.button1.Text = "add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(211, 249);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 69);
            this.button2.TabIndex = 1;
            this.button2.Text = "save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.medicineToolStripMenuItem,
            this.sellToolStripMenuItem,
            this.wareHouseToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1148, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // medicineToolStripMenuItem
            // 
            this.medicineToolStripMenuItem.Name = "medicineToolStripMenuItem";
            this.medicineToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.medicineToolStripMenuItem.Text = "medicine";
            this.medicineToolStripMenuItem.Click += new System.EventHandler(this.medicineToolStripMenuItem_Click);
            // 
            // sellToolStripMenuItem
            // 
            this.sellToolStripMenuItem.Name = "sellToolStripMenuItem";
            this.sellToolStripMenuItem.Size = new System.Drawing.Size(45, 24);
            this.sellToolStripMenuItem.Text = "sell";
            this.sellToolStripMenuItem.Click += new System.EventHandler(this.sellToolStripMenuItem_Click);
            // 
            // wareHouseToolStripMenuItem
            // 
            this.wareHouseToolStripMenuItem.Name = "wareHouseToolStripMenuItem";
            this.wareHouseToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.wareHouseToolStripMenuItem.Text = "WareHouse";
            this.wareHouseToolStripMenuItem.Click += new System.EventHandler(this.wareHouseToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1043, 196);
            this.dataGridView1.TabIndex = 3;
            // 
            // SellbindingSource
            // 
            this.SellbindingSource.DataMember = "Sell";
            this.SellbindingSource.DataSource = this.pharmacyDataSet;
            // 
            // pharmacyDataSet
            // 
            this.pharmacyDataSet.DataSetName = "PharmacyDataSet";
            this.pharmacyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // WarehouseBindingSource
            // 
            this.WarehouseBindingSource.AllowNew = false;
            this.WarehouseBindingSource.DataMember = "Warehouse";
            this.WarehouseBindingSource.DataSource = this.pharmacyDataSet;
            // 
            // sellTableAdapter
            // 
            this.sellTableAdapter.ClearBeforeFill = true;
            // 
            // warehouseTableAdapter
            // 
            this.warehouseTableAdapter.ClearBeforeFill = true;
            // 
            // MedicineBindingSource1
            // 
            this.MedicineBindingSource1.AllowNew = false;
            this.MedicineBindingSource1.DataMember = "Medicine";
            this.MedicineBindingSource1.DataSource = this.pharmacyDataSet;
            // 
            // medicineTableAdapter
            // 
            this.medicineTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 427);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SellbindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WarehouseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MedicineBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource SellbindingSource;
        private System.Windows.Forms.BindingSource WarehouseBindingSource;
        private PharmacyDataSetTableAdapters.SellTableAdapter sellTableAdapter;
        private PharmacyDataSetTableAdapters.WarehouseTableAdapter warehouseTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem medicineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sellToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wareHouseToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        public PharmacyDataSet pharmacyDataSet;
        private System.Windows.Forms.BindingSource MedicineBindingSource1;
        private PharmacyDataSetTableAdapters.MedicineTableAdapter medicineTableAdapter;
    }
}

