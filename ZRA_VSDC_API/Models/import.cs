using System;

namespace ZRA_VSDC_API.Models;

public class Import
{
    public required string TaskCd { get; set; }
    public int DclDe { get; set; }
    public int ItemSeq { get; set; }
    public required string DclNo { get; set; }
    public required string HsCd { get; set; }
    public required string ItemNm { get; set; }
    public required string ImptItemsttsCd { get; set; }
    public required string OrgnNatCd { get; set; }
    public required string ExptNatCd { get; set; }
    public int Pkg { get; set; }
    public required string PkgUnitCd { get; set; }
    public int Qty { get; set; }
    public required string QtyUnitCd { get; set; }
    public double TotWt { get; set; }
    public double NetWt { get; set; }
    public required string SpplrNm { get; set; }
    public required string AgntNm { get; set; }
    public double InvcFcurAmt { get; set; }
    public required string InvcFcurCd { get; set; }
    public double InvcFcurExcrt { get; set; }
}
