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
    public partial class FormAgregarUsuario : Form
    {
        private int usuarioId;
        public FormAgregarUsuario()
        {
            InitializeComponent();
        }

        // Constructor para editar un usuario existente
        public FormAgregarUsuario(int usuarioId)
        {
            InitializeComponent();
            this.usuarioId = usuarioId;
            CargarUsuario(usuarioId); // Cargar los datos del usuario para editar
        }

        private void CargarUsuario(int usuarioId)
        {
            string connectionString = "server=localhost;database=Clave5_Grupo6;user=root;password=220044";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Usuarios WHERE Id = @Id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", usuarioId);

                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    // Asumiendo que tienes controles como TextBox o ComboBox
                    txtNombre.Text = reader["Nombre"].ToString();
                    
                    
                }
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;database=Clave5_Grupo6;user=root;password=220044";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Usuarios (Nombre, Correo, Rol) VALUES (@Nombre, @Correo, @Rol)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                cmd.Parameters.AddWithValue("@Correo", txtCorreo.Text);
                cmd.Parameters.AddWithValue("@Rol", txtRol.Text);
                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Usuario agregado correctamente.");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
    
}
