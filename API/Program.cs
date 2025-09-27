using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using BLL;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//builder.Services.AddDbContext<old_DBContext>(options => options.UseSqlServer(Dg_Getway.PmsCon
//    //, b => b.MigrationsAssembly("DAL")
//    ));

//school DB er - direct context k call kore
//builder.Services.AddDbContext<dg_sms_DBContext>(options =>
//    options.UseSqlServer(
//        builder.Configuration.GetConnectionString("SchoolConnection")
//        ,b => b.MigrationsAssembly("DAL")
//    )
//);

//Specfo DB er - direct context k call kore
//builder.Services.AddDbContext<specfo_DBContext>(options =>
//    options.UseSqlServer(
//        builder.Configuration.GetConnectionString("SpecfoConnection")
//        ,b => b.MigrationsAssembly("DAL")
//    )
//);

//school DB er - indirectly BLL diye DAL and DAL er repo call kora
builder.Services.AddBLL(builder.Configuration);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//builder.Services.AddTransient<IGlobalMaster, GlobalMaster>();//new error
//builder.Services.AddTransient<Dg_SqlCommon>(); --utility er
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options =>
{
    options.RequireHttpsMetadata = false;
    options.SaveToken = true;
    options.TokenValidationParameters = new TokenValidationParameters()
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidAudience = builder.Configuration["Jwt:Audience"],
        ValidIssuer = builder.Configuration["Jwt:Issuer"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]))
    };
}).AddCookie();
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(option =>
{
    option.IdleTimeout = TimeSpan.FromDays(1);
    option.Cookie.HttpOnly = true;
    option.Cookie.IsEssential = true;
});

builder.Services.AddCors(p => p.AddPolicy("CorsPolicy", build =>
{
    build.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
}));
builder.Services.AddMvc()
     .AddNewtonsoftJson(
          options =>
          {
              options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
          });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("CorsPolicy");
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseSession();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();
app.Run();