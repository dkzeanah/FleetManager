using System;
using System.Collections.Generic;

namespace BlazorApp1.MyModels4;

public partial class ExcelDataRecord
{
    public long Id { get; set; }

    public string? Data { get; set; }

    public string? DataHash { get; set; }

    public string? JsonData { get; set; }

    public string LastModified { get; set; } = null!;

    public string UploadDate { get; set; } = null!;

    public virtual ICollection<ExcelDataRecordAttribute> ExcelDataRecordAttributes { get; set; } = new List<ExcelDataRecordAttribute>();

    public virtual ICollection<ExcelDataRecordChange> ExcelDataRecordChanges { get; set; } = new List<ExcelDataRecordChange>();
}
