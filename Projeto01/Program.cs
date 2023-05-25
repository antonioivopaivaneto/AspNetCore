using Projeto01.Services;

var builder = WebApplication.CreateBuilder(args);

//adicionarservicos de DI para a interface IListasServices
builder.Services.AddSingleton<IListasService, ListasServices>();
builder.Services.AddScoped<IContatoService, ContatosService>();


// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Exemplos}/{action=Index}/{id?}");


app.Run();
