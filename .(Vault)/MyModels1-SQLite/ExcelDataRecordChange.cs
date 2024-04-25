using System;
using System.Collections.Generic;

namespace BlazorApp1.MyModels1;

public partial class ExcelDataRecordChange
{
    public long Id { get; set; }

    public string ColumnName { get; set; } = null!;

    public string OldValue { get; set; } = null!;

    public string NewValue { get; set; } = null!;

    public string ChangeDate { get; set; } = null!;

    public long ExcelDataRecordId { get; set; }

    public virtual ExcelDataRecord ExcelDataRecord { get; set; } = null!;
}
