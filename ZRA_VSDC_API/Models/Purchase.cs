using System;
using System.Collections.Generic;

namespace ZRA_VSDC_API.Models
{
    public class Purchase
    {
        public required string Tpin { get; set; }
        public required string BhfId { get; set; }
        public required string SpplrTpin { get; set; }
        public required string SpplrNm { get; set; }
        public required string SpplrBhfId { get; set; }
        public required int SpplrInvcNo { get; set; }
        public required string RcptTyCd { get; set; }
        public required string PmtTyCd { get; set; }
        public required string CfmDt { get; set; }
        public required string SalesDt { get; set; }
        public string StockRlsDt { get; set; }
        public required int TotItemCnt { get; set; }
        public required decimal TotTaxblAmt { get; set; }
        public required decimal TotTaxAmt { get; set; }
        public required decimal TotAmt { get; set; }
        public string Remark { get; set; }
        public required List<PurchaseItem> ItemList { get; set; }
    }

    public class PurchaseItem
    {
        public required int ItemSeq { get; set; }
        public required string ItemCd { get; set; }
        public required string ItemClsCd { get; set; }
        public required string ItemNm { get; set; }
        public string Bcd { get; set; }
        public required string PkgUnitCd { get; set; }
        public required decimal Pkg { get; set; }
        public required string QtyUnitCd { get; set; }
        public required decimal Qty { get; set; }
        public required decimal Prc { get; set; }
        public required decimal SplyAmt { get; set; }
        public required decimal DcRt { get; set; }
        public required decimal DcAmt { get; set; }
        public required string VatCatCd { get; set; }
        public string IplCatCd { get; set; }
        public string TlCatCd { get; set; }
        public string ExciseTxCatCd { get; set; }
        public required decimal VatTaxblAmt { get; set; }
        public decimal ExciseTaxblAmt { get; set; }
        public decimal TlTaxblAmt { get; set; }
        public decimal IplTaxblAmt { get; set; }
        public required decimal TaxblAmt { get; set; }
        public required decimal VatAmt { get; set; }
        public decimal ExciseTxAmt { get; set; }
        public decimal IplAmt { get; set; }
        public decimal TlAmt { get; set; }
        public required decimal TotAmt { get; set; }
    }
}