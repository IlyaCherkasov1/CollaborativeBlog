using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataAdapter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        AthletesAndTheirAchievementsDataSetTableAdapters.CountryTableAdapter countrys =
            new AthletesAndTheirAchievementsDataSetTableAdapters.CountryTableAdapter();
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = countrys.List2();
           
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string country = textBox1.Text;
            string capital = textBox2.Text;
            countrys.insert(country, capital);
            dataGridView1.DataSource = countrys.List2();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            countrys.DeleteQuery(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            dataGridView1.DataSource = countrys.List2();
        }
    }
}
