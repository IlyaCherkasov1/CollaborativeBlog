using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using Laba26_PlugLevel.Properties;

namespace Laba26_PlugLevel
{
    public partial class Form1 : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        public Form1()
        {
            InitializeComponent();
    
            WriteTable();
        }

        private void WriteTable()
        {
            string sqlExpression = "SELECT * FROM Medicine";
            List<Medicine> medicines = new List<Medicine>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = command.ExecuteReader();
                
                if (reader.HasRows) 
                {
               //     medicines.Add(new Medicine(reader));

                    while (reader.Read()) 
                    {
                        string name = reader.GetString(0);
                        string producer = reader.GetString(1);
                        string substance = reader.GetString(2);
                        medicines.Add(new Medicine(name,producer,substance));         
                    }
                }

                reader.Close();
                dataGridView1.DataSource = medicines;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string producer = textBox2.Text;
            string substance = textBox3.Text;
            AddData(name, producer, substance);
        }

        private void AddData(string name, string producer, string substance)
        {
            string sqlExpression = "INSERT INTO Medicine (Name, Producer, Substance)" +
                " VALUES (@name, @producer, @substance)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();
                SqlCommand command = connection.CreateCommand();
                command.Transaction = transaction;
                
                SqlParameter nameParametr = new SqlParameter("@name", name);
                SqlParameter producerParametr = new SqlParameter("@producer", producer);
                SqlParameter substanceParametr = new SqlParameter("@substance", substance);
                command.Parameters.Add(nameParametr);
                command.Parameters.Add(producerParametr);
                command.Parameters.Add(substanceParametr);

                try
                {
                    command.CommandText = sqlExpression;
                    command.ExecuteNonQuery();
                    transaction.Commit();
                    MessageBox.Show("Транзакция прошла успешна");
                    WriteTable();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    transaction.Rollback();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string producer = textBox2.Text;
            string substance = textBox3.Text;

            var row = dataGridView1.SelectedRows[0];
            string whereName = row.Cells[0].Value.ToString();
            string sqlExpression = "UPDATE Medicine SET" +
                " Name=@name, Producer=@producer, Substance=@substance WHERE Name=@WhereName";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();
                SqlCommand command = connection.CreateCommand();
                command.Transaction = transaction;

                SqlParameter nameParametr = new SqlParameter("@name", name);
                SqlParameter producerParametr = new SqlParameter("@producer", producer);
                SqlParameter substanceParametr = new SqlParameter("@substance", substance);
                SqlParameter whereNameParametr = new SqlParameter("@WhereName", whereName);
                command.Parameters.Add(nameParametr);
                command.Parameters.Add(producerParametr);
                command.Parameters.Add(substanceParametr);
                command.Parameters.Add(whereNameParametr);
                try
                {
                    command.CommandText = sqlExpression;
                    command.ExecuteNonQuery();
                    transaction.Commit();
                    MessageBox.Show("Транзакция прошла успешна");
                    WriteTable();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    transaction.Rollback();
                }

            }
            WriteTable();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sqlExpression = "DELETE FROM Medicine WHERE Name=@name";
            var row = dataGridView1.SelectedRows[0];
            string name = row.Cells[0].Value.ToString();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();
                SqlCommand command = connection.CreateCommand();
                command.Transaction = transaction;
                 
                SqlParameter nameParametr = new SqlParameter("@name", name);
                command.Parameters.Add(nameParametr);

                try
                {
                    command.CommandText = sqlExpression;
                    command.ExecuteNonQuery();
                    transaction.Commit();
                    MessageBox.Show("Транзакция прошла успешна");
                    WriteTable();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    transaction.Rollback();
                }
            }

        }
    }

}
