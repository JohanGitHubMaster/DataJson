using System;
using System.Collections.Generic;

namespace CopyDataToJson;

public partial class Vherme
{
    public int OrderId { get; set; }

    public long AlertId { get; set; }

    public DateTime PublicationDate { get; set; }

    public long MediaId { get; set; }

    public string? MediaName { get; set; }

    public long? MapMediaTypeId { get; set; }

    public string? MediaType { get; set; }

    public string? Title { get; set; }

    public string WordFound { get; set; } = null!;

    public DateTime AlertDate { get; set; }

    public string Url { get; set; } = null!;
}
