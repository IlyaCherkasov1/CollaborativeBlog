using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba27_EntityFramework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public List<Medicine> medicines = new List<Medicine>();
        public List<InStock> inStocks = new List<InStock>();
        public List<Sell> sells = new List<Sell>();
        private void button1_Click(object sender, EventArgs e)
        {
            AddForm af = new AddForm();
            af.Owner = this;
            af.Show();

        }

        private void medicineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WriteMedicine();
        }

        private void WriteMedicine()
        {
            
            using (AppDBContext db = new AppDBContext())
            {
                medicines.Clear();
                dataGridView1.DataSource = null;
                var users = db.Medicines;
                foreach (Medicine m in users)
                {
                    medicines.Add(new Medicine(m.id, m.Name, m.Producer, m.Substance));
                }
                dataGridView1.DataSource = medicines;
            }
        }

        private void inStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (AppDBContext db = new AppDBContext())
            {
                var stocks = db.inStocks;
                foreach (InStock m in stocks)
                {
                    inStocks.Add(new InStock(m.id, m.Medicine, m.Dosage, m.ShelfLife, m.Price, m.Number, m.Photo));
                }
                dataGridView1.DataSource = inStocks;
            }
        }

        private void sellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (AppDBContext db = new AppDBContext())
            {
                var sell = db.Sells;
                foreach (Sell m in sell)
                {
                    sells.Add(new Sell(m.id, m.Medicine, m.Number, m.Date, m.Discount));
                }
                dataGridView1.DataSource = sells;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using(AppDBContext db = new AppDBContext())
            {
                var row = dataGridView1.SelectedRows[0];
                 int id = (int)row.Cells[0].Value;
                Medicine medicine1 = db.Medicines.Where(x => x.id==id).FirstOrDefault();
                if (medicine1 != null)
                {
                    db.Entry(medicine1).State = EntityState.Deleted;
                    db.SaveChanges();
                }
            }
            WriteMedicine();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (AppDBContext db = new AppDBContext())
            {
                var row = dataGridView1.SelectedRows[0];
                int id = (int)row.Cells[0].Value;
                Medicine medicine1 = db.Medicines.Where(x => x.id == id).FirstOrDefault();
                if (medicine1 != null)
                {
                    medicine1.Name = textBox1.Text;
                    medicine1.Producer = textBox2.Text;
                    medicine1.Substance = textBox3.Text;
                    db.SaveChanges();
                }
            }
            WriteMedicine();
        }
    }
}
