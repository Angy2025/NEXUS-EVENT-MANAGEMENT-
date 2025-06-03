using System;
using CapaNegocios;//EventosManager y Eventos (mis clases en esa capa)
using CapaDatos;
using System.Drawing.Text;
using System.Windows.Forms; 
using System.Collections.Generic; //List

namespace CAPA_DE_PRESENTACION
{
    public partial class FormPrincipal : Form
    {
        private EventosManager eventosManager;
        public FormPrincipal()
        {
            InitializeComponent();
            eventosManager = new EventosManager();

            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            this.btnD.Click += new System.EventHandler(this.btnD_Click);
            this.btnResumen.Click += new System.EventHandler(this.btnResumen_Click);
            this.dgvEventos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEventos_CellDoubleClick);
        }





        // MÉTODO PRIVADO REUTILIZABLE
        private void CargarEventosPorTipo(string tipo)
        {
            EventosManager gestorEventos = new EventosManager(); // Crear instancia de la clase de negocios
            List<Eventos> lista = gestorEventos.ObtenerEventosPorTipo(tipo); // Obtener datos desde la BD

            dgvEventos.DataSource = null; // Limpia el DataGridView
            dgvEventos.DataSource = lista; // Asigna la lista de eventos

            // Opcional: cambiar encabezados y ocultar columnas
            dgvEventos.Columns["Id"].Visible = false;
            dgvEventos.Columns["Fecha"].HeaderText = "Fecha del Evento";
            dgvEventos.Columns["Nombre"].HeaderText = "Nombre del Evento";
            dgvEventos.Columns["Lugar"].HeaderText = "Lugar";
            dgvEventos.Columns["Tipo"].HeaderText = "Tipo de Evento";
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtTitulo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnD_Click(object sender, EventArgs e)
        {

            CargarEventosPorTipo("Deportivo");
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            CargarEventosPorTipo("Cultural");
        }

        private void btnResumen_Click(object sender, EventArgs e)
        {
            //Primero verificamos que haya alguna fila seleccionada en el DataGridView
            if (dgvEventos.SelectedRows.Count > 0)
            {
                try
                {
                    // Obtener el objeto 'Eventos' de la fila actualmente seleccionada y el 'DataBoundItem' devuelve el objeto original al que la fila está enlazada
                    Eventos eventoSeleccionado = dgvEventos.SelectedRows[0].DataBoundItem as Eventos;

                    //Si se pudo obtener un objeto Eventos Valido
                    if (eventoSeleccionado != null)
                    {
                        // Crear una nueva instancia del formulario de detalles (FormDetallesEvento) y pasarle el objeto Eventos seleccionado como parámetro en el constructor
                        FormDetallesEvento formDetalles = new FormDetallesEvento(eventoSeleccionado);

                        //Mostrar mi segundo formulario de dettales (Lo muestro y paso el form1 a segundo plano)
                        formDetalles.ShowDialog();
                    }
                }
                catch (Exception ex)
                {
                    //Manejamos errores por si hay uno del tipo 404
                    MessageBox.Show("Error al intentar ver resumen del evento: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                //Informar al usuario que debe seleccionar un evento
                MessageBox.Show("Por favor, seleccione un evento de la lista para ver su resumen.", "Selección requerida", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            btnResumen.Enabled = dgvEventos.SelectedRows.Count > 0;
        }

        private void txtInstruccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvEventos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar que el doble clic no fue en el encabezado de las columnas (e.RowIndex >= 0) y que la fila existe (e.RowIndex < dgvEventos.Rows.Count)
            if (e.RowIndex >= 0 && e.RowIndex < dgvEventos.Rows.Count)
            {
                // Llamar directamente al método Click del botón "Ver Resumen". Esto evita duplicar la lógica de mostrar el resumen.
                btnResumen_Click(btnResumen, EventArgs.Empty);
            }
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            //Config de mi DataGridView
            dgvEventos.AllowUserToAddRows = false; //No permito que el usuario añada filas
            dgvEventos.AllowUserToDeleteRows = false; //No permito que el usuario elimine filas
            dgvEventos.MultiSelect = false; //No permito al usuario seleccione mas de 1 fila
            dgvEventos.AutoGenerateColumns = true; //Permito que se generen columnas desde la clase Eventos
            dgvEventos.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Seleccionar toda la fila al hacer clic

            btnResumen.Enabled = false;
        }
    }
}
