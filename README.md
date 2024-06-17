# PDF Generator

Esta es una aplicación ASP.NET Core que genera archivos PDF para productos. Utiliza la biblioteca [QuestPDF](https://www.questpdf.com/) para la generación de PDFs.

## Características

- Listado de productos
- Generación de archivos PDF con los detalles de los productos

## Tecnologías utilizadas

- ASP.NET Core
- QuestPDF
- Bootstrap (para el diseño de la vista)

## Requisitos previos

- .NET 6 SDK o superior
- Visual Studio 2022 o Visual Studio Code

## Instalación

1. Clona el repositorio

    ```bash
    git clone [https://github.com/tu-usuario/PDF_Generator.git](https://github.com/InfoToolsSV/ASP.NET_CORE_MVC_QuestPDF.git)
    ```

2. Navega al directorio del proyecto

    ```bash
    cd NET_CORE_MVC_QuestPDF
    ```

3. Restaura los paquetes NuGet

    ```bash
    dotnet restore
    ```

## Ejecución

1. Compila y ejecuta la aplicación

    ```bash
    dotnet run
    ```

2. Abre tu navegador y navega a `https://localhost:5001` para ver la aplicación en funcionamiento.

## Estructura del proyecto

- `Controllers/PdfController.cs`: Controlador que maneja las vistas y la generación de PDFs.
- `Data/IPdfService.cs`: Interfaz para el servicio de generación de PDFs.
- `Data/PdfService.cs`: Implementación del servicio de generación de PDFs utilizando QuestPDF.
- `Models/ProductViewModel.cs`: Modelo de vista para los productos.
- `Views/Pdf/Index.cshtml`: Vista que muestra la lista de productos.
