using System;
using System.Collections.Generic;

namespace CopyDataToJson;

public partial class Lock
{
    public int LockId { get; set; }

    public int Orderid { get; set; }

    public string? UserName { get; set; }

    public DateTime? LockedDate { get; set; }

    public bool? IsLocked { get; set; }

    public bool IsLockedWrittenPress { get; set; }

    public bool IsLockedAlertWeb { get; set; }

    public bool IsLockedRtvpixel { get; set; }

    public bool IsLockedRtvvocRec { get; set; }

    public bool IsLockedWeb { get; set; }
}
