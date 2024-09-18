using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ZRA_VSDC_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using ZRA_VSDC_API.Services;
using ZRA_VSDC_API.Models.Dto;
using ZRA_VSDC_API.Context;

namespace ZRA_VSDC_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesController(ISalesService salesService, ApplicationDbContext db) : ControllerBase
    {
        private readonly ApplicationDbContext _db = db;

        [HttpPost("saveSales")] //Normal sale
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult SaveSales([FromBody] Sale saleRequest)
        {
            if (saleRequest == null)
            {
                return BadRequest("Invalid Sales request");
            }

            var sale = new Sale
            {
                TaxblAmtTl = saleRequest.TaxblAmtTl,
                TaxAmtB = saleRequest.TaxAmtB,
                TaxAmtC1 = saleRequest.TaxAmtC1,
                TaxAmtC2 = saleRequest.TaxAmtC2,
                TaxAmtC3 = saleRequest.TaxAmtC3,
                TaxAmtD = saleRequest.TaxAmtD,
                TaxAmtRvat = saleRequest.TaxAmtRvat,
                TaxAmtE = saleRequest.TaxAmtE,
                TaxAmtF = saleRequest.TaxAmtF,
                TaxAmtIpl1 = saleRequest.TaxAmtIpl1,
                TaxAmtIpl2 = saleRequest.TaxAmtIpl2,
                TaxAmtTl = saleRequest.TaxAmtTl,
                TaxAmtEcm = saleRequest.TaxAmtEcm,
                TaxAmtExeeg = saleRequest.TaxAmtExeeg,
                TaxAmtTot = saleRequest.TaxAmtTot,
                TotTaxblAmt = saleRequest.TotTaxblAmt,
                TotTaxAmt = saleRequest.TotTaxAmt,
                TaxblAmtC1 = saleRequest.TaxblAmtC1,
                TaxblAmtC2 = saleRequest.TaxblAmtC2,
                TaxblAmtC3 = saleRequest.TaxblAmtC3,
                TaxblAmtD = saleRequest.TaxblAmtD,
                StockRlsDt = saleRequest.StockRlsDt,
                DestnCountryCd = saleRequest.DestnCountryCd,
                LpoNumber = saleRequest.LpoNumber,
                TaxblAmtRvat = saleRequest.TaxblAmtRvat,
                TaxblAmtE = saleRequest.TaxblAmtE,
                TaxblAmtF = saleRequest.TaxblAmtF,
                TaxblAmtIpl1 = saleRequest.TaxblAmtIpl1,
                TaxblAmtIpl2 = saleRequest.TaxblAmtIpl2,
                TaxblAmtEcm = saleRequest.TaxblAmtEcm,
                TaxblAmtExeeg = saleRequest.TaxblAmtExeeg,
                TaxblAmtTot = saleRequest.TaxblAmtTot,
                TaxRtA = saleRequest.TaxRtA,
                TaxRtB = saleRequest.TaxRtB,
                TaxRtC1 = saleRequest.TaxRtC1,
                TaxRtC2 = saleRequest.TaxRtC2,
                TaxRtC3 = saleRequest.TaxRtC3,
                TaxRtD = saleRequest.TaxRtD,
                TlAmt = saleRequest.TlAmt,
                TaxRtRvat = saleRequest.TaxRtRvat,
                TaxRtE = saleRequest.TaxRtRvat,
                TaxRtF = saleRequest.TaxRtF,
                TaxRtIpl1 = saleRequest.TaxRtIpl1,
                TaxRtIpl2 = saleRequest.TaxRtIpl2,
                TaxRtTl = saleRequest.TaxRtTl,
                TaxRtEcm = saleRequest.TaxRtEcm,
                TaxRtExeeg = saleRequest.TaxRtExeeg,
                TaxRtTot = saleRequest.TaxRtTot,
                RfdRsnCd = saleRequest.RfdRsnCd,
                RfdDt = saleRequest.RfdDt,
                CnclDt = saleRequest.CnclDt,
                CnclReqDt = saleRequest.CnclReqDt,
                Tpin = saleRequest.Tpin,
                BhfId = saleRequest.BhfId,
                OrgInvcNo = saleRequest.OrgInvcNo,
                CisInvcNo = saleRequest.CisInvcNo,
                CustTpin = saleRequest.CustTpin,
                CustNm = saleRequest.CustNm,
                SalesTyCd = saleRequest.SalesTyCd,
                RcptTyCd = saleRequest.RcptTyCd,
                PmtTyCd = saleRequest.PmtTyCd,
                SalesSttsCd = saleRequest.SalesSttsCd,
                CfmDt = saleRequest.CfmDt,
                SalesDt = saleRequest.SalesDt,
                TotItemCnt = saleRequest.TotItemCnt,
                TaxblAmtA = saleRequest.TaxblAmtA,
                TaxblAmtB = saleRequest.TaxblAmtB,
                TaxAmtA = saleRequest.TaxAmtA,
                TotAmt = saleRequest.TotAmt,
                PrchrAcptcYn = saleRequest.PrchrAcptcYn,
                Remark = saleRequest.Remark,
                RegrId = saleRequest.RegrId,
                RegrNm = saleRequest.RegrNm,
                ModrId = saleRequest.ModrId,
                ModrNm = saleRequest.ModrNm,
                SaleCtyCd = saleRequest.SaleCtyCd,
                CurrencyTyCd = saleRequest.CurrencyTyCd,
                ExchangeRt = saleRequest.ExchangeRt,
                DbtRsnCd = saleRequest.DbtRsnCd,
                InvcAdjustReason = saleRequest.InvcAdjustReason,
                ItemList = saleRequest.ItemList.Select(item => new SaleItem
                {
                    Bcd = item.Bcd,
                    ItemSeq = item.ItemSeq,
                    ItemCd = item.ItemCd,
                    ItemClsCd = item.ItemClsCd,
                    ItemNm = item.ItemNm,
                    PkgUnitCd = item.PkgUnitCd,
                    Pkg = item.Pkg,
                    QtyUnitCd = item.QtyUnitCd,
                    Qty = item.Qty,
                    Prc = item.Prc,
                    SplyAmt = item.SplyAmt,
                    DcRt = item.DcRt,
                    DcAmt = item.DcAmt,
                    IsrccCd = item.IsrccCd,
                    IsrccNm = item.IsrccNm,
                    IsrcRt = item.IsrcRt,
                    IsrcAmt = item.IsrcAmt,
                    VatCatCd = item.VatCatCd,
                    ExciseTxCatCd = item.ExciseTxCatCd,
                    TlCatCd = item.TlCatCd,
                    TlAmt = item.TlAmt,
                    IplCatCd = item.IplCatCd,
                    VatTaxblAmt = item.VatTaxblAmt,
                    TlTaxblAmt = item.TlTaxblAmt,
                    IplTaxblAmt = item.IplTaxblAmt,
                    IplAmt = item.IplAmt,
                    ExciseTaxblAmt = item.ExciseTaxblAmt,
                    VatAmt = item.VatAmt,
                    ExciseTxAmt = item.ExciseTxAmt,
                    TotAmt = item.TotAmt
                }).ToList()
            };

            var createStockRequest = salesService.CreateStockRequest(sale);

            //Save sales data to Sales list
            _db.Sales.Add(sale);
            _db.SaveChanges();

            // Update stock master
            // var stockMasterRequest = salesService.CreateStockMasterRequest(sale);

            var response = new Response()
            {
                ResultCd = "000",
                ResultMsg = "Sale successfully saved.",
                Date = DateTime.Now,
            };

            return Ok(sale);
        }

        [HttpGet]
        public ActionResult<IEnumerable<Sale>> Getsale(){
            return Ok(_db.Sales);
        }

    }

}