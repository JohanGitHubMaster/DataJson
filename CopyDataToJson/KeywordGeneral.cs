using System;
using System.Collections.Generic;

namespace CopyDataToJson;

public partial class KeywordGeneral
{
    public long KeywordGeneralId { get; set; }

    public int Orderid { get; set; }

    public string? ProfileName { get; set; }

    public string? ProfileAdditionFr { get; set; }

    public string? ProfileAdditionNl { get; set; }

    public string? ProfileAdditionHtmlfr { get; set; }

    public string? ProfileAdditionHtmlnl { get; set; }

    public int WorkPackageId { get; set; }

    public bool? Active { get; set; }

    public bool FromDateActive { get; set; }

    public DateTime? FromDate { get; set; }

    public bool ToDateActive { get; set; }

    public DateTime? ToDate { get; set; }

    public string? ProfileAdditionFrweb { get; set; }

    public string? ProfileAdditionNlweb { get; set; }

    public string? ProfileAdditionHtmlfrweb { get; set; }

    public string? ProfileAdditionHtmlnlweb { get; set; }

    public bool WebActive { get; set; }

    public bool FromDateActiveWp { get; set; }

    public DateTime? FromDateWp { get; set; }

    public bool ToDateActiveWp { get; set; }

    public DateTime? ToDateWp { get; set; }
}
