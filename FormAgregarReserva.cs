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
    public partial class FormAgregarReserva : Form
    {
        private int reservaId;
        public FormAgregarReserva()
        {
            InitializeComponent();
        }

        public FormAgregarReserva(int reservaId)
        {
            InitializeComponent();
            this.reservaId = reservaId;
            CargarReserva(reservaId); // Cargar los datos de la reserva para editar
        }

        private void CargarReserva(int reservaId)
        {
            string connectionString = "server=localhost;database=Clave5_Grupo6;user=root;password=220044";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Reservas WHERE Id = @Id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", reservaId);

                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    // Asumiendo que tienes controles como TextBox o ComboBox
                    txtNombrePersona.Text = reader["NombreReservante"].ToString();
                    dtpFechaReserva.Text = reader["FechaReserva"].ToString();
                    // ... Cargar otros campos aquí
                }
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;database=Clave5_Grupo6;user=root;password=220044";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Reservas (SalaId, FechaReserva, NombrePersona, Asistentes) VALUES (@SalaId, @FechaReserva, @NombrePersona, @Asistentes)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@SalaId", txtSalaId.Text);
                cmd.Parameters.AddWithValue("@FechaReserva", dtpFechaReserva.Value);
                cmd.Parameters.AddWithValue("@NombrePersona", txtNombrePersona.Text);
                cmd.Parameters.AddWithValue("@Asistentes", txtAsistentes.Text);
                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Reserva agregada correctamente.");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
    
}
