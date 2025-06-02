using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocios;
using CapaDatos; 

namespace CAPA_DE_PRESENTACION
{
    public partial class FormDetallesEvento : Form
    {
        private Eventos eventos;
        public FormDetallesEvento(Eventos eventos)
        {
            InitializeComponent();
            this.eventos = eventos;

            CargarDetallesEventos();

            this.btnclose.Click += new EventHandler(btnclose_Click);
        }

        // Método para cargar los detalles del evento en los TextBoxes
        private void CargarDetallesEventos()
        {
            this.Text = "Detalles del evento: " + eventos.Nombre;

            // Asigna los datos de las propiedades del objeto _evento a los TextBoxes correspondientes
            txtNombreEvento.Text = eventos.Nombre;
            txtLugarEvento.Text = eventos.Lugar;
            txtFechaEvento.Text = eventos.Fecha;
            txtTipoEvento.Text = eventos.Tipo;
        }

        private void FormDetallesEvento_Load(object sender, EventArgs e)
        {

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close(); //Para cerrar el formulario
        }

        private void txtLugarEvento_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
