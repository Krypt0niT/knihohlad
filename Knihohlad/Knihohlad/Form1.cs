using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImageMagick;

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

            listBox1.Items.Clear();

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
                string[] split = listBox1.SelectedItem.ToString().Split('\t');

                string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=knizky;";
                string query = "SELECT * FROM knihy WHERE id = \""+ split[0] + "\"";

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
                            if (reader.GetString("nazov") != null)
                            {
                                Nazov.Text = reader.GetString("nazov");
                                PridatNazov.Text = reader.GetString("nazov");
                            }
                            else
                            {
                                Nazov.Text = "";
                                PridatNazov.Text = "";
                            }
                            if (reader.GetString("autor") != null)
                            {
                                Autor.Text = reader.GetString("autor");
                                PridatAutor.Text = reader.GetString("autor");
                            }
                            else
                            {
                                Autor.Text = "";
                                PridatAutor.Text = "";
                            }
                            if (reader.GetString("informacieoknihe") != null)
                            {
                                string[] AboutSplit = reader.GetString("informacieoknihe").Split('<');
                                Popis.Text = AboutSplit[0];
                                pridatPopis.Text = AboutSplit[0];
                            }
                            else
                            {
                                Popis.Text = "";
                                pridatPopis.Text = "";

                            }
                            if (reader.GetString("kategoria") != null)
                            {
                                Kategoria.Text = reader.GetString("kategoria");
                                PridatKategoria.Text = reader.GetString("kategoria");
                            }
                            else
                            {
                                Kategoria.Text = "";
                                PridatKategoria.Text = "";
                            }
                            if (reader.GetString("hodnotenie") != null)
                            {
                                hodnotenie.Text = "";
                                for (int i = 0; i < Int32.Parse(reader.GetString("hodnotenie")) +1; i++)
                                {
                                    hodnotenie.Text += "*";
                                }
                                pridatHodnotenie.Text = reader.GetString("hodnotenie");
                            }
                            else
                            {
                                hodnotenie.Text = "";
                            }
                            if (reader.GetString("cena") != null)
                            {
                                cena.Text = reader.GetString("cena") + "€";
                                PridatCena.Text = reader.GetString("cena") + "€";
                            }
                            else
                            {
                                cena.Text = "";
                            }



                            using (var image = new MagickImage(reader.GetString("obrazok")))
                            {
                                image.Format = MagickFormat.Png;
                                image.Write("cesta_k_novemu_obrazku.png");

                                PictureBox1.Load(reader.GetString("obrazok")+".png");
                            }
                            PridajURL.Text = reader.GetString("obrazok");
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }

            }
        }
        

  

        private void VyhladavanieInput_TextChanged(object sender, EventArgs e)
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=knizky;";
            string query = "SELECT * FROM knihy WHERE nazov LIKE '"+ VyhladavanieInput.Text +"%';";

            listBox1.Items.Clear();

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
                    Console.WriteLine("nenajdene udeja v tabulke");
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] split = listBox1.SelectedItem.ToString().Split('\t');
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=knizky;";
            string query = "DELETE FROM knihy WHERE id = " + Int32.Parse(split[0]) + ";";


            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void PridatNazov_TextChanged(object sender, EventArgs e)
        {
            if(PridatNazov.Text != Nazov.Text)
            {
                EditButton.Enabled = true;
            }
 
        }

        private void PridatAutor_TextChanged(object sender, EventArgs e)
        {
            if (PridatAutor.Text != Autor.Text)
            {
                EditButton.Enabled = true;
            }


        }

        private void PridatKategoria_TextChanged(object sender, EventArgs e)
        {
            if (PridatKategoria.Text != Kategoria.Text)
            {
                EditButton.Enabled = true;
            }
 
        }

        private void pridatHodnotenie_TextChanged(object sender, EventArgs e)
        {
 

        }

        private void PridatCena_TextChanged(object sender, EventArgs e)
        {
            if (PridatCena.Text != cena.Text)
            {
                EditButton.Enabled = true;
            }

        }

        private void PridajURL_TextChanged(object sender, EventArgs e)
        {
  
        }

        private void pridatPopis_TextChanged(object sender, EventArgs e)
        {
            if (pridatPopis.Text != Popis.Text)
            {
                EditButton.Enabled = true;
            }

        }
    }
}
