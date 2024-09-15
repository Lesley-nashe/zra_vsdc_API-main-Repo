using System;
using ZRA_VSDC_API.Models;

namespace ZRA_VSDC_API.Services;

public class SalesServices : ISalesService
{
    public async Task<SaveStockMasterRequest> CreateStockMasterRequest(Sale sale)
    {
        SaveStockMasterRequest saveStockMasterRequest = new()
        {
            Tpin = sale.Tpin.ToString(),
            BhfId = sale.BhfId.ToString(),
            RegrId = sale.RegrId,
            RegrNm = sale.RegrNm,
            ModrId = sale.ModrId,
            ModrNm = sale.ModrNm,
            StockItemList = sale.ItemList.Select(item => new MasterStockItem
            {
                ItemCd = item.ItemCd,
                RsdQty = -item.Qty //Assuming reducing stock based on the sale
            }).ToList()
        };

        return saveStockMasterRequest;
    }

    public async Task<SaveStockRequest> CreateStockRequest(Sale sale)
    {
        SaveStockRequest saveStockRequest = new()
        {
            Tpin = sale.Tpin.ToString(),
            BhfId = sale.BhfId.ToString(),
            SarNo = 123, // Generate or obtain the stock adjustment number
            OrgSarNo = 456, // Original stock adjustment number if applicable
            RegTyCd = "31", // Define registration type code
            SarTyCd = "SAR_TYPE", // Define stock adjustment type code
            OcrnDt = DateTime.Now.ToString("yyyyMMddHHmmss"),
            TotItemCnt = sale.ItemList.Count,
            TotTaxblAmt = (decimal)sale.TaxblAmtTot,
            TotTaxAmt = (decimal)sale.TotTaxAmt,
            TotAmt = (decimal)sale.TotAmt,
            RegrId = sale.RegrId,
            RegrNm = sale.RegrNm,
            ModrId = sale.ModrId,
            ModrNm = sale.ModrNm,
            ItemList = sale.ItemList.Select(item => new SaveStockItem
            {
                ItemSeq = item.ItemSeq,
                ItemCd = item.ItemCd,
                ItemClsCd = item.ItemClsCd,
                ItemNm = item.ItemNm,
                PkgUnitCd = item.PkgUnitCd,
                QtyUnitCd = item.QtyUnitCd,
                Qty = (decimal)item.Qty,
                Prc = (decimal)item.Prc,
                SplyAmt = (decimal)item.SplyAmt,
                TaxblAmt = (decimal)item.VatTaxblAmt,
                VatCatCd = item.VatCatCd,
                TaxAmt = (decimal)item.VatAmt,
                TotAmt = (decimal)item.TotAmt
            }).ToList()
        };

        return saveStockRequest;
    }

}
