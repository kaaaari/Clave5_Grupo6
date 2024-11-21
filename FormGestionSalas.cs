using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Clave5_Grupo6
{
    public partial class FormGestionSalas : Form
    {
        public FormGestionSalas()
        {
            InitializeComponent();
            CargarSalas();
        }

        private void CargarSalas()
        {
            string connectionString = "server=localhost;database=Clave5_Grupo6;user=root;password=220044"; // Ajusta el password y el nombre de la base de datos
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Salas"; // Asegúrate de tener una tabla 'Salas' en la base de datos
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvSalas.DataSource = dt;
            }
        }

        private void btnAgregarSala_Click_1(object sender, EventArgs e)
        {
            using (FormAgregarSala formAgregarSala = new FormAgregarSala())
            {
                if (formAgregarSala.ShowDialog() == DialogResult.OK)
                {
                    CargarSalas();  // Recarga las salas después de agregar una nueva
                }
            }
        }

        private void btnEditarSala_Click_1(object sender, EventArgs e)
        {
            if (dgvSalas.SelectedRows.Count > 0)
            {
                int salaId = Convert.ToInt32(dgvSalas.SelectedRows[0].Cells["Id"].Value);

                using (FormAgregarSala formEditarSala = new FormAgregarSala(salaId))
                {
                    if (formEditarSala.ShowDialog() == DialogResult.OK)
                    {
                        CargarSalas();  // Recarga las salas después de editar
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una sala para editar.");
            }
        }

        private void btnCargarSala_Click(object sender, EventArgs e)
        {
            CargarSalas();
        }

        private void btnEliminarSala_Click_1(object sender, EventArgs e)
        {
            if (dgvSalas.SelectedRows.Count > 0)
            {
                int salaId = Convert.ToInt32(dgvSalas.SelectedRows[0].Cells["Id"].Value);

                string connectionString = "server=localhost;database=Clave5_Grupo6;user=root;password=220044"; // Ajusta el password y nombre de la base de datos
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM Salas WHERE Id = @Id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Id", salaId);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sala eliminada correctamente.");
                }
                CargarSalas();  // Recarga las salas después de eliminar
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una sala para eliminar.");
            }
        }
    }
}
