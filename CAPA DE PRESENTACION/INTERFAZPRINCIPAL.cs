using System;
using CapaNegocios;//EventosManager y Eventos (mis clases en esa capa)
using CapaDatos;
using System.Drawing.Text;
using System.Windows.Forms; 
using System.Collections.Generic; //List

namespace CAPA_DE_PRESENTACION
{
    public partial class INTERFAZPRINCIPAL : Form
    {
        private EventosManager eventosManager;
        public INTERFAZPRINCIPAL()
        {
            InitializeComponent();
            eventosManager = new EventosManager();


            //Config de mi DataGridView
            dgvEventos.AllowUserToAddRows = false; //No permito que el usuario añada filas
            dgvEventos.AllowUserToDeleteRows = false; //No permito que el usuario eliminar filas
            dgvEventos.MultiSelect = false; //No permito al usuario seleccionarr mas de 1 fila
            dgvEventos.AutoGenerateColumns = true; //Permito que se generen columnas desde la clase Eventos
            dgvEventos.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Seleccionar toda la fila al hacer clic

            btnResumen.Enabled = false;

            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            this.btnD.Click += new System.EventHandler(this.btnD_Click);
            this.btnResumen.Click += new System.EventHandler(this.btnResumen_Click);
            this.dgvEventos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEventos_CellDoubleClick);
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
            
           try 
            {
                //Obtener la lista de eventos deportivos desde la CN
                List<Eventos> eventosDeportivos = eventosManager.ObtenerEventosPorTipo("Deportivo");

                //Limpiar el DataSource actual y asignar la nueva lista al DataGridView
                dgvEventos.DataSource = null;
                dgvEventos.DataSource = eventosDeportivos;

                //Habilitar el boton "Ver Resumen..." si hay eventos en la lista, deshabilitarlo si no
                btnResumen.Enabled = eventosDeportivos.Count > 0;

                //Mostrar mensaje si no se encontraron eventos
                if (eventosDeportivos.Count == 0)
                {
                    MessageBox.Show("No se encontraron eventos Deportivos, intente nuevamente.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores en caso de problemas al cargar los eventos
                MessageBox.Show("Error al cargar eventos Deportivos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            try
            {
                //Obtener la lista de eventos culturales desde la CN
                List<Eventos> eventosCulturales = eventosManager.ObtenerEventosPorTipo("Cultural");

                //Limpiar el DataSource actual y asignar la nueva lista al DataGridView
                dgvEventos.DataSource = null;
                dgvEventos.DataSource = eventosCulturales;

                //Habilitar el boton "Ver Resumen..." si hay eventos en la lista, deshabilitarlo si no
                btnResumen.Enabled = eventosCulturales.Count > 0;

                //Mostrar mensaje si no se encontraron eventos
                if (eventosCulturales.Count == 0)
                {
                    MessageBox.Show("No se encontraron eventos culturales, intente nuevamente.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores en caso de problemas al cargar los eventos
                MessageBox.Show("Error al cargar eventos Culturales: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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
    }
}
