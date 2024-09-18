using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZRA_VSDC_API.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sales",
                columns: table => new
                {
                    CisInvcNo = table.Column<string>(type: "TEXT", nullable: false),
                    Tpin = table.Column<int>(type: "INTEGER", nullable: false),
                    BhfId = table.Column<int>(type: "INTEGER", nullable: false),
                    OrgInvcNo = table.Column<int>(type: "INTEGER", nullable: false),
                    CustTpin = table.Column<string>(type: "TEXT", nullable: false),
                    CustNm = table.Column<string>(type: "TEXT", nullable: false),
                    SalesTyCd = table.Column<string>(type: "TEXT", nullable: false),
                    RcptTyCd = table.Column<string>(type: "TEXT", nullable: false),
                    PmtTyCd = table.Column<string>(type: "TEXT", nullable: false),
                    SalesSttsCd = table.Column<string>(type: "TEXT", nullable: false),
                    CfmDt = table.Column<string>(type: "TEXT", nullable: false),
                    SalesDt = table.Column<string>(type: "TEXT", nullable: false),
                    StockRlsDt = table.Column<string>(type: "TEXT", nullable: false),
                    CnclReqDt = table.Column<string>(type: "TEXT", nullable: false),
                    CnclDt = table.Column<string>(type: "TEXT", nullable: false),
                    RfdDt = table.Column<string>(type: "TEXT", nullable: false),
                    RfdRsnCd = table.Column<string>(type: "TEXT", nullable: false),
                    TotItemCnt = table.Column<int>(type: "INTEGER", nullable: false),
                    TaxblAmtA = table.Column<double>(type: "REAL", nullable: false),
                    TaxblAmtB = table.Column<double>(type: "REAL", nullable: false),
                    TaxblAmtC1 = table.Column<double>(type: "REAL", nullable: false),
                    TaxblAmtC2 = table.Column<double>(type: "REAL", nullable: false),
                    TaxblAmtC3 = table.Column<double>(type: "REAL", nullable: false),
                    TaxblAmtD = table.Column<double>(type: "REAL", nullable: false),
                    TaxblAmtRvat = table.Column<double>(type: "REAL", nullable: false),
                    TaxblAmtE = table.Column<double>(type: "REAL", nullable: false),
                    TaxblAmtF = table.Column<double>(type: "REAL", nullable: false),
                    TaxblAmtIpl1 = table.Column<double>(type: "REAL", nullable: false),
                    TaxblAmtIpl2 = table.Column<double>(type: "REAL", nullable: false),
                    TaxblAmtTl = table.Column<double>(type: "REAL", nullable: false),
                    TaxblAmtEcm = table.Column<double>(type: "REAL", nullable: false),
                    TaxblAmtExeeg = table.Column<double>(type: "REAL", nullable: false),
                    TaxblAmtTot = table.Column<double>(type: "REAL", nullable: false),
                    TaxRtA = table.Column<double>(type: "REAL", nullable: false),
                    TaxRtB = table.Column<double>(type: "REAL", nullable: false),
                    TaxRtC1 = table.Column<double>(type: "REAL", nullable: false),
                    TaxRtC2 = table.Column<double>(type: "REAL", nullable: false),
                    TaxRtC3 = table.Column<double>(type: "REAL", nullable: false),
                    TaxRtD = table.Column<double>(type: "REAL", nullable: false),
                    TlAmt = table.Column<double>(type: "REAL", nullable: false),
                    TaxRtRvat = table.Column<double>(type: "REAL", nullable: false),
                    TaxRtE = table.Column<double>(type: "REAL", nullable: false),
                    TaxRtF = table.Column<double>(type: "REAL", nullable: false),
                    TaxRtIpl1 = table.Column<double>(type: "REAL", nullable: false),
                    TaxRtIpl2 = table.Column<double>(type: "REAL", nullable: false),
                    TaxRtTl = table.Column<double>(type: "REAL", nullable: false),
                    TaxRtEcm = table.Column<double>(type: "REAL", nullable: false),
                    TaxRtExeeg = table.Column<double>(type: "REAL", nullable: false),
                    TaxRtTot = table.Column<double>(type: "REAL", nullable: false),
                    TaxAmtA = table.Column<double>(type: "REAL", nullable: false),
                    TaxAmtB = table.Column<double>(type: "REAL", nullable: false),
                    TaxAmtC1 = table.Column<double>(type: "REAL", nullable: false),
                    TaxAmtC2 = table.Column<double>(type: "REAL", nullable: false),
                    TaxAmtC3 = table.Column<double>(type: "REAL", nullable: false),
                    TaxAmtD = table.Column<double>(type: "REAL", nullable: false),
                    TaxAmtRvat = table.Column<double>(type: "REAL", nullable: false),
                    TaxAmtE = table.Column<double>(type: "REAL", nullable: false),
                    TaxAmtF = table.Column<double>(type: "REAL", nullable: false),
                    TaxAmtIpl1 = table.Column<double>(type: "REAL", nullable: false),
                    TaxAmtIpl2 = table.Column<double>(type: "REAL", nullable: false),
                    TaxAmtTl = table.Column<double>(type: "REAL", nullable: false),
                    TaxAmtEcm = table.Column<double>(type: "REAL", nullable: false),
                    TaxAmtExeeg = table.Column<double>(type: "REAL", nullable: false),
                    TaxAmtTot = table.Column<double>(type: "REAL", nullable: false),
                    TotTaxblAmt = table.Column<double>(type: "REAL", nullable: false),
                    TotTaxAmt = table.Column<double>(type: "REAL", nullable: false),
                    TotAmt = table.Column<double>(type: "REAL", nullable: false),
                    PrchrAcptcYn = table.Column<string>(type: "TEXT", nullable: false),
                    Remark = table.Column<string>(type: "TEXT", nullable: false),
                    RegrId = table.Column<string>(type: "TEXT", nullable: false),
                    RegrNm = table.Column<string>(type: "TEXT", nullable: false),
                    ModrId = table.Column<string>(type: "TEXT", nullable: false),
                    ModrNm = table.Column<string>(type: "TEXT", nullable: false),
                    SaleCtyCd = table.Column<string>(type: "TEXT", nullable: false),
                    LpoNumber = table.Column<string>(type: "TEXT", nullable: false),
                    CurrencyTyCd = table.Column<string>(type: "TEXT", nullable: false),
                    ExchangeRt = table.Column<string>(type: "TEXT", nullable: false),
                    DestnCountryCd = table.Column<string>(type: "TEXT", nullable: false),
                    DbtRsnCd = table.Column<string>(type: "TEXT", nullable: false),
                    InvcAdjustReason = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sales", x => x.CisInvcNo);
                });

            migrationBuilder.CreateTable(
                name: "SaleItem",
                columns: table => new
                {
                    ItemSeq = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ItemCd = table.Column<string>(type: "TEXT", nullable: false),
                    ItemClsCd = table.Column<string>(type: "TEXT", nullable: false),
                    ItemNm = table.Column<string>(type: "TEXT", nullable: false),
                    Bcd = table.Column<string>(type: "TEXT", nullable: false),
                    PkgUnitCd = table.Column<string>(type: "TEXT", nullable: false),
                    Pkg = table.Column<double>(type: "REAL", nullable: false),
                    QtyUnitCd = table.Column<string>(type: "TEXT", nullable: false),
                    Qty = table.Column<double>(type: "REAL", nullable: false),
                    Prc = table.Column<double>(type: "REAL", nullable: false),
                    SplyAmt = table.Column<double>(type: "REAL", nullable: false),
                    DcRt = table.Column<double>(type: "REAL", nullable: false),
                    DcAmt = table.Column<double>(type: "REAL", nullable: false),
                    IsrccCd = table.Column<string>(type: "TEXT", nullable: false),
                    IsrccNm = table.Column<string>(type: "TEXT", nullable: false),
                    IsrcRt = table.Column<double>(type: "REAL", nullable: false),
                    IsrcAmt = table.Column<double>(type: "REAL", nullable: false),
                    VatCatCd = table.Column<string>(type: "TEXT", nullable: false),
                    ExciseTxCatCd = table.Column<string>(type: "TEXT", nullable: false),
                    TlCatCd = table.Column<string>(type: "TEXT", nullable: false),
                    IplCatCd = table.Column<string>(type: "TEXT", nullable: false),
                    VatTaxblAmt = table.Column<double>(type: "REAL", nullable: false),
                    VatAmt = table.Column<double>(type: "REAL", nullable: false),
                    ExciseTaxblAmt = table.Column<double>(type: "REAL", nullable: false),
                    TlTaxblAmt = table.Column<double>(type: "REAL", nullable: false),
                    IplTaxblAmt = table.Column<double>(type: "REAL", nullable: false),
                    IplAmt = table.Column<double>(type: "REAL", nullable: false),
                    TlAmt = table.Column<double>(type: "REAL", nullable: false),
                    ExciseTxAmt = table.Column<double>(type: "REAL", nullable: false),
                    TotAmt = table.Column<double>(type: "REAL", nullable: false),
                    SaleCisInvcNo = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaleItem", x => x.ItemSeq);
                    table.ForeignKey(
                        name: "FK_SaleItem_Sales_SaleCisInvcNo",
                        column: x => x.SaleCisInvcNo,
                        principalTable: "Sales",
                        principalColumn: "CisInvcNo");
                });

            migrationBuilder.CreateIndex(
                name: "IX_SaleItem_SaleCisInvcNo",
                table: "SaleItem",
                column: "SaleCisInvcNo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SaleItem");

            migrationBuilder.DropTable(
                name: "Sales");
        }
    }
}
