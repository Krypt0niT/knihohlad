using MySql.Data.MySqlClient;
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

namespace Knihohlad
{
    public partial class Form1 : Form
    {
        //String stdDetail = "{0,-50}{1,-20}{2,-50}{3,-50}{4,-100}";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            db_connect();
            
          

        }
        void db_connect()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=knizky;";
            string query = "SELECT * FROM knihy";

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);

            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);


            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;


            try
            {
                databaseConnection.Open();

                reader = commandDatabase.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                      
                        listBox1.Items.Add(reader.GetString("id") + "\t" + reader.GetString("nazov"));
                    }
                }
                else
                {
                    Console.WriteLine("No rows found.");
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string[] split = listBox1.SelectedItem.ToString().Split(' ');

                string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=knizky;";
                string query = "SELECT nazov, autor , obrazok , informacieoknihe FROM knihy WHERE id = \""+ split[0] + "\"";

                MySqlConnection databaseConnection = new MySqlConnection(connectionString);

                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);


                commandDatabase.CommandTimeout = 60;
                MySqlDataReader reader;


                try
                {
                    databaseConnection.Open();

                    reader = commandDatabase.ExecuteReader();

                    if (reader.HasRows)
                    {
                        int a = 0;
                        while (reader.Read())
                        {
                            a++;
                            Nazov.Text = reader.GetString("nazov");
                            Autor.Text = reader.GetString("autor");
                            Popis.Text = reader.GetString("informacieoknihe");
                            Image.ImageLocation = reader.GetString("obrazok");
                            MessageBox.Show(Image.ImageLocation);


                        }

                    }
                



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }


    }
}
