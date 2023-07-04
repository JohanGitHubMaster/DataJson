using System;
using System.Collections.Generic;

namespace CopyDataToJson;

public partial class ProfileLock
{
    public long ProfileLockId { get; set; }

    public int OrderId { get; set; }

    public bool Lock { get; set; }

    public string? LockBy { get; set; }

    public DateTime? LockDate { get; set; }
}
