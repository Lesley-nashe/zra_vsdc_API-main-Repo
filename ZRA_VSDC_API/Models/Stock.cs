using System;
using System.Collections.Generic;

namespace ZRA_VSDC_API.Models;
    public class GetStockItem
    {
        public required string Tpin { get; set; }
        public required string BhfId { get; set; }
        public int TaskCd { get; set; }
        public required string DclDe { get; set; }
        public required List<ImportItem> ImportItemList { get; set; }
    }

    public class ImportItem
    {
        public int ItemSeq { get; set; }
        public string HsCd { get; set; }
        public string ItemClsCd { get; set; }
        public string ItemCd { get; set; }
        public string ImptItemSttsCd { get; set; }
        public string Remark { get; set; }
        public string ModrNm { get; set; }  // Changed to string
        public string ModrId { get; set; }
    }

    public class SaveStockRequest
    {
        public string Tpin { get; set; }
        public string BhfId { get; set; }
        public int SarNo { get; set; }
        public int OrgSarNo { get; set; }
        public string RegTyCd { get; set; }
        public string SarTyCd { get; set; }
        public string OcrnDt { get; set; }
        public int TotItemCnt { get; set; }
        public decimal TotTaxblAmt { get; set; }
        public decimal TotTaxAmt { get; set; }
        public decimal TotAmt { get; set; }
        public string RegrId { get; set; }
        public string RegrNm { get; set; }
        public string ModrNm { get; set; }
        public string ModrId { get; set; }
        public List<SaveStockItem> ItemList { get; set; }
    }

    public class SaveStockItem
    {
        public int ItemSeq { get; set; }
        public string ItemCd { get; set; }
        public string ItemClsCd { get; set; }
        public string ItemNm { get; set; }
        public string PkgUnitCd { get; set; }
        public string QtyUnitCd { get; set; }
        public decimal Qty { get; set; }
        public decimal Prc { get; set; }
        public decimal SplyAmt { get; set; }
        public decimal TaxblAmt { get; set; }
        public string VatCatCd { get; set; }
        public decimal TaxAmt { get; set; }
        public decimal TotAmt { get; set; }
    }

    public class SaveStockMasterRequest
    {
        public string Tpin { get; set; }
        public string BhfId { get; set; }
        public string RegrId { get; set; }
        public string RegrNm { get; set; }
        public string ModrNm { get; set; }
        public string ModrId { get; set; }
        public List<MasterStockItem> StockItemList { get; set; } = new List<MasterStockItem>();
    }

    public class MasterStockItem
    {
        public string ItemCd { get; set; }
        public double RsdQty { get; set; }
    }

