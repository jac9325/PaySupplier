using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaySupplier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (IDbConnection db = new MySqlConnection(ConfigurationManager.ConnectionStrings["conexionbd"].ConnectionString))
            {
                try
                {
                    db.Open();
                    MessageBox.Show("La conexión a la base de datos se ha establecido correctamente.");
                    var customers = db.Query<User>("SELECT Id, nombre, apellidos, email FROM users").ToList();
                    if (customers.Count > 0)
                    {
                        MessageBox.Show("Se extrajeron " + customers.Count + " registros de la tabla 'Customers'");
                    }
                    else
                    {
                        MessageBox.Show("No se ha encontrado ningún registro en la tabla 'Customers'");
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
