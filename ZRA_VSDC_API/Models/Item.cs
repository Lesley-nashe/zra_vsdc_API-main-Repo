using System;

namespace ZRA_VSDC_API.Models;

public class Item
{
    public int TPin {get; set;}

    public int BHFID {get;set;}

    public required string ItemCd {get;set;}

    public required string ItemClsCd {get;set;}

    public int ItemTyCd {get;set;}

    public required string ItemNm {get;set;}

    public string? ItemStdNm {get;set;}

    public required string OrgnNatCd {get;set;}

    public required string PkgUnitCd {get; set;}

    public required string QtyUnitCd {get;set;}

    public required string VatCatCd {get;set;}

    public required string IplCatCd {get;set;}

    public required string TlCatCd {get;set;}

    public required string ExciseTxCatCd {get;set;}

    public string? BtchNo {get;set;}

    public string? Bcd {get;set;}

    public double DftPrc {get;set;}

    public string? AddInfo {get;set;}

    public int SftyQty {get;set;}

    public required string IsrcAplcbYn {get;set;}

    public required string UseYn {get;set;}

    public required string RegrNm {get;set;}

    public required string RegrId {get;set;}

    public required string ModrNm {get;set;}

    public required string ModrId {get;set;}

}
