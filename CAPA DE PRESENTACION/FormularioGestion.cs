using CAPA_DE_NEGOCIOS;
using CapaDatos;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Documents;
using System.Windows.Forms;


namespace CAPA_DE_PRESENTACION
{
    public partial class FormularioGestion : Form
    {

        #region Campos y Propiedades

        //Este delegado es como un "control remoto", almacenará el método OpenPanelHerencia del formulario Acceso
        public Action<Form> AbrirFormularioHijo { get; set; }

        //Instancia unica de la capa de negocios, para gestionar la logica de los eventos
        private readonly CN_EventosManager _eventosManager = new CN_EventosManager();

        // Almacena la lista completa de eventos para no tener que consultar la BD repetidamente
        private List<EventoBase> _listaCompletaDeEventos;

        #endregion





        #region Constructor y Carga del Formulario

        public FormularioGestion()
        {
            InitializeComponent();
        }
        private void frmGestionEventos_Load(object sender, EventArgs e)
        {
            try
            {
                //Configuramos las propiedades visuales del dgv2
                ConfigurarDGV();

                //Cargamos los tipos de eventos en el comboBox
                ConfigurarComboBox();

                //Cargamos todos los eventos desde la BD y los mostramos en el dgv2
                CargarEventos();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al iniciar el formulario de gestion: {ex.Message}", "Error capa 8", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion






        #region Configuraciones iniciales

        private void ConfigurarDGV()
        {
            // Hace que las columnas se ajusten automáticamente para llenar el control.
            dgv2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // Permite al usuario seleccionar filas completas en lugar de celdas individuales.
            dgv2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            // Evita que el usuario pueda seleccionar múltiples filas.
            dgv2.MultiSelect = false;
            // Oculta la cabecera de las filas (la columna gris de la izquierda).
            dgv2.RowHeadersVisible = false;
            dgv2.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgv2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }
        private void ConfigurarComboBox()
        {
            comBox.Items.Clear();
            comBox.Items.Add("Todos");
            comBox.Items.Add("Deportivo");
            comBox.Items.Add("Cultural");
            comBox.Items.Add("Tecnológico");
            comBox.Items.Add("Cinematográfico");
            comBox.Items.Add("Profesional");
            comBox.SelectedIndex = 0; //Seleccionamos "Todos" por defecto, inicalizandose en 0 
        }
        #endregion






        #region Carga de datos y estadisticas

        private void CargarEventos()
        {
            try
            {
                //Obtenemos la lista completa desde la capa de negocios
                _listaCompletaDeEventos = _eventosManager.ObtainAllEvents();

                //Asignamos la lista completa 
                dgv2.DataSource = null;
                dgv2.DataSource = _listaCompletaDeEventos;

                ActualizarEstadisticas();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se pudieron cargar los eventos: {ex.Message}", "Error de carga de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AplicarFiltros()
        {
            if (_listaCompletaDeEventos == null) return;


            // Empezamos siempre con la lista completa
            IEnumerable<EventoBase> consultaFiltrada = _listaCompletaDeEventos;
            string tipoSeleccionado = comBox.SelectedItem.ToString();

            //Aplicamos el filtro si la seleccion no es la opcion de todos los eventos
            if (comBox.SelectedItem != null && comBox.SelectedItem.ToString() != "Todos")
            {
                string tipoSeleccionado = comBox.SelectedItem.ToString();
                
                consultaFiltrada = consultaFiltrada.Where(evento => evento.Tipo.ToUpper() == tipoSeleccionado.ToUpper());
            }

            dgv2.DataSource = null;
            dgv2.DataSource = consultaFiltrada.ToList();
        }

        /// Calcula y muestra las estadísticas (total de eventos y próximo evento)
        private void ActualizarEstadisticas()
        {
            if (_listaCompletaDeEventos == null) return;

            //Calculamos el total de eventos y mostrarlo en el Label correspondiente
            lblTotalEventos.Text = $"Total de Eventos: {_listaCompletaDeEventos.Count}";

            //Encontramos el próximo evento, luego, los ordenamos por fecha para encontrar el más cercano
            var proximoEvento = _listaCompletaDeEventos
                                .Where(e => e.FechaHora >= DateTime.Now)
                                .OrderBy(e => e.FechaHora)
                                .FirstOrDefault();

            //Actualizamos el label del próximo evento
            if (proximoEvento != null)
            {
                lblProximoEvento.Text = $"Próximo Evento: {proximoEvento.Nombre} ({proximoEvento.Fecha.ToShortDateString()})";
            }
            else
            {
                lblProximoEvento.Text = "Próximo Evento: No hay eventos futuros";
            }
        }
        #endregion







        #region Eventos del Formulario

        // Filtra la tabla automáticamente cada vez que el usuario cambia la seleccion en el ComBox

        private void comBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        //Permite modificar un evento al hacer doble clic

        private void dgv2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Nos aseguramos de que el doble clic no fue en la cabecera del dgv2
            if (e.RowIndex >= 0)
            {
                btndeModificar_Click(sender, e);
            }
        }
        private void btndeAgregar_Click(object sender, EventArgs e)
        {
            //Para agregar y modificar se utilizara un solo formulario y para agregar un evento, abriremos el formulario en blanco

            // Verificamos que el el delegado nos fue entregado
            if (AbrirFormularioHijo != null)
            {
                // Usamos el delegado para pedirle al formulario de Acceso que abra el formulario de detalle
                AbrirFormularioHijo(new FormularioDetalle());
            }

        }
        private void btndeModificar_Click(object sender, EventArgs e)
        {
            if (dgv2.SelectedRows.Count > 0 && AbrirFormularioHijo != null)
            {
                // Obtenemos el evento completo de la fila seleccionada
                EventoBase eventoSeleccionado = (EventoBase)dgv2.SelectedRows[0].DataBoundItem;
                var frmDetalle = new FormularioDetalle(eventoSeleccionado);


                // Abrimos el mismo formulario, pero esta vez le pasamos el evento para que se cargue en modo "Modificar"
                AbrirFormularioHijo(new FormularioDetalle(eventoSeleccionado));
                
            }
            else if (dgv2.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un evento para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (dgv2.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione el evento que desea eliminar.", "Selección Requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            EventoBase eventoAEliminar = (EventoBase)dgv2.SelectedRows[0].DataBoundItem;
            string msg = $"¿Está seguro de que desea eliminar el evento '{eventoAEliminar.Nombre}'?";
            if (MessageBox.Show(msg, "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    _eventosManager.EliminarEvento(eventoAEliminar.Id);
                    CargarEventos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion


    }
}
