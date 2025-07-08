using CAPA_DE_NEGOCIOS;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CAPA_DE_PRESENTACION
{
    public partial class FormularioGestion : Form
    {
        #region Asignar delegacion, propiedades y campos

        public Action<Form> AbrirFormularioHijo { get; set; }
        private readonly CN_EventosManager _eventosManager = new CN_EventosManager();
        private List<EventoBase> _listaCompletaDeEventos;

        #endregion


        #region Constructor y Carga

        public FormularioGestion()
        {
            InitializeComponent();
        }

        private void frmGestionEventos_Load(object sender, EventArgs e)
        {
            try
            {
                //Primero definimos las columnas que queremos ver
                DefinirColumnasDGV2();

                // Luego, aplicamos el estilo
                ConfigurarDGV();

                // Finalmente, cargamos los datos
                CargarEventos();

                btnNotificarCambios.Enabled = false; //deshabilita el boton de notificar
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al iniciar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Configuración y Lógica de Datos


        private void DefinirColumnasDGV2()
        {
            dgv2.Columns.Clear();
            dgv2.AutoGenerateColumns = false; // Le decimos a la tabla que no cree columnas por su cuenta

            // Creamos cada columna que queremos mostrar
            dgv2.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "ID", DataPropertyName = "Id", Name = "Id", FillWeight = 8 });
            dgv2.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Nombre del Evento", DataPropertyName = "Nombre", Name = "Nombre", FillWeight = 30 });
            dgv2.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Lugar", DataPropertyName = "Lugar", Name = "Lugar", FillWeight = 22 });
            dgv2.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Fecha y Hora", DataPropertyName = "FechaHora", Name = "FechaHora", FillWeight = 20 });
            dgv2.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Tipo", DataPropertyName = "Categoria", Name = "Categoria", FillWeight = 10 });
            dgv2.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Capacidad", DataPropertyName = "Capacidad", Name = "Capacidad", FillWeight = 10 });

            // Creamos la columna Estatus, pero la dejamos invisible en este formulario
            dgv2.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Estatus", DataPropertyName = "Estatus", Name = "Estatus", Visible = false });
        }

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

        private void CargarEventos()
        {
            try
            {
                _listaCompletaDeEventos = _eventosManager.ObtainAllEvents();
                dgv2.DataSource = null;
                dgv2.DataSource = _listaCompletaDeEventos;
                ActualizarEstadisticas();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se pudieron cargar los eventos: {ex.Message}", "Error de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarEstadisticas()
        {
            if (_listaCompletaDeEventos == null) return;
            lblTotalEventos.Text = $"Total de Eventos: {_listaCompletaDeEventos.Count}";
            var proximoEvento = _listaCompletaDeEventos
                                .Where(e => e.FechaHora >= DateTime.Now)
                                .OrderBy(e => e.FechaHora)
                                .FirstOrDefault();
            lblProximoEvento.Text = proximoEvento != null
                ? $"Próximo Evento: {proximoEvento.Nombre} ({proximoEvento.FechaHora.ToShortDateString()})"
                : "Próximo Evento: No hay eventos futuros";
        }

        #endregion



        #region Eventos del Formulario

        //Permite modificar un evento al hacer doble clic

        private void dgv2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)

        {

            if (e.RowIndex >= 0) btndeModificar_Click(sender, e);

        }

        private void btndeAgregar_Click(object sender, EventArgs e)
        {
            //Para agregar y modificar se utilizara un solo formulario y para agregar un evento, abriremos el formulario en blanco

            // Verificamos que el el delegado nos fue entregado

            if (AbrirFormularioHijo != null)
            {
                // Usamos el delegado para pedirle al formulario de Acceso que abra el formulario de detalle y le decimos que cuando cierre debe avisarnos para refrescar

                var frmDetalle = new FormularioDetalle();

                frmDetalle.FormClosed += (s, args) =>
                {
                    CargarEventos(); // Refresca la tabla
                    btnNotificarCambios.Enabled = true; // Habilita el botón de notificar
                };

                AbrirFormularioHijo(frmDetalle);
            }
        }
        private void btndeModificar_Click(object sender, EventArgs e)
        {
            if (dgv2.SelectedRows.Count > 0)
            {
                // Obtenemos el evento completo de la fila seleccionada

                EventoBase eventoSeleccionado = (EventoBase)dgv2.SelectedRows[0].DataBoundItem;
                var frmDetalle = new FormularioDetalle(eventoSeleccionado);

                // Abrimos el mismo formulario, pero esta vez le pasamos el evento para que se cargue en modo "Modificar"

                frmDetalle.FormClosed += (s, args) =>
                {
                    CargarEventos();
                    btnNotificarCambios.Enabled = true;
                };

                AbrirFormularioHijo(frmDetalle);

            }

            else if (dgv2.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un evento para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            //Verificar que hay una fila seleccionada.

            if (dgv2.SelectedRows.Count == 0)

            {

                MessageBox.Show("Por favor, seleccione el evento que desea eliminar.", "Selección Requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }



            //Obtener el objeto completo de la fila seleccionada

            EventoBase eventoAEliminar = (EventoBase)dgv2.SelectedRows[0].DataBoundItem;

            //Pedir confirmación al usuario, mostrando el nombre del evento

            string msg = $"¿Está seguro de que desea eliminar permanentemente el evento '{eventoAEliminar.Nombre}'?";

            if (MessageBox.Show(msg, "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

            {

                try

                {

                    //Llamar al método de la capa de negocios con el ID del objeto

                    _eventosManager.EliminarEvento(eventoAEliminar.Id);

                    CargarEventos();

                }

                catch (Exception ex)

                {

                    MessageBox.Show($"Error al eliminar el evento: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }

        }

        #endregion

        private void btnNotificarCambios_Click(object sender, EventArgs e)
        {
            string mensaje = "Los cambios recientes en los eventos han sido notificados a todos los departamentos.";
            MessageBox.Show(mensaje, "Notificación de Cambios Enviada", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Se deshabilita a sí mismo después de notificar
            btnNotificarCambios.Enabled = false;
        }
    }

}
    

