using PDF_Generator.Models;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace PDF_Generator.Data
{
    public class PdfService : IPdfService
    {
        public byte[] GenerarProductoPDF(ProductViewModel productViewModel)
        {
            var documento = Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Margin(2, Unit.Centimetre);
                    

                    page.Header()
                        .Text("Detalles del producto")
                        .SemiBold().FontSize(20).FontColor(Colors.Blue.Medium);

                    page.Content()
                        .PaddingVertical(1, Unit.Centimetre)
                        .Column(x =>
                        {
                            x.Spacing(10);

                            x.Item().Text($"Nombre: {productViewModel.Nombre}").FontSize(16).Bold();
                            x.Item().Text($"Descripcion: ").FontSize(14).Bold();
                            x.Item().Text(productViewModel.Descripcion).FontSize(12).LineHeight(1.2f);
                            x.Item().Text($"Precio: {productViewModel.Precio}").FontSize(14).Bold();
                            x.Item().Text($"Cantidad: {productViewModel.Stock}").FontSize(14).Bold();
                            x.Item().Text($"Categoria: {productViewModel.Categoria}").FontSize(14).Bold();
                            
                        });

                    page.Footer()
                        .AlignCenter()
                        .Text(x =>
                        {
                            x.Span("Page ");
                            x.CurrentPageNumber();
                        });
                });
            });

            using var stream = new MemoryStream();
            documento.GeneratePdf(stream);
            return stream.ToArray();
        }
    }
}