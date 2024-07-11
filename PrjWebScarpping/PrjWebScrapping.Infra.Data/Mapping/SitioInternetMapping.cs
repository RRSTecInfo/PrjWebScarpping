using PrjWebScrapping.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace PrjWebScrapping.Infra.Data.Mapping
{
    public class SitioInternetMapping : IEntityTypeConfiguration<SitioInternet>
    {
        public void Configure(EntityTypeBuilder<SitioInternet> builder)
        {
            builder.ToTable("SitioInternet");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Nome)
                .HasConversion(prop => prop.ToString(), prop => prop)
                .IsRequired()
                .HasColumnName("Name")
                .HasColumnType("varchar(100)");

            builder.Property(prop => prop.Descricao)
               .HasConversion(prop => prop.ToString(), prop => prop)
               .IsRequired()
               .HasColumnName("Email")
               .HasColumnType("varchar(300)");

            builder.Property(prop => prop.EnderecoInternet)
                .HasConversion(prop => prop.ToString(), prop => prop)
                .IsRequired()
                .HasColumnName("EnderecoInternet")
               .HasColumnType("varchar(2000)");
        }
    }
}
