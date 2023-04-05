using Microsoft.EntityFrameworkCore;
using PaymentSystem;
using PaymentSystem.Abstract.Interface;
using PaymentSystem.PaymentDbContext;
using PaymentSystem.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<PaymentSystemDbContext>(options=> options.UseSqlite(builder.Configuration.GetConnectionString("Conn")));
builder.Services.AddScoped<ITerminal,TerminalRepository>();
builder.Services.AddScoped<IMerchant,MerchantRepository>();
builder.Services.AddScoped<ITransaction,TransactionRepository>();

builder.Services.AddAutoMapper(typeof(AutomapperProfile));
builder.Services.AddCors(o =>
{
    o.AddPolicy("AllowAll", builder =>
        builder.AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader()
    );
});

var app = builder.Build();
 //Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{    app.UseSwagger();
    app.UseSwaggerUI();

}

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});


app.UseCors(x => x.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());

app.Run();
