using Microsoft.AspNetCore.Mvc;
using PDF_Generator.Data;
using PDF_Generator.Models;

namespace PDF_Generator.Controllers
{
    public class PdfController : Controller
    {
        private readonly IPdfService _pdfService;

        public PdfController(IPdfService pdfService)
        {
            _pdfService = pdfService;
        }

        public IActionResult Index()
        {
            var viewModel = ObtenerProductos();
            return View(viewModel);
        }

        public IActionResult DescargarPdf(int id)
        {
            var producto = ObtenerProductos().Find(p => p.Id == id);

            if (producto == null)
                return NotFound();

            var pdfBytes = _pdfService.GenerarProductoPDF(producto);

            return File(pdfBytes, "application/pdf", $"{producto.Nombre}.pdf");
        }

        public static List<ProductViewModel> ObtenerProductos()
        {
            return
            [
                new ProductViewModel
                {
                    Id = 1,
                    Nombre = "Producto 1",
                    Descripcion = "Esta es la descripcion del producto 1",
                    Precio = 20.99m,
                    Stock = 100,
                    Categoria = "Categoria 1",
                },
                new ProductViewModel
                {
                    Id = 2,
                    Nombre = "Producto 2",
                    Descripcion = "Esta es la descripcion del producto 2",
                    Precio = 20.99m,
                    Stock = 120,
                    Categoria = "Categoria 2",
                },
                new ProductViewModel
                {
                    Id = 3,
                    Nombre = "Producto 3",
                    Descripcion = "Esta es la descripcion del producto 3",
                    Precio = 20.99m,
                    Stock = 10,
                    Categoria = "Categoria 3",
                }
            ];
        }
    }
}