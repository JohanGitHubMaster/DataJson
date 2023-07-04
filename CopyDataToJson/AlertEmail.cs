using System;
using System.Collections.Generic;

namespace CopyDataToJson;

public partial class AlertEmail
{
    public long AlertEmailId { get; set; }

    public long AlertId { get; set; }

    public string Email { get; set; } = null!;

    public string Language { get; set; } = null!;

    public virtual Alert Alert { get; set; } = null!;
}
