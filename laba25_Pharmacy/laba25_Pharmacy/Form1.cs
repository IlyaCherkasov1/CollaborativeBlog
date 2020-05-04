using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace laba25_Pharmacy
{
    public partial class Form1 : Form
    {
        PharmacyDataSetTableAdapters.MedicineTableAdapter medicines = new PharmacyDataSetTableAdapters.MedicineTableAdapter();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pharmacyDataSet.Medicine". При необходимости она может быть перемещена или удалена.
            this.medicineTableAdapter.Fill(this.pharmacyDataSet.Medicine);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pharmacyDataSet1.Sell". При необходимости она может быть перемещена или удалена.
            this.sellTableAdapter.Fill(this.pharmacyDataSet.Sell);

            // TODO: данная строка кода позволяет загрузить данные в таблицу "pharmacyDataSet1.Warehouse". При необходимости она может быть перемещена или удалена.
            this.warehouseTableAdapter.Fill(this.pharmacyDataSet.Warehouse);
        
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddForm af = new AddForm();
            af.Owner = this;
            af.Show();
        }



        private void medicineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = MedicineBindingSource1;
        }

        private void sellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = SellbindingSource;
        }

        private void wareHouseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = WarehouseBindingSource;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                medicineTableAdapter.Update(pharmacyDataSet.Medicine);
                sellTableAdapter.Update(pharmacyDataSet.Sell);
                warehouseTableAdapter.Update(pharmacyDataSet.Warehouse);
                MessageBox.Show("Update successful");
            }
            catch
            {
                MessageBox.Show("Update failed");
            }
        }

      
    }
}
