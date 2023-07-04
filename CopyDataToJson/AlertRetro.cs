using System;
using System.Collections.Generic;

namespace CopyDataToJson;

public partial class AlertRetro
{
    public int AlertRetroId { get; set; }

    public int OrderId { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreationDate { get; set; }

    public int Status { get; set; }
}
