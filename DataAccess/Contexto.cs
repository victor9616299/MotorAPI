using Microsoft.EntityFrameworkCore;
using Dominio;

namespace DataAccess;

public class Contexto : DbContext
{
    public Contexto(DbContextOptions<Contexto> options)
        : base(options)
    {
    }

    public DbSet<Motor> Motores { get; set; }
    public DbSet<Sensor> Sensores { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new MotorConfiguration());
        modelBuilder.ApplyConfiguration(new SensorConfiguration());
    }
}