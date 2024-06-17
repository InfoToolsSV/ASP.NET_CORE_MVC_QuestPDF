using PDF_Generator.Models;

namespace PDF_Generator.Data
{
    public interface IPdfService
    {
        byte[] GenerarProductoPDF(ProductViewModel productViewModel);
    }
}