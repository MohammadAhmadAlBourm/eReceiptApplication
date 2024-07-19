using eReceiptApplication.Contracts;
using eReceiptApplication.Services;
using Razor.Templating.Core;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddRazorTemplating();


builder.Services.AddSingleton<InvoiceFactory>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


app.MapGet("invoice-report", async (InvoiceFactory invoiceFactory) =>
{
    Invoice invoice = invoiceFactory.Create();

    var html = await RazorTemplateEngine.RenderAsync("Views/InvoiceReport.cshtml", invoice);

    var renderer = new ChromePdfRenderer();

    using var pdfDocument = renderer.RenderHtmlAsPdf(html);

    return Results.File(pdfDocument.BinaryData, "application/pdf", $"invoice-{invoice.Number}.pdf");
});


app.Run();