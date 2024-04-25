using System;
using System.Collections.Generic;

namespace BlazorApp1.CarModels;

public partial class TempEvent
{
    public int EventId { get; set; }

    public int CarId { get; set; }

    public int UserId { get; set; }

    public int EventTypeId { get; set; }

    public DateTime StartTime { get; set; }

    public DateTime EndTime { get; set; }
}
