using System;
using System.Collections.Generic;

namespace CopyDataToJson;

public partial class VrecupOpoint
{
    public string? FilePath { get; set; }

    public bool WebAlert { get; set; }

    public bool Active { get; set; }

    public DateTime? PublicationDate { get; set; }

    public long SourceId { get; set; }
}
