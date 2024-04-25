 
using BlazorApp1.CarModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlazorApp1.Data.Mapping
{
    public class LogMap : IEntityTypeConfiguration<Log>
    {
        public void Configure(EntityTypeBuilder<Log> builder)
        {

            builder.ToTable("Log");

            builder.HasKey(e => e.Id);

            builder.ToTable("Log");

            builder.Property(e => e.Id);
            builder.Property(e => e.Message).HasMaxLength(255);
            builder.Property(e => e.Time)
            
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
                
        }
    }

    
}

