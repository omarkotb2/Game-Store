

var builder = WebApplication.CreateBuilder(args);


var ConnString = builder.Configuration.GetConnectionString("DefaultConnection") ??
                                        throw new InvalidOperationException("Can`t Find This connection String");
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(ConnString));


// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<ICategoriesService, CategoriesService>();
builder.Services.AddScoped<IDevicesService, DevicesService>();
builder.Services.AddScoped<IGameService, GameService>();

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
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
