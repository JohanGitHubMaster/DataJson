using System;
using System.Collections.Generic;

namespace CopyDataToJson;

public partial class WorkpackageWebclip
{
    public int WorkpackageId { get; set; }

    public string WorkpackageName { get; set; } = null!;

    public bool Active { get; set; }
}
