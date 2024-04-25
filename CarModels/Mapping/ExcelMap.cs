using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using BlazorApp1.CarModels;

namespace BlazorApp1.Data.Mapping
{
    public class ExcelMap : IEntityTypeConfiguration<ExcelDataRecordChange>
    {
        public void Configure(EntityTypeBuilder<ExcelDataRecordChange> builder)
        {
            builder.HasKey(e => e.Id);
            builder.HasOne(e => e.ExcelDataRecord).WithMany(e => e.Changes).HasForeignKey(e => e.ExcelDataRecordId);
        }
    }

    public class ExcelDataRecordMap : IEntityTypeConfiguration<ExcelDataRecord>
    {
        public void Configure(EntityTypeBuilder<ExcelDataRecord> builder)
        {
            builder.HasKey(e => e.Id);
        }
    }

}
