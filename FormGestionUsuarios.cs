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
    public partial class FormGestionUsuarios : Form
    {
        public FormGestionUsuarios()
        {
            InitializeComponent();
            CargarUsuarios();
        }
        private void CargarUsuarios()
        {
            string connectionString = "server=localhost;database=Clave5_Grupo6;user=root;password=220044";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Usuarios";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                System.Data.DataTable dt = new System.Data.DataTable();
                adapter.Fill(dt);
                dgvUsuarios.DataSource = dt;
            }
        }

        private void btnCargarUsuarios_Click(object sender, EventArgs e)
        {
            CargarUsuarios();
        }

        private void btnAgregarUsuarios_Click(object sender, EventArgs e)
        {
            using (FormAgregarUsuario formAgregarUsuario = new FormAgregarUsuario())
            {
                if (formAgregarUsuario.ShowDialog() == DialogResult.OK)
                {
                    CargarUsuarios();
                }
            }
        }

        private void btnEditarUsuarios_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                int usuarioId = Convert.ToInt32(dgvUsuarios.SelectedRows[0].Cells["Id"].Value);

                using (FormAgregarUsuario formEditarUsuario = new FormAgregarUsuario(usuarioId))
                {
                    if (formEditarUsuario.ShowDialog() == DialogResult.OK)
                    {
                        CargarUsuarios();
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un usuario para editar.");
            }
        }

        private void btnEliminarUsuarios_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                int usuarioId = Convert.ToInt32(dgvUsuarios.SelectedRows[0].Cells["Id"].Value);

                string connectionString = "server=localhost;database=workoffice;user=root;password=tu_password";
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM Usuarios WHERE Id = @Id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Id", usuarioId);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Usuario eliminado correctamente.");
                }
                CargarUsuarios();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un usuario para eliminar.");
            }
        }
    }
    
}
