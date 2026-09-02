using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Dominio;

namespace DataAccess;

public class SensorConfiguration : IEntityTypeConfiguration<Sensor>
{
    public void Configure(EntityTypeBuilder<Sensor> builder)
    {
        builder.ToTable("Sensores");
        builder.HasKey(sensor => sensor.IdSensor);
        builder.Property(sensor => sensor.IdSensor);
        builder.Property(sensor => sensor.NomeSensor);
    }
}