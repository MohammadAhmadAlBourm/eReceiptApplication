using Carter;
using eReceiptApplication.Contracts;
using eReceiptApplication.Services;
using Razor.Templating.Core;

namespace eReceiptApplication.Modules.InvoiceModule;

public class Endpoints : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapGet("invoice-report", async (InvoiceFactory invoiceFactory) =>
        {
            Invoice invoice = invoiceFactory.Create();

            var html = await RazorTemplateEngine.RenderAsync("Views/InvoiceReport.cshtml", invoice);

            var renderer = new ChromePdfRenderer();

            using var pdfDocument = renderer.RenderHtmlAsPdf(html);

            return Results.File(
                pdfDocument.BinaryData,
                "application/pdf",
                $"invoice-{invoice.Number}.pdf");

        });
    }
}
