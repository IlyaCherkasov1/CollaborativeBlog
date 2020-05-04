using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba27_EntityFramework
{
    public partial class AddForm : Form
    {
        int table = 0;

        public AddForm()
        {
            InitializeComponent();
            HideElements();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
        
                switch (table)
                {
                    case 0:
                        {
                            string name = textBox1.Text;
                            string producer = textBox2.Text;
                            string substance = textBox3.Text;
                            using (AppDBContext db = new AppDBContext())
                            {
                                 main.dataGridView1.DataSource = null;
                                Medicine medicine = new Medicine(default, name,producer,substance);
                                db.Medicines.Add(medicine);
                                db.SaveChanges();
                                var users = db.Medicines;
                                foreach (Medicine m in users)
                                {
                                    main.medicines.Add(new Medicine(m.id, m.Name, m.Producer, m.Substance));
                                }
                                main.dataGridView1.DataSource = main.medicines;

                        }
                        break;
                        }
                    case 1:
                        {
                            string medicine = textBox1.Text;
                            int dosage = int.Parse(textBox2.Text);
                            int shelfLife = int.Parse(textBox3.Text);
                            int price = int.Parse(textBox4.Text);
                            int number = int.Parse(textBox5.Text);
                            string photo = textBox6.Text;
                            using (AppDBContext db = new AppDBContext())
                            {
                             main.dataGridView1.DataSource = null;

                            InStock inStock = new InStock(default, medicine, dosage, shelfLife, price, number, photo);
                                db.inStocks.Add(inStock);
                                db.SaveChanges();

                                var stocks = db.inStocks;
                                foreach (InStock m in stocks)
                                {
                                    main.inStocks.Add(new InStock(m.id,m.Medicine, m.Dosage, m.ShelfLife, m.Price, m.Number, m.Photo));
                                }
                                main.dataGridView1.DataSource = main.inStocks;

                        }
                        break;
                        }
                    case 2:
                        {
                            string medicine = textBox1.Text;
                            int number = int.Parse(textBox2.Text);
                            DateTime date = Convert.ToDateTime(textBox3.Text);
                            int discount = int.Parse(textBox4.Text);
                            using (AppDBContext db = new AppDBContext())
                            {
                            main.dataGridView1.DataSource = null;

                            Sell sell = new Sell(default, medicine, number, date, discount);
                                db.Sells.Add(sell);
                                db.SaveChanges();
                                var sells = db.Sells;
                                foreach (Sell m in sells)
                                {
                                    main.sells.Add(new Sell(m.id, m.Medicine, m.Number, m.Date, m.Discount));
                                }
                                 main.dataGridView1.DataSource = main.sells;
                        }
                        break;
                        }
                }

            Close();
        }

        private void medicineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideElements();
            WrileNameLabels(0);
        }

        private void inStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideElements();
            WrileNameLabels(1);
        }

        private void sellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideElements();
            WrileNameLabels(2);
        }
        private void HideElements()
        {
            TextBox[] textBoxes = new TextBox[] { textBox1, textBox2, textBox3, textBox4, textBox5, textBox6};
            Label[] labels = new Label[] { label1, label2, label3, label4, label5, label6  };
            for (int i = 0; i < labels.Length; i++)
            {
                textBoxes[i].Visible = false;
                labels[i].Text = "";
            }
        }

        private void WrileNameLabels(int index)
        {
            switch (index)
            {
                case 0:
                    label1.Text = "Medicine";
                    label2.Text = "Producer";
                    label3.Text = "Substance";
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    
                    break;
                case 1:
                    label1.Text = "Medicine";
                    label2.Text = "Dosage";
                    label3.Text = "ShelfLife";
                    label4.Text = "Price";
                    label5.Text = "Number";
                    label6.Text = "Photo";
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    textBox5.Visible = true;
                    textBox6.Visible = true;
                    break;
                case 2:
                    label1.Text = "Medicine";
                    label2.Text = "Number";
                    label3.Text = "Date";
                    label4.Text = "Discount";
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    break;
            }
            table = index;
        }
    }
}
