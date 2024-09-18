﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ZRA_VSDC_API.Context;

#nullable disable

namespace ZRA_VSDC_API.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240917203520_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.8");

            modelBuilder.Entity("ZRA_VSDC_API.Models.Sale", b =>
                {
                    b.Property<string>("CisInvcNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<int>("BhfId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("CfmDt")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CnclDt")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CnclReqDt")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CurrencyTyCd")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CustNm")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CustTpin")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("DbtRsnCd")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("DestnCountryCd")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ExchangeRt")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("InvcAdjustReason")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LpoNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ModrId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ModrNm")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("OrgInvcNo")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PmtTyCd")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PrchrAcptcYn")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("RcptTyCd")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("RegrId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("RegrNm")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Remark")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("RfdDt")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("RfdRsnCd")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SaleCtyCd")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SalesDt")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SalesSttsCd")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SalesTyCd")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("StockRlsDt")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("TaxAmtA")
                        .HasColumnType("REAL");

                    b.Property<double>("TaxAmtB")
                        .HasColumnType("REAL");

                    b.Property<double>("TaxAmtC1")
                        .HasColumnType("REAL");

                    b.Property<double>("TaxAmtC2")
                        .HasColumnType("REAL");

                    b.Property<double>("TaxAmtC3")
                        .HasColumnType("REAL");

                    b.Property<double>("TaxAmtD")
                        .HasColumnType("REAL");

                    b.Property<double>("TaxAmtE")
                        .HasColumnType("REAL");

                    b.Property<double>("TaxAmtEcm")
                        .HasColumnType("REAL");

                    b.Property<double>("TaxAmtExeeg")
                        .HasColumnType("REAL");

                    b.Property<double>("TaxAmtF")
                        .HasColumnType("REAL");

                    b.Property<double>("TaxAmtIpl1")
                        .HasColumnType("REAL");

                    b.Property<double>("TaxAmtIpl2")
                        .HasColumnType("REAL");

                    b.Property<double>("TaxAmtRvat")
                        .HasColumnType("REAL");

                    b.Property<double>("TaxAmtTl")
                        .HasColumnType("REAL");

                    b.Property<double>("TaxAmtTot")
                        .HasColumnType("REAL");

                    b.Property<double>("TaxRtA")
                        .HasColumnType("REAL");

                    b.Property<double>("TaxRtB")
                        .HasColumnType("REAL");

                    b.Property<double>("TaxRtC1")
                        .HasColumnType("REAL");

                    b.Property<double>("TaxRtC2")
                        .HasColumnType("REAL");

                    b.Property<double>("TaxRtC3")
                        .HasColumnType("REAL");

                    b.Property<double>("TaxRtD")
                        .HasColumnType("REAL");

                    b.Property<double>("TaxRtE")
                        .HasColumnType("REAL");

                    b.Property<double>("TaxRtEcm")
                        .HasColumnType("REAL");

                    b.Property<double>("TaxRtExeeg")
                        .HasColumnType("REAL");

                    b.Property<double>("TaxRtF")
                        .HasColumnType("REAL");

                    b.Property<double>("TaxRtIpl1")
                        .HasColumnType("REAL");

                    b.Property<double>("TaxRtIpl2")
                        .HasColumnType("REAL");

                    b.Property<double>("TaxRtRvat")
                        .HasColumnType("REAL");

                    b.Property<double>("TaxRtTl")
                        .HasColumnType("REAL");

                    b.Property<double>("TaxRtTot")
                        .HasColumnType("REAL");

                    b.Property<double>("TaxblAmtA")
                        .HasColumnType("REAL");

                    b.Property<double>("TaxblAmtB")
                        .HasColumnType("REAL");

                    b.Property<double>("TaxblAmtC1")
                        .HasColumnType("REAL");

                    b.Property<double>("TaxblAmtC2")
                        .HasColumnType("REAL");

                    b.Property<double>("TaxblAmtC3")
                        .HasColumnType("REAL");

                    b.Property<double>("TaxblAmtD")
                        .HasColumnType("REAL");

                    b.Property<double>("TaxblAmtE")
                        .HasColumnType("REAL");

                    b.Property<double>("TaxblAmtEcm")
                        .HasColumnType("REAL");

                    b.Property<double>("TaxblAmtExeeg")
                        .HasColumnType("REAL");

                    b.Property<double>("TaxblAmtF")
                        .HasColumnType("REAL");

                    b.Property<double>("TaxblAmtIpl1")
                        .HasColumnType("REAL");

                    b.Property<double>("TaxblAmtIpl2")
                        .HasColumnType("REAL");

                    b.Property<double>("TaxblAmtRvat")
                        .HasColumnType("REAL");

                    b.Property<double>("TaxblAmtTl")
                        .HasColumnType("REAL");

                    b.Property<double>("TaxblAmtTot")
                        .HasColumnType("REAL");

                    b.Property<double>("TlAmt")
                        .HasColumnType("REAL");

                    b.Property<double>("TotAmt")
                        .HasColumnType("REAL");

                    b.Property<int>("TotItemCnt")
                        .HasColumnType("INTEGER");

                    b.Property<double>("TotTaxAmt")
                        .HasColumnType("REAL");

                    b.Property<double>("TotTaxblAmt")
                        .HasColumnType("REAL");

                    b.Property<int>("Tpin")
                        .HasColumnType("INTEGER");

                    b.HasKey("CisInvcNo");

                    b.ToTable("Sales");
                });

            modelBuilder.Entity("ZRA_VSDC_API.Models.SaleItem", b =>
                {
                    b.Property<int>("ItemSeq")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Bcd")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("DcAmt")
                        .HasColumnType("REAL");

                    b.Property<double>("DcRt")
                        .HasColumnType("REAL");

                    b.Property<double>("ExciseTaxblAmt")
                        .HasColumnType("REAL");

                    b.Property<double>("ExciseTxAmt")
                        .HasColumnType("REAL");

                    b.Property<string>("ExciseTxCatCd")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("IplAmt")
                        .HasColumnType("REAL");

                    b.Property<string>("IplCatCd")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("IplTaxblAmt")
                        .HasColumnType("REAL");

                    b.Property<double>("IsrcAmt")
                        .HasColumnType("REAL");

                    b.Property<double>("IsrcRt")
                        .HasColumnType("REAL");

                    b.Property<string>("IsrccCd")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("IsrccNm")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ItemCd")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ItemClsCd")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ItemNm")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("Pkg")
                        .HasColumnType("REAL");

                    b.Property<string>("PkgUnitCd")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("Prc")
                        .HasColumnType("REAL");

                    b.Property<double>("Qty")
                        .HasColumnType("REAL");

                    b.Property<string>("QtyUnitCd")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SaleCisInvcNo")
                        .HasColumnType("TEXT");

                    b.Property<double>("SplyAmt")
                        .HasColumnType("REAL");

                    b.Property<double>("TlAmt")
                        .HasColumnType("REAL");

                    b.Property<string>("TlCatCd")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("TlTaxblAmt")
                        .HasColumnType("REAL");

                    b.Property<double>("TotAmt")
                        .HasColumnType("REAL");

                    b.Property<double>("VatAmt")
                        .HasColumnType("REAL");

                    b.Property<string>("VatCatCd")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("VatTaxblAmt")
                        .HasColumnType("REAL");

                    b.HasKey("ItemSeq");

                    b.HasIndex("SaleCisInvcNo");

                    b.ToTable("SaleItem");
                });

            modelBuilder.Entity("ZRA_VSDC_API.Models.SaleItem", b =>
                {
                    b.HasOne("ZRA_VSDC_API.Models.Sale", null)
                        .WithMany("ItemList")
                        .HasForeignKey("SaleCisInvcNo");
                });

            modelBuilder.Entity("ZRA_VSDC_API.Models.Sale", b =>
                {
                    b.Navigation("ItemList");
                });
#pragma warning restore 612, 618
        }
    }
}
