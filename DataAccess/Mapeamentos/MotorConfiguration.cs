using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Dominio;

namespace DataAccess;

public class MotorConfiguration : IEntityTypeConfiguration<Motor>
{
    public void Configure(EntityTypeBuilder<Motor> builder)
    {
        builder.ToTable("Motores");

        builder.HasKey(motor => motor.IdMotor);

        builder.Property(motor => motor.IdMotor);
        builder.Property(motor => motor.NomeMotor);
        builder.Property(motor => motor.Estado);
        builder.Property(motor => motor.Rotacao);
        builder.Property(motor => motor.DataCadastro);
    }
}