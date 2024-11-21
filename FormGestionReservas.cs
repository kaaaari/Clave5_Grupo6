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
    public partial class FormGestionReservas : Form
    {
        public FormGestionReservas()
        {
            InitializeComponent();
            CargarReservas();
        }
        private void CargarReservas()
        {
            string connectionString = "server=localhost;database=Clave5_Grupo6;user=root;password=220044";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Reservas";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                System.Data.DataTable dt = new System.Data.DataTable();
                adapter.Fill(dt);
                dgvReservas.DataSource = dt;
            }
        }

        private void btnCargarReservas_Click(object sender, EventArgs e)
        {
            CargarReservas();
        }

        private void btnAgregarReserva_Click(object sender, EventArgs e)
        {
            using (FormAgregarReserva formAgregarReserva = new FormAgregarReserva())
            {
                if (formAgregarReserva.ShowDialog() == DialogResult.OK)
                {
                    CargarReservas();
                }
            }
        }

        private void btnEditarReserva_Click(object sender, EventArgs e)
        {
            if (dgvReservas.SelectedRows.Count > 0)
            {
                int reservaId = Convert.ToInt32(dgvReservas.SelectedRows[0].Cells["Id"].Value);

                using (FormAgregarReserva formEditarReserva = new FormAgregarReserva(reservaId))
                {
                    if (formEditarReserva.ShowDialog() == DialogResult.OK)
                    {
                        CargarReservas();
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una reserva para editar.");
            }
        }

        private void btnEliminarReserva_Click(object sender, EventArgs e)
        {
            if (dgvReservas.SelectedRows.Count > 0)
            {
                int reservaId = Convert.ToInt32(dgvReservas.SelectedRows[0].Cells["Id"].Value);

                string connectionString = "server=localhost;database=workoffice;user=root;password=tu_password";
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM Reservas WHERE Id = @Id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Id", reservaId);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Reserva eliminada correctamente.");
                }
                CargarReservas();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una reserva para eliminar.");
            }
        
        }
    }
}
