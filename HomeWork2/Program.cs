using Animals;
using HomeWork2.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddTransient<AnimalService>();
builder.Services.AddTransient<IAnimalRepository, AnimalRepository>(provider =>
{
    return new AnimalRepository("D:\\Projects\\ASP_Net\\HomeWork_ASP.NET\\animals.json");
});
builder.Services.AddTransient<IFormatConverter, FormatConverter>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
