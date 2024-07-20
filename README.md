# eReceiptApplication

## Overview
eReceiptApplication is a web application developed using ASP.NET Core Web API v8 with Minimal API architecture. The application is organized into modules using the Carter NuGet Package. The primary purpose of this application is to generate PDF invoices by converting Razor views to HTML and then transforming the HTML to PDF.

## Features
- **Minimal API with ASP.NET Core Web API v8**: Lightweight and efficient API structure.
- **Carter NuGet Package**: Organizes the API into modules for better maintainability.
- **PDF Invoice Generation**: Creates PDF invoices from Razor views.
- **HTML to PDF Conversion**: Utilizes the RazorTemplateEngine for converting Razor views to HTML and the IronPdf NuGet Package for converting HTML to PDF.

## Technologies Used
- **ASP.NET Core Web API v8**
- **Minimal API**
- **Carter NuGet Package**
- **Razor.Templating.Core NuGet Package**
- **IronPdf NuGet Package**

## Getting Started

### Prerequisites
- .NET SDK 8.0 or later
- Visual Studio or any other C# compatible IDE

### Installation
1. Clone the repository:
   ```bash
   git clone https://github.com/MohammadAhmadAlBourm/eReceiptApplication.git
   ```
2. Navigate to the project directory:
   ```bash
   cd eReceiptApplication
   ```
3. Restore the required packages:
   ```bash
   dotnet restore
   ```

### Running the Application
1. Build the application:
   ```bash
   dotnet build
   ```
2. Run the application:
   ```bash
   dotnet run
   ```

### Using the API
The API provides endpoints for generating PDF invoices. Here’s a basic example of how to use the API:

1. To create a PDF invoice, send a Get request to `/api/invoice-report`.
2. The API will convert the Razor view data to HTML and then to a PDF, returning the PDF file as a response.



## License
This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for more details.

## Contributing
Contributions are welcome! Please fork this repository and submit pull requests.

## Contact
For any inquiries or issues, please contact mohammadbourm@gmail.com.

## Support
If you find this project helpful and want to support its development, consider buying me a coffee:

<a href="https://www.buymeacoffee.com/mohammadbourm" target="_blank">
  <img 
    src="https://cdn.buymeacoffee.com/buttons/v2/default-yellow.png" 
    alt="Buy Me A Coffee" style="height: 60px !important;width: 217px !important;" >
</a>
