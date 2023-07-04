using System;
using System.Collections.Generic;

namespace CopyDataToJson;

public partial class UserAction
{
    public long UserActionId { get; set; }

    public long AlertId { get; set; }

    public long UserId { get; set; }

    public bool Favorite { get; set; }

    public bool Seen { get; set; }
}
