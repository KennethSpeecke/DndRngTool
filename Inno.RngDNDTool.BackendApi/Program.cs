using Inno.RngDNDTool.Core.Entities.Identity;
using Inno.RngDNDTool.Core.Infrastructure.Interfaces;
using Inno.RngDNDTool.Core.Services.Implementations;
using Inno.RngDNDTool.Core.Services.Interfaces;
using Inno.RngDNDTool.Infrastructure.Data.Contexts;
using Inno.RngDNDTool.Infrastructure.Repositories;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;

var builder = WebApplication.CreateBuilder(args);
var corsDevelopmentPolicy = "_corsDevelopmentPolicy";

// Add services to the container.

builder.Services.AddControllers()
    .AddNewtonsoftJson(opt =>
    {
        opt.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
    });
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.AddSecurityDefinition(name: "Bearer", securityScheme: new Microsoft.OpenApi.Models.OpenApiSecurityScheme
    {
        Name = "Authorization",
        Description = "Enter the beaer authorization string as following: `Bearer Generated-JWT-Token`",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer"
    });

    options.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Name = "Bearer",
                In = ParameterLocation.Header,
                Reference = new OpenApiReference
                {
                    Id = "Bearer",
                    Type = ReferenceType.SecurityScheme
                }
            },
            new List<string>()
        }
    });
});
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("Rng.Dnd.Development")));
builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddDefaultTokenProviders();

builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(options =>
{
    options.SaveToken = true;
    options.RequireHttpsMetadata = false;
    options.TokenValidationParameters = new TokenValidationParameters()
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidAudience = builder.Configuration["JWT:ValidAudience"],
        ValidIssuer = builder.Configuration["JWT:ValidIssuer"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["JWT:Secret"]))
    };
});

builder.Services.AddCors(opt =>
{
    opt.AddPolicy(name: corsDevelopmentPolicy, policy =>
    {
        policy.WithOrigins("https://localhost:3000", "http://localhost:3000").AllowAnyHeader().AllowAnyMethod();
    });
});

builder.Services.AddAutoMapper(typeof(Program));

#region Repository IOC

builder.Services.AddScoped<IWeaponRepository, WeaponRepository>();
builder.Services.AddScoped<IFoodRepository, FoodRepository>();
builder.Services.AddScoped<IScrollRepository, ScrollRepository>();
builder.Services.AddScoped<IPotionRepository, PotionRepository>();
builder.Services.AddScoped<IArmorRepository, ArmorRepository>();
builder.Services.AddScoped<ISpellRepository, SpellRepository>();
builder.Services.AddScoped<ICharacterRepository, CharacterRepository>();
builder.Services.AddScoped<IInventoryRepository, InventoryRepository>();
builder.Services.AddScoped<ICharacterClassRepository, CharacterClassRepository>();
builder.Services.AddScoped<IRaceRepository, RaceRepository>();

#endregion Repository IOC

#region Service IOC

builder.Services.AddScoped<ISpellService, SpellService>();
builder.Services.AddScoped<IArmorService, ArmorService>();
builder.Services.AddScoped<IPotionService, PotionService>();
builder.Services.AddScoped<IWeaponService, WeaponService>();
builder.Services.AddScoped<IFoodService, FoodService>();
builder.Services.AddScoped<IScrollService, ScrollService>();
builder.Services.AddScoped<ICharacterService, CharacterService>();
builder.Services.AddScoped<IInventoryService, InventoryService>();
builder.Services.AddScoped<ICharacterClassService, CharacterClassService>();
builder.Services.AddScoped<IRaceService, RaceService>();

#endregion Service IOC

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors(corsDevelopmentPolicy);

app.UseAuthorization();
app.UseAuthentication();

app.MapControllers();

app.Run();