using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZRA_VSDC_API.Models;

    public class Sale
    {
        public required int Tpin { get; set; }
        public required int BhfId { get; set; }

        public int OrgInvcNo { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public required string CisInvcNo { get; set; }
        public string CustTpin { get; set; }
        public string CustNm { get; set; }
        public required string SalesTyCd { get; set; }
        public required string RcptTyCd { get; set; }
        public required string PmtTyCd { get; set; }
        public required string SalesSttsCd { get; set; }
        public required string CfmDt { get; set; }
        public required string SalesDt { get; set; }
        public string StockRlsDt { get; set; }
        public required string CnclReqDt { get; set; }
        public required string CnclDt { get; set; }
        public required string RfdDt { get; set; }
        public required string RfdRsnCd { get; set; }
        public required int TotItemCnt { get; set; }
        public required double TaxblAmtA { get; set; }
        public required double TaxblAmtB { get; set; }
        public required double TaxblAmtC1 { get; set; }
        public required double TaxblAmtC2 { get; set; }
        public required double TaxblAmtC3 { get; set; }
        public required double TaxblAmtD { get; set; }
        public required double TaxblAmtRvat { get; set; }
        public required double TaxblAmtE { get; set; }
        public required double TaxblAmtF { get; set; }
        public required double TaxblAmtIpl1 { get; set; }
        public required double TaxblAmtIpl2 { get; set; }
        public required double TaxblAmtTl { get; set; }
        public required double TaxblAmtEcm { get; set; }
        public required double TaxblAmtExeeg { get; set; }
        public required double TaxblAmtTot { get; set; }
        public required double TaxRtA { get; set; }
        public required double TaxRtB { get; set; }
        public required double TaxRtC1 { get; set; }
        public required double TaxRtC2 { get; set; }
        public required double TaxRtC3 { get; set; }
        public required double TaxRtD { get; set; }
        public required double TlAmt { get; set; }
        public required double TaxRtRvat { get; set; }
        public required double TaxRtE { get; set; }
        public required double TaxRtF { get; set; }
        public required double TaxRtIpl1 { get; set; }
        public required double TaxRtIpl2 { get; set; }
        public required double TaxRtTl { get; set; }
        public required double TaxRtEcm { get; set; }
        public required double TaxRtExeeg { get; set; }
        public required double TaxRtTot { get; set; }
        public required double TaxAmtA { get; set; }
        public required double TaxAmtB { get; set; }
        public required double TaxAmtC1 { get; set; }
        public required double TaxAmtC2 { get; set; }
        public required double TaxAmtC3 { get; set; }
        public required double TaxAmtD { get; set; }
        public required double TaxAmtRvat { get; set; }
        public required double TaxAmtE { get; set; }
        public required double TaxAmtF { get; set; }
        public required double TaxAmtIpl1 { get; set; }
        public required double TaxAmtIpl2 { get; set; }
        public required double TaxAmtTl { get; set; }
        public required double TaxAmtEcm { get; set; }
        public required double TaxAmtExeeg { get; set; }
        public required double TaxAmtTot { get; set; }
        public required double TotTaxblAmt { get; set; }
        public required double TotTaxAmt { get; set; }
        public required double TotAmt { get; set; }
        public required string PrchrAcptcYn { get; set; }
        public required string Remark { get; set; }
        public required string RegrId { get; set; }
        public required string RegrNm { get; set; }
        public required string ModrId { get; set; }
        public required string ModrNm { get; set; }
        public required string SaleCtyCd { get; set; }
        public string LpoNumber { get; set; }
        public required string CurrencyTyCd { get; set; }
        public required string ExchangeRt { get; set; }
        public string DestnCountryCd { get; set; }
        public required string DbtRsnCd { get; set; }
        public string InvcAdjustReason { get; set; }
        public required List<SaleItem> ItemList { get; set; }
    }

    public class SaleItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public required int ItemSeq { get; set; }
        public required string ItemCd { get; set; }
        public required string ItemClsCd { get; set; }
        public required string ItemNm { get; set; }
        public string Bcd { get; set; }
        public required string PkgUnitCd { get; set; }
        public required double Pkg { get; set; }
        public required string QtyUnitCd { get; set; }
        public required double Qty { get; set; }
        public required double Prc { get; set; }
        public required double SplyAmt { get; set; }
        public required double DcRt { get; set; }
        public required double DcAmt { get; set; }
        public string IsrccCd { get; set; }
        public string IsrccNm { get; set; }
        public double IsrcRt { get; set; }
        public double IsrcAmt { get; set; }
        public required string VatCatCd { get; set; }
        public required string ExciseTxCatCd { get; set; }
        public required string TlCatCd { get; set; }  
        public required string IplCatCd { get; set; } 
        public required double VatTaxblAmt { get; set; }
        public required double VatAmt { get; set; }
        public required double ExciseTaxblAmt { get; set; }
        public required double TlTaxblAmt { get; set; }
        public required double IplTaxblAmt { get; set; }
        public required double IplAmt { get; set; }
        public required double TlAmt { get; set; }
        public required double ExciseTxAmt { get; set; }
        public required double TotAmt { get; set; }
    }


