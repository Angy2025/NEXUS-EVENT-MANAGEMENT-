using CAPA_DE_NEGOCIOS;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System;

namespace CAPA_DE_NEGOCIOS
{
    /// <summary>
    /// Utiliza la biblioteca QuestPDF para crear un reporte de evento en formato PDF.
    /// </summary>
    public class GeneradorDeReportes
    {
        private readonly EventoBase _evento;

        public GeneradorDeReportes(EventoBase evento)
        {
            _evento = evento ?? throw new ArgumentNullException(nameof(evento));
            // Configura la licencia de QuestPDF. La de Comunidad es gratuita para proyectos de código abierto y startups.
            QuestPDF.Settings.License = LicenseType.Community;
        }

        /// <summary>
        /// Genera el documento PDF y lo devuelve como un array de bytes.
        /// </summary>
        /// <returns>Un array de bytes que representa el archivo PDF.</returns>
        public byte[] GenerarPDF()
        {
            return Document.Create(container =>
            {
                container.Page(page =>
                {
                    // 1. Configuración de la Página
                    page.Size(PageSizes.A4);
                    page.Margin(2, Unit.Centimetre);
                    page.PageColor(Colors.White);
                    page.DefaultTextStyle(x => x.FontSize(12).FontFamily("Times New Roman"));

                    // 2. Encabezado del Reporte
                    page.Header()
                        .AlignCenter()
                        .Text("REPORTE DE EVENTO - NEXUS EVENT MANAGEMENT")
                        .SemiBold().FontSize(16).FontColor(Colors.Grey.Darken3);

                    // 3. Contenido Principal
                    page.Content()
                        .PaddingVertical(1, Unit.Centimetre)
                        .Column(col =>
                        {
                            col.Spacing(15); // Espacio entre elementos

                            // Título del evento
                            col.Item().Text(_evento.Nombre).Bold().FontSize(24).FontColor(Colors.Blue.Darken4);
                            col.Item().LineHorizontal(1).LineColor(Colors.Grey.Lighten1);

                            // Tabla con detalles principales
                            col.Item().Table(table =>
                            {
                                table.ColumnsDefinition(columns =>
                                {
                                    columns.ConstantColumn(120); // Ancho para etiquetas
                                    columns.RelativeColumn();    // Ancho para valores
                                });

                                // Función para crear filas de la tabla de forma consistente
                                Action<string, string, string> AddRow = (label, value, color) =>
                                {
                                    table.Cell().BorderBottom(0.5f).BorderColor(Colors.Grey.Lighten2).Padding(5).Text(label).SemiBold();
                                    table.Cell().BorderBottom(0.5f).BorderColor(Colors.Grey.Lighten2).Padding(5).Text(value).FontColor(color);
                                };

                                AddRow("Estatus:", _evento.Estatus, Colors.Green.Darken2);
                                AddRow("Fecha y Hora:", $"{_evento.FechaHora:dddd, dd 'de' MMMM 'de' yyyy, hh:mm tt}", Colors.Black);
                                AddRow("Lugar:", _evento.Lugar, Colors.Black);
                                AddRow("Categoría:", _evento.Categoria, Colors.Black); // Usando Categoria de la BD
                                AddRow("Capacidad Máxima:", $"{_evento.Capacidad} personas", Colors.Black);
                            });

                            // Sección de Detalles Adicionales
                            col.Item().PaddingTop(1, Unit.Centimetre).Text("Detalles Adicionales").Bold().FontSize(14).Underline();
                            col.Item().Text(text =>
                            {
                                text.Span("Lema del Evento: ").SemiBold();
                                text.Span($"\"{_evento.ObtenerLema()}\"").Italic();
                            });
                            col.Item().Text(text =>
                            {
                                text.Span("Patrocinador Principal: ").SemiBold();
                                text.Span(_evento.MiPatrocinadorFav()).Italic();
                            });
                        });

                    // 4. Pie de página
                    page.Footer()
                        .AlignCenter()
                        .Text(x =>
                        {
                            x.Span("Página ");
                            x.CurrentPageNumber();
                            x.Span(" de ");
                            x.TotalPages();
                        });
                });
            }).GeneratePdf();
        }
    }
}
