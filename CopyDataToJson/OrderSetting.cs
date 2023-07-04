using System;
using System.Collections.Generic;

namespace CopyDataToJson;

public partial class OrderSetting
{
    public long OrderSettingsId { get; set; }

    public int Orderid { get; set; }

    public bool Ave { get; set; }

    public bool White { get; set; }

    public long MapHighlightTypeId { get; set; }

    public long MapCoverpageTypeId { get; set; }

    public bool Qa { get; set; }

    public bool IsWebClip { get; set; }

    public bool WebClipActive { get; set; }

    public bool IsWrittenPress { get; set; }

    public long MapLocationId { get; set; }

    public long WebPriority { get; set; }

    public long MapSendingLinkId { get; set; }

    public long MapCutTypeId { get; set; }

    public bool Qaweb { get; set; }

    public long MapHighlightTypeWebId { get; set; }

    public bool Aveweb { get; set; }

    public bool WhiteWeb { get; set; }

    public long MapFlowId { get; set; }

    public virtual MapCoverpageType MapCoverpageType { get; set; } = null!;

    public virtual MapCutType MapCutType { get; set; } = null!;

    public virtual MapFlow MapFlow { get; set; } = null!;

    public virtual MapHighlightType MapHighlightType { get; set; } = null!;

    public virtual MapLocation MapLocation { get; set; } = null!;

    public virtual MapSendingLink MapSendingLink { get; set; } = null!;
}
