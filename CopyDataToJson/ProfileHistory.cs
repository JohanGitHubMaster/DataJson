using System;
using System.Collections.Generic;

namespace CopyDataToJson;

public partial class ProfileHistory
{
    public long ProfileHistoryId { get; set; }

    public int OrderId { get; set; }

    public string? ValidatedBy { get; set; }

    public DateTime? ValidationDate { get; set; }

    public int? Hits { get; set; }
}
