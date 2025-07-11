using CAPA_DE_NEGOCIOS;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System;
using System.Diagnostics; // Necesario para Debug.WriteLine

namespace CAPA_DE_NEGOCIOS
{
    public class GeneradorDeReportes
    {
        #region Campos y Constructor

        // Almacena una referencia privada al objeto del evento sobre el que se generará el reporte
        private readonly EventoBase _evento;

        // El constructor recibe el objeto del evento para trabajar con él
        public GeneradorDeReportes(EventoBase evento)
        {
            // Se asegura de que el evento no sea nulo para evitar errores. Si lo es, lanza una excepción clara
            _evento = evento ?? throw new ArgumentNullException(nameof(evento));

            // Configura la licencia de QuestPDF, es importante establecerla una vez para que la librería funcione correctamente
            QuestPDF.Settings.License = LicenseType.Community;
        }

        #endregion

        #region Método Principal de Generación

        // Genera el documento PDF completo y lo devuelve como un array de bytes
        public byte[] GenerarPDF()
        {
            // Envolvemos todo el proceso en un bloque try-catch
            // Esto es crucial para capturar cualquier error interno de QuestPDF
            // y evitar que la aplicación se cierre inesperadamente
            try
            {
                // El método Document.Create es el punto de partida para crear un nuevo PDF
                // Recibe una función lambda que define la estructura y contenido del documento
                return Document.Create(container =>
                {
                    // 'container' representa el documento completo
                    // Aquí definimos la página o páginas que contendrá
                    container.Page(page =>
                    {
                        // 'page' representa una página individual

                        //1. Configuración General de la Página 
                        page.Size(PageSizes.A4); // Define el tamaño del papel
                        page.Margin(2, Unit.Centimetre); // Establece un margen de 2 cm en todos los lados
                        page.PageColor("#F5F2ED"); // Un color crema muy suave (hueso) que combina con los tonos cálidos
                        page.DefaultTextStyle(x => x.FontSize(12).FontFamily("Times New Roman")); // Estilo de texto con la fuente especificada

                        //Encabezado del Reporte 
                        // Se repetirá en la parte superior de cada página
                        page.Header()
                            .AlignCenter() // Centra el contenido del encabezado
                            .Text("REPORTE DE EVENTO - NEXUS EVENT MANAGEMENT") // El texto del encabezado
                            .SemiBold().FontSize(16).FontColor(Colors.Grey.Darken3); // Estilo del texto

                        // Contenido Principal
                        // Esta es la sección principal que contendrá toda la información
                        page.Content()
                            .PaddingVertical(1, Unit.Centimetre) // Añade un espacio vertical antes y después del contenid
                            .Column(col => // Organiza los elementos en una sola columna, uno debajo del otro
                            {
                                col.Spacing(15); // Define el espacio vertical entre cada elemento de la columna

                                // Título principal del evento
                                col.Item().Text(_evento.Nombre).Bold().FontSize(24).FontColor(Colors.Black);
                                // Línea horizontal decorativa debajo del título
                                col.Item().LineHorizontal(1).LineColor(Colors.Grey.Lighten1);

                                // Tabla para mostrar los detalles de forma ordenada
                                col.Item().Table(table =>
                                {
                                    // Define la estructura de las columnas de la tabla
                                    table.ColumnsDefinition(columns =>
                                    {
                                        columns.ConstantColumn(120); // Columna para las etiquetas con un ancho fijo
                                        columns.RelativeColumn();    // Columna para los valores, que ocupa el espacio restante
                                    });

                                    // Función local para añadir filas a la tabla de manera consistente y evitar repetir código
                                    Action<string, string, string> AddRow = (label, value, color) =>
                                    {
                                        table.Cell().BorderBottom(0.5f).BorderColor(Colors.Grey.Lighten2).Padding(5).Text(label).SemiBold();
                                        table.Cell().BorderBottom(0.5f).BorderColor(Colors.Grey.Lighten2).Padding(5).Text(value).FontColor(color);
                                    };

                                    // Añade las filas con los datos del evento
                                    AddRow("Estatus:", _evento.Estatus, Colors.Green.Darken2);
                                    AddRow("Fecha y Hora:", $"{_evento.FechaHora:dddd, dd 'de' MMMM 'de' yyyy, hh:mm tt}", Colors.Black);
                                    AddRow("Lugar:", _evento.Lugar, Colors.Black);
                                    AddRow("Categoría:", _evento.Categoria, Colors.Black);
                                    AddRow("Capacidad Máxima:", $"{_evento.Capacidad} personas", Colors.Black);
                                });

                                // Sección para los detalles polimórficos (lema y patrocinador)
                                col.Item().PaddingTop(1, Unit.Centimetre).Text("Detalles Adicionales").Bold().FontSize(14).Underline();
                                col.Item().Text(text =>
                                {
                                    text.Span("Lema del Evento: ").SemiBold();
                                    // Llama al método virtual. C# ejecutará la versión correcta (la de la clase base o la de la clase hija)
                                    text.Span($"\"{_evento.ObtenerLema()}\"").Italic();
                                });
                                col.Item().Text(text =>
                                {
                                    text.Span("Patrocinador Principal: ").SemiBold();
                                    // Llama al método abstracto. C# ejecutará la implementación obligatoria de la clase hija
                                    text.Span(_evento.MiPatrocinadorFav()).Italic();
                                });
                            });

                        //Pie de página
                        // Se repetirá en la parte inferior de cada página
                        page.Footer()
                            .AlignCenter() // Centra el contenido
                            .Text(x => // Permite construir texto con diferentes partes
                            {
                                x.Span("Página ");
                                x.CurrentPageNumber(); // Inserta el número de la página actual
                                x.Span(" de ");
                                x.TotalPages(); // Inserta el número total de páginas
                            });
                    });
                }).GeneratePdf(); // Finalmente, genera el PDF y lo convierte a un array de bytes
            }
            catch (Exception ex)
            {
                // Si ocurre cualquier error durante la generación, lo escribimos en la ventana de Salida de Visual Studio
                Debug.WriteLine($"Error al generar el PDF con QuestPDF: {ex.ToString()}");

                // Devolvemos un array vacío para indicar que la generación falló
                // El FormVisorPDF recibirá esto y no intentará cargar un documento corrupto
                return new byte[0];
            }
        }

        #endregion
    }
}