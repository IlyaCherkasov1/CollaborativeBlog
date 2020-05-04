using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UP16_17_Database
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        AthletesAndTheirAchievementsDataSet athletesAndTheirAchievementsDataSet = new AthletesAndTheirAchievementsDataSet();
        AthletesAndTheirAchievementsDataSetTableAdapters.SportsmenTableAdapter sportsmen = new AthletesAndTheirAchievementsDataSetTableAdapters.SportsmenTableAdapter();
        AthletesAndTheirAchievementsDataSetTableAdapters.AchievementsTableAdapter achivment = new AthletesAndTheirAchievementsDataSetTableAdapters.AchievementsTableAdapter();
        AthletesAndTheirAchievementsDataSetTableAdapters.CountryTableAdapter country = new AthletesAndTheirAchievementsDataSetTableAdapters.CountryTableAdapter();
        AthletesAndTheirAchievementsDataSetTableAdapters.DisciplinesTableAdapter discipline = new AthletesAndTheirAchievementsDataSetTableAdapters.DisciplinesTableAdapter();

        string connectionString = ConfigurationManager.ConnectionStrings["UP16_17_Database.Properties.Settings.AthletesAndTheirAchievementsConnectionString"].ConnectionString;
        private void Form1_Load(object sender, EventArgs e)
        {
            insBtn.Visible = false;
            HideElements();
        }

        private void sportsmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            dataView.DataSource = achivment.GetData();
            HideElements();
            WrileNameLabels(index);
        }

        private void achievementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataView.DataSource = country.GetData();
            HideElements();
            WrileNameLabels(index);
        }

        private void countryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataView.DataSource = sportsmen.GetData();
            HideElements();
            WrileNameLabels(index);
        }

        private void disciplinesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataView.DataSource = discipline.GetData();
            HideElements();
            WrileNameLabels(index);
        }


        private void WrileNameLabels(int index)
        {
            TextBox[] textBoxes = new TextBox[] { textBox1, textBox2, textBox3, textBox4, textBox5, textBox6 };
            Label[] labels = new Label[] { label1, label2, label3, label4, label5, label6 };
            for (int i = 0; i < athletesAndTheirAchievementsDataSet.Tables[index].Columns.Count; i++)
            {
                labels[i].Visible = true;
                textBoxes[i].Visible = true;
                labels[i].Text = athletesAndTheirAchievementsDataSet.Tables[index].Columns[i].ToString();
            }
        }

        private void HideElements()
        {
            TextBox[] textBoxes = new TextBox[] { textBox1, textBox2, textBox3, textBox4, textBox5, textBox6 };
            Label[] labels = new Label[] { label1, label2, label3, label4, label5, label6 };
            for (int i = 0; i < labels.Length; i++)
            {
                textBoxes[i].Visible = false;
                textBoxes[i].Clear();
                labels[i].Visible = false;
            }
        }

        private void insBtn_Click(object sender, EventArgs e)
        {
            string sqlExpression = "";
            switch (index)
            {
                case 0:
                    achivment.InsertQuery(Int32.Parse(textBox1.Text), Int32.Parse(textBox2.Text), textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text);
                    dataView.DataSource = achivment.GetData();
                    break;
                case 1:
                    country.InsertQuery(textBox1.Text, textBox2.Text);
                    dataView.DataSource = country.GetData();
                    break;
                case 2:
                    sportsmen.InsertQuery(Int32.Parse(textBox1.Text), textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text);
                    dataView.DataSource = sportsmen.GetData();
                    break;
                case 3:
                    discipline.InsertQuery(textBox1.Text, textBox2.Text);
                    dataView.DataSource = discipline.GetData();
                    break;
                case 4:
                    sqlExpression = String.Format("INSERT INTO Rank (Rank, Category) VALUES ('{0}', {1})", textBox1.Text, Int32.Parse(textBox2.Text));
                    SQLCommand(sqlExpression);
                    PlugViewData("SELECT * FROM Rank");
                    break;
                case 5:
                    sqlExpression = String.Format("INSERT INTO ReceivedRank (Sportsmen, rank, Year) VALUES ('{0}', {1}, {2})", Int32.Parse(textBox1.Text), textBox2.Text, Int32.Parse(textBox3.Text));
                    SQLCommand(sqlExpression);
                    PlugViewData("SELECT * FROM ReceivedRank");
                    break;
                case 6:
                    sqlExpression = String.Format("INSERT INTO Teams (id, Name, Country, Disciplines, Status) VALUES ('{0}', {1}, {2}, {3}, {4})", textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
                    SQLCommand(sqlExpression);
                    PlugViewData("SELECT * FROM Teams");
                    break;
                case 7:
                    sqlExpression = String.Format("INSERT INTO TeamStructure (Team, Year, Sportsmen) VALUES ('{0}', {1}, {2})", textBox1.Text, Int32.Parse(textBox2.Text), Int32.Parse(textBox3.Text));
                    SQLCommand(sqlExpression);
                    PlugViewData("SELECT * FROM TeamStructure");
                    break;

            }
        }

        private void SQLCommand(string sqlExpression)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    int number = command.ExecuteNonQuery();
                    MessageBox.Show("обработанно объектов:" + number);
            }
        }

        public int index = 0;
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            index = menuStrip1.Items.IndexOf(e.ClickedItem);
            insBtn.Visible = true;
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sqlExpression = "";
            switch (index)
            {
                case 0:
                    achivment.DeleteQuery((int)dataView.CurrentRow.Cells[0].Value);
                    dataView.DataSource = achivment.GetData();
                    break;
                case 1:
                    country.DeleteQuery(dataView.CurrentRow.Cells[0].Value.ToString());
                    dataView.DataSource = country.GetData();
                    break;
                case 2:
                    sportsmen.DeleteQuery((int)dataView.CurrentRow.Cells[0].Value);
                    dataView.DataSource = sportsmen.GetData();
                    break;
                case 3:
                    discipline.DeleteQuery(dataView.CurrentRow.Cells[0].Value.ToString());
                    dataView.DataSource = discipline.GetData();
                    break;
                case 4:
                    sqlExpression = String.Format("DELETE  FROM Rank WHERE Rank='{0}'",dataView.CurrentRow.Cells[0].Value.ToString());
                    SQLCommand(sqlExpression);
                    PlugViewData("SELECT * FROM Rank");
                    break;
                case 5:
                    sqlExpression = String.Format("DELETE  FROM ReceivedRank WHERE Sportsmen={0}", (int)dataView.CurrentRow.Cells[0].Value);
                    SQLCommand(sqlExpression);
                    PlugViewData("SELECT * FROM ReceivedRank");
                    break;
                case 6:
                    sqlExpression = String.Format("DELETE  FROM Teams WHERE id='{0}'", dataView.CurrentRow.Cells[0].Value.ToString());
                    SQLCommand(sqlExpression);
                    PlugViewData("SELECT * FROM Teams");
                    break;
                case 7:
                    sqlExpression = String.Format("DELETE  FROM TeamStructure WHERE Team='{0}'", dataView.CurrentRow.Cells[0].Value.ToString());
                    SQLCommand(sqlExpression);
                    PlugViewData("SELECT * FROM TeamStructure");
                    break;
  
            }
        }

        private void rankToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sqlExpression = "SELECT * FROM Rank";
            List<Rank1> ranks = new List<Rank1>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string rank = reader.GetString(0);
                        int category = reader.GetInt32(1);
                        ranks.Add(new Rank1(rank, category));
                    }
                }
                reader.Close();
                dataView.DataSource = ranks;

                HideElements();
                SqlDataAdapter adapter = new SqlDataAdapter(sqlExpression, connection);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                PlugWrileNameLabels(dataSet);
                PlugWrileNameLabels(dataSet);
            }
        }

        private void reToolStripMenuItem_Click(object sender, EventArgs e)
        { 
          HideElements();
          PlugViewData("SELECT * FROM ReceivedRank");
        }

        private void teamsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           HideElements();
           PlugViewData("SELECT * FROM Teams");
        }

        private void teamToolStripMenuItem_Click(object sender, EventArgs e)
        {
          HideElements();
          PlugViewData("SELECT * FROM TeamStructure");
        }

        private void PlugWrileNameLabels( DataSet dataSet)
        {
            TextBox[] textBoxes = new TextBox[] { textBox1, textBox2, textBox3, textBox4, textBox5, textBox6 };
            Label[] labels = new Label[] { label1, label2, label3, label4, label5, label6 };
            for (int i = 0; i < dataSet.Tables[0].Columns.Count; i++)
            {
                labels[i].Visible = true;
                textBoxes[i].Visible = true;
                labels[i].Text = dataSet.Tables[0].Columns[i].ToString();
            }
        }

        private void PlugViewData(string sqlExpression)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sqlExpression, connection);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                dataView.DataSource = dataSet.Tables[0];
                PlugWrileNameLabels(dataSet);
            }

        }

   
    }
}
