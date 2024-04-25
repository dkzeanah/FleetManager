using BlazorApp1.CarModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlazorApp1.Mapping
{
    public class LoggerMap : IEntityTypeConfiguration<Logger>
    {
        public void Configure(EntityTypeBuilder<Logger> builder)
        {

            builder.ToTable("Logger");

            builder.HasKey(e => e.Id);
            builder.HasData(
           new Logger { Id = 1, TypeLogger = Logger.LoggerType.BluePirate, NumLoggers = 1 },
           new Logger { Id = 2, TypeLogger = Logger.LoggerType.BluePirate, NumLoggers = 1 },
           new Logger { Id = 3, TypeLogger = Logger.LoggerType.BluePirateRapid, NumLoggers = 1 },
           new Logger { Id = 4, TypeLogger = Logger.LoggerType.BluePirateRapid, NumLoggers = 1 },
           new Logger { Id = 5, TypeLogger = Logger.LoggerType.X2e, NumLoggers = 1 },
           new Logger { Id = 6, TypeLogger = Logger.LoggerType.X2e, NumLoggers = 1 }
       );


            //builder.Property(e => e.Id);
            //builder.Property(e => e.Message).HasMaxLength(255);
            //builder.Property(e => e.Time)

            //    .HasDefaultValueSql("(getdate())")
            //    .HasColumnType("datetime");

        }
    }


}

