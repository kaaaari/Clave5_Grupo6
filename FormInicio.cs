using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clave5_Grupo6
{
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
        }

       

        private void btnGestionSalas_Click_1(object sender, EventArgs e)
        {
            FormGestionSalas formgestionsalas = new FormGestionSalas();
            formgestionsalas.Show();
        }

        private void btnGestionUsuarios_Click(object sender, EventArgs e)
        {
            FormGestionUsuarios formgestionusuarios = new FormGestionUsuarios();
            formgestionusuarios.Show();
        }

        private void btnGestionReservas_Click_1(object sender, EventArgs e)
        {
            FormGestionReservas formgestionreservas = new FormGestionReservas();
            formgestionreservas.Show();
        }
    }
}
