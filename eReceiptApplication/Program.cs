using Carter;
using eReceiptApplication.Services;

var builder = WebApplication.CreateBuilder(args);


License.LicenseKey = builder.Configuration["IronPdf:LicenseKey"];

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddRazorTemplating();

builder.Services.AddCarter();


builder.Services.AddSingleton<InvoiceFactory>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapCarter();
app.Run();