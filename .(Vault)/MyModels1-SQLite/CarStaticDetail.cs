using System;
using System.Collections.Generic;

namespace BlazorApp1.MyModels1;

public partial class CarStaticDetail
{
    public long Id { get; set; }

    public string Vin { get; set; } = null!;

    public string Tag { get; set; } = null!;

    public string Finas { get; set; } = null!;

    public long? Adas { get; set; }

    public long? CarId { get; set; }

    public virtual Car IdNavigation { get; set; } = null!;
}
