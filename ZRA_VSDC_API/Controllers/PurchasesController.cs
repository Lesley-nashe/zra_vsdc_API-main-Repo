using Microsoft.AspNetCore.Mvc;
using ZRA_VSDC_API.Models;
using ZRA_VSDC_API.Models.Dto;
using System.Linq;

namespace ZRA_VSDC_API.Controllers
{
    // [ApiController]
    // [Route("trnsPurchase")]
    // public class PurchasesController : ControllerBase
    // {
    //     [HttpPost("selectTrnsPurchaseSales")]
    //     public IActionResult GetPurchases([FromBody] GetPurchaseRequest request)
    //     {
    //         var purchases = Data.PurchaseList
    //             .Where(p => p.Tpin == request.Tpin && p.BhfId == request.BhfId)
    //             .ToList();

    //         if (!purchases.Any())
    //         {
    //             return NotFound(new Response
    //             {
    //                 ResultCd = "404",
    //                 ResultMsg = "No purchases found.",
    //                 ResultDt = DateTime.UtcNow.ToString("yyyyMMddHHmmss")
    //             });
    //         }

    //         return Ok(new Response
    //         {
    //             ResultCd = "000",
    //             ResultMsg = "It is succeeded",
    //             ResultDt = DateTime.UtcNow.ToString("yyyyMMddHHmmss"),
    //             Data = purchases
    //         });
    //     }

    //     [HttpPost("savePurchase")]
    //     public IActionResult SavePurchase([FromBody] SavePurchaseRequest request)
    //     {
    //         if (string.IsNullOrEmpty(request.Tpin) || request.ItemList == null || !request.ItemList.Any())
    //         {
    //             return BadRequest(new Response
    //             {
    //                 ResultCd = "400",
    //                 ResultMsg = "Invalid purchase data",
    //                 ResultDt = DateTime.UtcNow.ToString("yyyyMMddHHmmss")
    //             });
    //         }

            
    //         Data.PurchaseList.Add(new Purchase
    //         {
    //             Tpin = request.Tpin,
    //             BhfId = request.BhfId,
    //             SpplrTpin = request.SpplrTpin,
    //             SpplrNm = request.SpplrNm,
    //             SpplrBhfId = request.SpplrBhfId,
    //             SpplrInvcNo = int.Parse(request.SpplrInvcNo),
    //             RcptTyCd = request.RcptTyCd,
    //             PmtTyCd = request.PmtTyCd,
    //             CfmDt = request.CfmDt,
    //             SalesDt = request.PchsDt,
    //             StockRlsDt = request.CnclDt,
    //             TotItemCnt = request.TotItemCnt,
    //             TotTaxblAmt = request.TotTaxblAmt,
    //             TotTaxAmt = request.TotTaxAmt,
    //             TotAmt = request.TotAmt,
    //             Remark = request.Remark,
    //             ItemList = request.ItemList.Select(item => new PurchaseItem
    //             {
    //                 ItemSeq = item.ItemSeq,
    //                 ItemCd = item.ItemCd,
    //                 ItemClsCd = item.ItemClsCd,
    //                 ItemNm = item.ItemNm,
    //                 Bcd = item.Bcd,
    //                 PkgUnitCd = item.PkgUnitCd,
    //                 Pkg = item.Pkg,
    //                 QtyUnitCd = item.QtyUnitCd,
    //                 Qty = item.Qty,
    //                 Prc = item.Prc,
    //                 SplyAmt = item.SplyAmt,
    //                 DcRt = item.DcRt,
    //                 DcAmt = item.DcAmt,
    //                 VatCatCd = item.VatCatCd,
    //                 IplCatCd = item.IplCatCd,
    //                 TlCatCd = item.TlCatCd,
    //                 ExciseTxCatCd = item.ExciseTxCatCd,
    //                 VatTaxblAmt = item.VatTaxblAmt,
    //                 ExciseTaxblAmt = item.ExciseTaxblAmt,
    //                 IplTaxblAmt = item.IplTaxblAmt,
    //                 TlTaxblAmt = item.TlTaxblAmt,
    //                 TaxblAmt = item.TaxblAmt,
    //                 VatAmt = item.VatAmt,
    //                 ExciseTxAmt = item.ExciseTxAmt,
    //                 IplAmt = item.IplAmt,
    //                 TlAmt = item.TlAmt,
    //                 TotAmt = item.TotAmt
    //             }).ToList()
    //         });

    //         // Call the Save Stock Items endpoint and Stock Master endpoint with data minipulation logic 

    //         return Ok(new Response
    //         {
    //             ResultCd = "000",
    //             ResultMsg = "It is succeeded",
    //             ResultDt = DateTime.UtcNow.ToString("yyyyMMddHHmmss"),
    //             Data = null
    //         });
    //     }
    // }

    
    // public class SavePurchaseRequest
    // {
    //     public string Tpin { get; set; }
    //     public string BhfId { get; set; }
    //     public string InvcNo { get; set; }
    //     public int OrgInvcNo { get; set; }
    //     public string SpplrTpin { get; set; }
    //     public string SpplrBhfId { get; set; }
    //     public string SpplrNm { get; set; }
    //     public string SpplrInvcNo { get; set; }
    //     public string RegTyCd { get; set; }
    //     public string PchsTyCd { get; set; }
    //     public string RcptTyCd { get; set; }
    //     public string PmtTyCd { get; set; }
    //     public string PchsSttsCd { get; set; }
    //     public string CfmDt { get; set; }
    //     public string PchsDt { get; set; }
    //     public string CnclReqDt { get; set; }
    //     public string CnclDt { get; set; }
    //     public int TotItemCnt { get; set; }
    //     public decimal TotTaxblAmt { get; set; }
    //     public decimal TotTaxAmt { get; set; }
    //     public decimal TotAmt { get; set; }
    //     public string Remark { get; set; }
    //     public string RegrNm { get; set; }
    //     public string RegrId { get; set; }
    //     public string ModrNm { get; set; }
    //     public string ModrId { get; set; }
    //     public List<PurchaseItemRequest> ItemList { get; set; }
    // }

    // public class PurchaseItemRequest
    // {
    //     public int ItemSeq { get; set; }
    //     public string ItemCd { get; set; }
    //     public string ItemClsCd { get; set; }
    //     public string ItemNm { get; set; }
    //     public string Bcd { get; set; }
    //     public string PkgUnitCd { get; set; }
    //     public decimal Pkg { get; set; }
    //     public string QtyUnitCd { get; set; }
    //     public decimal Qty { get; set; }
    //     public decimal Prc { get; set; }
    //     public decimal SplyAmt { get; set; }
    //     public decimal DcRt { get; set; }
    //     public decimal DcAmt { get; set; }
    //     public string VatCatCd { get; set; }
    //     public string IplCatCd { get; set; }
    //     public string TlCatCd { get; set; }
    //     public string ExciseTxCatCd { get; set; }
    //     public decimal VatTaxblAmt { get; set; }
    //     public decimal ExciseTaxblAmt { get; set; }
    //     public decimal IplTaxblAmt { get; set; }
    //     public decimal TlTaxblAmt { get; set; }
    //     public decimal TaxblAmt { get; set; }
    //     public decimal VatAmt { get; set; }
    //     public decimal ExciseTxAmt { get; set; }
    //     public decimal IplAmt { get; set; }
    //     public decimal TlAmt { get; set; }
    //     public decimal TotAmt { get; set; }
    // }
}