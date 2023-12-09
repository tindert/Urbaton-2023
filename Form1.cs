using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1CRUD
{
    public partial class Form1 : Form
    {
        
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ali\Documents\testDB.mdf;Integrated Security=True;Connect Timeout=30");

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int itemCount = GetItemCount();
            con.Open();
            SqlCommand cmd = con.CreateCommand();   
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO dbo.Table1" +
                " (ID, UserName, FirstName, TwitterMessage)" +
                "\r\nVALUES ('" + (itemCount + 1).ToString() +
                "','" +
                FirstNameTextBox.Text +
                "','" +
                NickNameTextBox.Text +
                "','" +
                MessageTextBox.Text +
                "');\r\n";
            cmd.ExecuteNonQuery();  
            con.Close();

            //MessageBox.Show("record isert");
            IDtextBox.Text = (GetItemCount() + 1).ToString();
            ShowAll();
        }


        private int GetItemCount()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT COUNT(*) FROM dbo.Table1";
            int count = (int)cmd.ExecuteScalar();
            //ItemCountButton.Text = count.ToString();
            con.Close();
            return count;
        }
        private void ItemCountButton_Click(object sender, EventArgs e)
        {

            ItemCountButton.Text = GetItemCount().ToString();   

        }

        private void DeleteAllItemsButton_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM dbo.Table1";
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void ShowAll()
        {
            ShowAllTextBox.Text = "";
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM dbo.Table1";
            SqlDataReader rdr = cmd.ExecuteReader();

            //ShowAllTextBox.Multiline = true;

            while (rdr.Read())
            {
                ShowAllTextBox.Text += rdr[0].ToString() + " " +
                    rdr[1].ToString() + "  " +
                    rdr[2].ToString() + "  " +
                    rdr[3].ToString() + Environment.NewLine;
            }

            con.Close();

        }
        private void ShowAllButton_Click(object sender, EventArgs e)
        {
            ShowAll();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IDtextBox.Text = (GetItemCount() + 1).ToString  ();
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            string var = LoadItemTextBox.Text;
            string numer = string.Empty;
            foreach (char str in var)
            {
                if (char.IsDigit(str))
                    numer += str.ToString();
            }
            //Console.WriteLine("Numeric character is: " + numer);
            int ItemNum = int.Parse(numer);  



            con.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT TOP 1 * FROM dbo.Table1 WHERE ID = " + ItemNum, con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read()) // Проверка на наличие строки
                        {
                            // Получение значений столбцов
                            int id = Convert.ToInt32(reader["ID"]);
                            string name = reader["UserName"].ToString();
                            string city = reader["FirstName"].ToString();
                            string email = reader["TwitterMessage"].ToString();

                            // Использование значений...
                            Console.WriteLine(name + city);
                        LoadItemLabel.Text = id.ToString() + " " +
                            name + " " +
                            city + " " +   
                            email;
                        Console.WriteLine(LoadItemLabel.Text);
                        }
                        else
                    {
                        LoadItemLabel.Text = ("Данных нет");
                    }
                    }
                }
                con.Close();
            

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void MessageTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
