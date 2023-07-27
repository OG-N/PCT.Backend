using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using PCT.Backend.Repository;
using PCT.Backend.Services;
using PCT.Backend;
using PCT.Backened.Repository;
using PCT.Backened.Services;

var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
string[] _allowedOrigins;

var builder = WebApplication.CreateBuilder(args);
builder.Configuration
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
    .AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json", optional: true)
    .AddEnvironmentVariables();
builder.Services.AddDbContext<DataContext>(options => options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));
AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);


// Add services to the container.
builder.Services.AddScoped(typeof(Repository<>));

builder.Services.AddScoped(typeof(ProductRepository));
builder.Services.AddScoped(typeof(OptionRouteRepository));
builder.Services.AddScoped(typeof(RoleOptionRepository));
builder.Services.AddScoped(typeof(RoleRepository));
builder.Services.AddScoped(typeof(UserRepository));
builder.Services.AddScoped(typeof(UserRoleRepository));
builder.Services.AddScoped(typeof(ProductService));
builder.Services.AddScoped(typeof(CategoryRepository));
builder.Services.AddScoped(typeof(CategoryService));
builder.Services.AddScoped(typeof(UnitRepository));
builder.Services.AddScoped(typeof(UnitService));
builder.Services.AddScoped(typeof(CarrierRepository));
builder.Services.AddScoped(typeof(CarrierService));
builder.Services.AddScoped(typeof(LocationRepository));
builder.Services.AddScoped(typeof(LocationService));
builder.Services.AddScoped(typeof(VendorRepository));
builder.Services.AddScoped(typeof(VendorService));
builder.Services.AddScoped(typeof(OptionRouteService));
builder.Services.AddScoped(typeof(RoleOptionService));
builder.Services.AddScoped(typeof(RoleService));
builder.Services.AddScoped(typeof(UserRoleService));
builder.Services.AddScoped(typeof(UserService));

builder.Services.AddScoped(typeof(CMSContentImpactRepository));
builder.Services.AddScoped(typeof(CMSContentLeadershipRepository));
builder.Services.AddScoped(typeof(CMSContentPageItemRepository));
builder.Services.AddScoped(typeof(CMSContentPageRepository));
builder.Services.AddScoped(typeof(CMSContentPageSectionRepository));
builder.Services.AddScoped(typeof(CMSContentRolesRepository));
builder.Services.AddScoped(typeof(CMSContentImpactService));
builder.Services.AddScoped(typeof(CMSContentLeadershipService));
builder.Services.AddScoped(typeof(CMSContentPageItemService));
builder.Services.AddScoped(typeof(CMSContentPageService));
builder.Services.AddScoped(typeof(CMSContentPageSectionService));
builder.Services.AddScoped(typeof(CMSContentRolesService));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();
builder.Services.AddSwaggerGen(c =>
{
    c.EnableAnnotations();
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "PCT API", Version = "v1" });
});
_allowedOrigins = builder.Configuration.GetSection("AllowedOrigins").Get<string[]>();
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins, policy =>
    {
        policy.WithOrigins(_allowedOrigins).AllowAnyHeader().AllowAnyMethod();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors(MyAllowSpecificOrigins);
app.UseAuthorization();
app.UseCors(MyAllowSpecificOrigins);
app.MapControllers();

EnsureMigration.EnsureMigrationOfContext<DataContext>(app);

app.Run();
