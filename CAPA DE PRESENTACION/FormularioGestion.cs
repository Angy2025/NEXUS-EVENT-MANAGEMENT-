using CAPA_DE_NEGOCIOS;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CAPA_DE_PRESENTACION
{
    // TODO Requisito: Creación y uso de clases
    public partial class FormularioGestion : Form
    {
        #region Asignar delegacion, propiedades y campos

        // Este delegado permite la comunicación entre formularios, cumpliendo el requisito de interacción
        public Action<Form> AbrirFormularioHijo { get; set; }

        // Instancia de la capa de negocios para gestionar la lógica de los eventos
        private readonly CN_EventosManager _eventosManager = new CN_EventosManager();

        // Instancia de la clase de estadisticas para la lógica de estadísticas
        private readonly EstadisticaGestion _gestionarestadistica = new EstadisticaGestion();

        // TODO Requisito: Uso de listas para almacenamiento temporal
        // Almacena la lista completa de eventos para no tener que consultar la BD repetidamente
        private List<EventoBase> _listaCompletaDeEventos;

        #endregion


        #region Constructor y Carga

        // TODO Requisito: Creación y uso de constructores
        // Constructor del formulario. Se ejecuta al crear una instancia de esta clase
        public FormularioGestion()
        {
            InitializeComponent();
        }

        // Este evento se dispara una sola vez, cuando el formulario se carga por primera vez
        private void frmGestionEventos_Load(object sender, EventArgs e)
        {
            try
            {
                // Primero definimos las columnas que queremos ver en el DataGridView
                DefinirColumnasDGV2();

                // Luego, aplicamos el estilo visual a la tabla
                ConfigurarDGV();

                // Finalmente, cargamos los datos desde la base de datos
                CargarEventos();
            }
            catch (Exception ex)
            {
                // Manejo de errores por si algo falla durante la carga inicial
                MessageBox.Show($"Error al iniciar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Configuración y Lógica de Datos

        // Este método configura manualmente las columnas del DataGridView
        private void DefinirColumnasDGV2()
        {
            dgv2.Columns.Clear();
            dgv2.AutoGenerateColumns = false; // Le decimos al dgv2 que no cree columnas por su cuenta

            // Creamos cada columna que queremos mostrar, enlazándola a una propiedad de la clase EventoBase
            dgv2.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "ID", DataPropertyName = "Id", Name = "Id", FillWeight = 8 });
            dgv2.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Nombre del Evento", DataPropertyName = "Nombre", Name = "Nombre", FillWeight = 30 });
            dgv2.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Lugar", DataPropertyName = "Lugar", Name = "Lugar", FillWeight = 22 });
            dgv2.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Fecha y Hora", DataPropertyName = "FechaHora", Name = "FechaHora", FillWeight = 20 });
            dgv2.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Tipo", DataPropertyName = "Categoria", Name = "Categoria", FillWeight = 10 });
            dgv2.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Capacidad", DataPropertyName = "Capacidad", Name = "Capacidad", FillWeight = 10 });

            // Creamos la columna Estatus, pero la dejamos invisible en este formulario
            dgv2.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Estatus", DataPropertyName = "Estatus", Name = "Estatus", Visible = false });
        }

        // Aplica un estilo visual consistente a la tabla
        private void ConfigurarDGV()
        {
            dgv2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv2.MultiSelect = false;
            dgv2.RowHeadersVisible = false;
            dgv2.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgv2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv2.DefaultCellStyle.BackColor = Color.White;
            dgv2.DefaultCellStyle.ForeColor = Color.Black;
            dgv2.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
        }

        // TODO Requisito: Conexión a datos (sql server)
        // Este método se conecta a la base de datos (a través de la capa de negocios) y carga los eventos
        private void CargarEventos()
        {
            try
            {
                // Llama a la capa de negocios para obtener la lista de eventos
                _listaCompletaDeEventos = _eventosManager.ObtainAllEvents();
                // Asigna la lista de datos a la tabla para que se muestren
                dgv2.DataSource = null;
                dgv2.DataSource = _listaCompletaDeEventos;
                // Actualiza las etiquetas con las estadísticas
                ActualizarEstadisticas();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se pudieron cargar los eventos: {ex.Message}", "Error de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // TODO Requisito: Creación y uso de metodos normales
        // Este es un método normal que calcula y muestra las estadísticas
        private void ActualizarEstadisticas()
        {
            if (_listaCompletaDeEventos == null) return;

            // El formulario no calcula, solo pide los datos del metodo de la capa de negocios
            lblTotalEventos.Text = $"Total de Eventos: {_listaCompletaDeEventos.Count}";

            // Llamamos a nuestro nuevo método en la capa de negocios
            var proximoEvento = _gestionarestadistica.ObtenerProximoEvento(_listaCompletaDeEventos);

            // El formulario solo se encarga de mostrar el resultado
            lblProximoEvento.Text = proximoEvento != null
                ? $"Próximo Evento: {proximoEvento.Nombre} ({proximoEvento.FechaHora.ToShortDateString()})"
                : "Próximo Evento: No hay eventos futuros";
        }

        #endregion


        #region Eventos del Formulario

        // Permite modificar un evento al hacer doble clic en una fila
        private void dgv2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Se asegura de que el doble clic fue en una fila válida
            if (e.RowIndex >= 0) btndeModificar_Click(sender, e);
        }

        // Se ejecuta al hacer clic en el botón Agregar Evento
        private void btndeAgregar_Click(object sender, EventArgs e)
        {
            // Para agregar y modificar se utilizara un solo formulario y para agregar un evento, abriremos el formulario en blanco

            // Verificamos que el delegado nos fue entregado para poder abrir el formulario hijo
            if (AbrirFormularioHijo != null)
            {
                // TODO Requisito: Crear minimo 3 formularios con interacción entre ellos
                // Aquí se crea la interacción entre FormularioGestion y FormularioDetalle
                var frmDetalle = new FormularioDetalle();

                // Se suscribe el método 'FrmDetalle_FormClosed' al evento 'FormClosed' del formulario de detalle
                frmDetalle.FormClosed += FrmDetalle_FormClosed;

                // Usa el delegado para abrir el formulario de detalle en el panel principal
                AbrirFormularioHijo(frmDetalle);
            }
        }

        // Se ejecuta al hacer clic en el botón Modificar Evento
        private void btndeModificar_Click(object sender, EventArgs e)
        {
            // TODO Requisito: Validaciones en los campos de entrada (en este caso, la selección)
            if (dgv2.SelectedRows.Count > 0)
            {
                // Obtenemos el objeto completo de la fila seleccionada
                // Aquí se demuestra el uso de la herencia, tratando el objeto como EventoBase
                EventoBase eventoSeleccionado = (EventoBase)dgv2.SelectedRows[0].DataBoundItem;
                var frmDetalle = new FormularioDetalle(eventoSeleccionado);

                // Abrimos el mismo formulario, pero esta vez le pasamos el evento para que se cargue en modo Modificar
                // También suscribimos el mismo método para refrescar los datos al cerrar
                frmDetalle.FormClosed += FrmDetalle_FormClosed;

                AbrirFormularioHijo(frmDetalle);
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un evento para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Se ejecuta al hacer clic en el botón Eliminar Evento
        private void btneliminar_Click(object sender, EventArgs e)
        {
            // Verificar que hay una fila seleccionada
            if (dgv2.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione el evento que desea eliminar.", "Selección Requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener el objeto completo de la fila seleccionada
            EventoBase eventoAEliminar = (EventoBase)dgv2.SelectedRows[0].DataBoundItem;

            // Pedir confirmación al usuario, mostrando el nombre del evento
            string msg = $"¿Está seguro de que desea eliminar permanentemente el evento '{eventoAEliminar.Nombre}'?";
            if (MessageBox.Show(msg, "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    // Llamar al método de la capa de negocios con el ID del objeto
                    _eventosManager.EliminarEvento(eventoAEliminar.Id);
                    // Refrescar la tabla para que el evento eliminado desaparezca
                    CargarEventos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar el evento: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Este es un método normal que maneja el evento 'FormClosed' del formulario de detalle
        // Se llama cuando el usuario guarda o cancela una modificación
        private void FrmDetalle_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Su única responsabilidad es recargar los eventos para que la tabla se actualice
            CargarEventos();
        }

        #endregion
    }
}
