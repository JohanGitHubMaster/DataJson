using System;
using System.Collections.Generic;

namespace CopyDataToJson;

public partial class OrderDetail
{
    public int OrderId { get; set; }

    public string? Comment { get; set; }

    public virtual ICollection<Alert> Alerts { get; set; } = new List<Alert>();
}
