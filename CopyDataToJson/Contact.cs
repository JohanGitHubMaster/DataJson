using System;
using System.Collections.Generic;

namespace CopyDataToJson;

/// <summary>
/// Les contacts (journalistes)
/// </summary>
public partial class Contact
{
    public long ContactId { get; set; }

    public short? MediaScoreId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string? FullName { get; set; }

    public long? MapSalutationId { get; set; }

    public string? Remarks { get; set; }

    public bool? Active { get; set; }

    public DateTime CreationDate { get; set; }

    public DateTime? ModDate { get; set; }

    public bool UpdateMs { get; set; }

    public bool PresentInJp { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModBy { get; set; }

    public string? Abbreviations { get; set; }
}
