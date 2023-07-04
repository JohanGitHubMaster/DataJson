using System;
using System.Collections.Generic;

namespace CopyDataToJson;

public partial class User
{
    public int UserId { get; set; }

    public string? UserName { get; set; }

    public string? UserLanguage { get; set; }

    public DateTime? UserLogDate { get; set; }
}
