using System;

namespace ZRA_VSDC_API.Models;

public class Device
{
    public int TPin { get; set; }
    public required string TaxprNm { get; set; }
    public required string BsnsActv { get; set; } // Nullable string
    public required string BhfId { get; set; }
    public required string BhfNm { get; set; }
    public DateTime BhfOpenDt { get; set; }
    public required string PrvncNm { get; set; }
    public required string DstrtNm { get; set; } // Nullable string
    public required string SctrNm { get; set; }
    public required string LocDesc { get; set; }
    public required string HqYn { get; set; }
    public required string MgrNm { get; set; }
    public required string MgrTelNo { get; set; }
    public required string MgrEmail { get; set; }
    public required string SdcId { get; set; }
    public required string MrcNo { get; set; }
    public int? LastPchsInvcNo { get; set; } // Nullable int
    public int? LastSaleRcptNo { get; set; } // Nullable int
    public int? LastInvcNo { get; set; } // Nullable int
    public int? LastSaleInvcNo { get; set; } // Nullable int
    public int? LastTrainInvcNo { get; set; } // Nullable int
    public int? LastProfrmInvcNo { get; set; } // Nullable int
    public int? LastCopyInvcNo { get; set; } // Nullable int
}
