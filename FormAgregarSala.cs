using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Clave5_Grupo6
{
    public partial class FormAgregarSala : Form
    {
        private int salaId;
        public FormAgregarSala()
        {
            InitializeComponent();
            

        }

        public FormAgregarSala(int salaId)
        {
            InitializeComponent();
            this.salaId = salaId;
            CargarSala(salaId); 
        }

        private void CargarSala(int salaId)
        {
            string connectionString = "server=localhost;database=Clave5_Grupo6;user=root;password=220044";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Salas WHERE Id = @Id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", salaId);

                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    // Asumiendo que tienes controles como TextBox o ComboBox
                    txtNombre.Text = reader["Nombre"].ToString();
                    txtCapacidad.Text = reader["Capacidad"].ToString();
                    // ... Cargar otros campos aquí
                }
            }
        }
        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;database=Clave5:Grupo6;user=root;password=220044";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Salas (Nombre, Capacidad, Ubicacion, Distribucion, Equipo) VALUES (@Nombre, @Capacidad, @Ubicacion, @Distribucion, @Equipo)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                cmd.Parameters.AddWithValue("@Capacidad", txtCapacidad.Text);
                cmd.Parameters.AddWithValue("@Ubicacion", txtUbicacion.Text);
                cmd.Parameters.AddWithValue("@Distribucion", txtDistribucion.Text);
                cmd.Parameters.AddWithValue("@Equipo", txtEquipo.Text);
                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Sala agregada correctamente.");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void txtCapacidad_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
