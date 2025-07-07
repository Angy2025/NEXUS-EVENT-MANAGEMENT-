using System;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace CAPA_DE_NEGOCIOS
{

    // Esta clase usa la biblioteca QuestPDF para crear el documento

    public class GeneradorDeReportes
    {
        private readonly EventoBase? _evento;

        public GeneradorDeReportes(EventoBase? evento)
        {
            _evento = evento;
        }

        //Este metodo genera el PDF y la devuelve como un array de bytes
        public byte[] GenerarPDF()
        {
            // Se define la estructura del documento
            var document = Document.Create(container =>
            {
                container.Page(page =>
                {
                    // Configuración de la página
                    page.Size(PageSizes.A4);
                    page.Margin(2, Unit.Centimetre);
                    page.PageColor(Colors.White);
                    page.DefaultTextStyle(x => x.FontSize(12));

                    // Encabezado del reporte
                    page.Header()
                        .AlignCenter()
                        .Text("REPORTE DE EVENTO - NEXUS EVENT MANAGEMENT")
                        .SemiBold().FontSize(16).FontColor(Colors.Grey.Darken2);

                    // Contenido principal
                    page.Content()
                        .PaddingVertical(1, Unit.Centimetre)
                        .Column(col =>
                        {
                            col.Spacing(20);

                            col.Item().Text(_evento?.Nombre).Bold().FontSize(24).FontColor(Colors.Blue.Darken2);
                            col.Item().LineHorizontal(1).LineColor(Colors.Grey.Lighten1);

                            col.Item().Text(text =>
                            {
                                text.Span("Estatus: ").SemiBold();
                                text.Span(_evento?.Estatus).FontColor(Colors.Green.Darken2);
                            });

                            col.Item().Text(text =>
                            {
                                text.Span("Fecha y Hora: ").SemiBold();
                                text.Span($"{_evento?.FechaHora:dddd, dd 'de' MMMM 'de' yyyy, hh:mm tt}");
                            });

                            col.Item().Text(text =>
                            {
                                text.Span("Lugar: ").SemiBold();
                                text.Span(_evento?.Lugar);
                            });

                            col.Item().Text(text =>
                            {
                                text.Span("Tipo de Evento: ").SemiBold();
                                text.Span(_evento?.Tipo);
                            });

                            col.Item().Text(text =>
                            {
                                text.Span("Capacidad Máxima: ").SemiBold();
                                text.Span($"{_evento?.Capacidad} personas");
                            });

                            //TODO Requisito: AQUÍ USAMOS LOS MÉTODOS VIRTUAL Y ABSTRACTO
                            col.Item().PaddingTop(20).Text("Detalles Adicionales").Bold().Underline();
                            col.Item().Text(text =>
                            {
                                text.Span("Lema del Evento: ").SemiBold();
                                text.Span(_evento?.ObtenerLema()).Italic(); // Resultado del método virtual
                            });
                            col.Item().Text(text =>
                            {
                                text.Span("Patrocinador Principal: ").SemiBold();
                                text.Span(_evento?.MiPatrocinadorFav()).Italic(); // Resultado del método abstracto
                            });
                        });

                    // Pie de página
                    page.Footer()
                        .AlignCenter()
                        .Text(x =>
                        {
                            x.Span("Página ");
                            x.CurrentPageNumber();
                        });
                });
            });

            // Se genera el documento en memoria y se devuelve
            return document.GeneratePdf();
        }
    }
}
