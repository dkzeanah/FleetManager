using System;
using System.Collections.Generic;

namespace BlazorApp1.MyModels1;

public partial class ExcelDataRecordAttribute
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public string Value { get; set; } = null!;

    public long ExcelDataRecordId { get; set; }

    public virtual ExcelDataRecord ExcelDataRecord { get; set; } = null!;
}
