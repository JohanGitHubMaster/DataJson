using System;
using System.Collections.Generic;

namespace CopyDataToJson;

public partial class VordersWebSetting
{
    public int Orderid { get; set; }

    public string? Location { get; set; }

    public string? SendingLink { get; set; }

    public string? CutType { get; set; }

    public string? Flow { get; set; }
}
