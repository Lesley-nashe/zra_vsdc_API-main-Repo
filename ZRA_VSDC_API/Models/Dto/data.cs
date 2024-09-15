using System;

namespace ZRA_VSDC_API.Models.Dto;

public class Data
{
    public static List<Code> codes = [
            new() {
                TPin=1, BHFID=4, LastReqDt=DateTime.Now, CdCls="", CdClsNm="", Cd="", CdNm="", 
                UserDfnNm1=""},
            new() {
                TPin=2, BHFID=5, LastReqDt=DateTime.Now, CdCls="", CdClsNm="", Cd="", CdNm="", 
                UserDfnNm1=""},
        ];

    public static List<Item> items = [
        new () {
            TPin=1, BHFID=1, Bcd ="", ItemCd="",ItemClsCd="",ItemTyCd=1,ItemNm="",ItemStdNm="",
            OrgnNatCd="",PkgUnitCd="",QtyUnitCd="",VatCatCd="",IplCatCd="",TlCatCd="",ExciseTxCatCd="",
            BtchNo="",DftPrc = 2.5,AddInfo="",SftyQty=0,IsrcAplcbYn="",UseYn="",RegrNm="",RegrId="",
            ModrNm="",ModrId=""
            },
        new () {
            TPin=2, BHFID=2, Bcd ="", ItemCd="",ItemClsCd="",ItemTyCd=2,ItemNm="",ItemStdNm="",
            OrgnNatCd="",PkgUnitCd="",QtyUnitCd="",VatCatCd="",IplCatCd="",TlCatCd="",ExciseTxCatCd="",
            BtchNo="",DftPrc = 2.5,AddInfo="",SftyQty=0,IsrcAplcbYn="",UseYn="",RegrNm="",RegrId="",
            ModrNm="",ModrId=""
            },
            new () {
            TPin=3, BHFID=3, Bcd ="", ItemCd="",ItemClsCd="",ItemTyCd=3,ItemNm="",ItemStdNm="",
            OrgnNatCd="",PkgUnitCd="",QtyUnitCd="",VatCatCd="",IplCatCd="",TlCatCd="",ExciseTxCatCd="",
            BtchNo="",DftPrc = 2.5,AddInfo="",SftyQty=0,IsrcAplcbYn="",UseYn="",RegrNm="",RegrId="",
            ModrNm="",ModrId=""
            }
    ];

    public static List<Device> devices = [
        new() {
            TPin=1, TaxprNm="", BsnsActv="", BhfId="",BhfNm="",BhfOpenDt=DateTime.Now,PrvncNm="",
            DstrtNm="", SctrNm="", LocDesc="", HqYn="", MgrNm="", MgrTelNo="", MgrEmail="", SdcId="",
            MrcNo="", LastPchsInvcNo=1, LastSaleRcptNo=1, LastInvcNo=1, LastSaleInvcNo=1, LastTrainInvcNo=1,
            LastProfrmInvcNo=1, LastCopyInvcNo=1
        },
        new() {
            TPin=1, TaxprNm="", BsnsActv="", BhfId="",BhfNm="",BhfOpenDt=DateTime.Now,PrvncNm="",
            DstrtNm="", SctrNm="", LocDesc="", HqYn="", MgrNm="", MgrTelNo="", MgrEmail="", SdcId="",
            MrcNo="", LastPchsInvcNo=2, LastSaleRcptNo=2, LastInvcNo=2, LastSaleInvcNo=2, LastTrainInvcNo=2,
            LastProfrmInvcNo=2, LastCopyInvcNo=2
        }
    ];

    public static List<Import> imports = [
        new() {
            TaskCd="", DclDe=1, ItemSeq=1, DclNo="", HsCd="", ItemNm="", ImptItemsttsCd="", OrgnNatCd="",
            ExptNatCd="", Pkg=1, PkgUnitCd="", Qty=1, QtyUnitCd="", TotWt=1.2, NetWt=1.2, SpplrNm="", AgntNm="",
            InvcFcurAmt=1.2, InvcFcurCd="", InvcFcurExcrt=1.2
        },
        new() {
            TaskCd="", DclDe=2, ItemSeq=2, DclNo="", HsCd="", ItemNm="", ImptItemsttsCd="", OrgnNatCd="",
            ExptNatCd="", Pkg=2, PkgUnitCd="", Qty=2, QtyUnitCd="", TotWt=2.2, NetWt=2.2, SpplrNm="", AgntNm="",
            InvcFcurAmt=2.2, InvcFcurCd="", InvcFcurExcrt=2.2
        },
    ];
//--------------------------------------------------------------------Dynamic Get and Save Stock Item------------------------------------------------------------------
   /* private static List<StockItem> _stockItems = new List<StockItem>(); //create new stock Item list
    public static List<StockItem> GetStockItems() => _stockItems;  //Get all Stock Items

    public static void AddStockItem(StockItem item)  //Add item to created stock Item list
        {
            _stockItems.Add(item);
        }

    public static void AddImportItem(string tpin, string bhfId, ImportItem newItem)  // Add a new ImportItem to an existing StockItem
        {
            var stockItem = _stockItems.Find(s => s.Tpin == tpin && s.BhfId == bhfId);
            if (stockItem != null)
            {
                stockItem.ImportItemList.Add(newItem);
            }
        }

    // Save Stock Items
    public static void SaveStockItems(SaveStockRequest saveRequest)
        {
            foreach (var item in saveRequest.ItemList)
            {
                AddStockItem(new SaveStockItem
                {
                    Tpin = saveRequest.Tpin,
                    BhfId = saveRequest.BhfId,
                    // Populate other fields based on saveRequest and item
                    ItemSeq = item.ItemSeq,
                    ItemCd = item.ItemCd,
                    itemNm = item.ItemNm,
                    pkgUnitCd = item.
                });
            }
        }*/

        public static List<GetStockItem> GetStockItems = new()
        {
            new GetStockItem
            {
                Tpin = "",
                BhfId = "",
                TaskCd = 0,
                DclDe = "",
                ImportItemList = new List<ImportItem>
                {
                    new ImportItem
                    {
                        ItemSeq = 0,
                        HsCd = "",
                        ItemClsCd = "",
                        ItemCd = "",
                        ImptItemSttsCd = "",
                        Remark = "",
                        ModrNm = "0.0",
                        ModrId = ""
                    },
                    new ImportItem
                    {
                        ItemSeq = 0,
                        HsCd = "",
                        ItemClsCd = "",
                        ItemCd = "",
                        ImptItemSttsCd = "",
                        Remark = "",
                        ModrNm = "0.0",
                        ModrId = ""
                    }
                }
            }
        };

        public static List<SaveStockRequest> SaveStockItems = new()
        {
            new SaveStockRequest
            {
                Tpin = "",
                BhfId = "",
                SarNo = 0,
                OrgSarNo = 0,
                RegTyCd = "",
                SarTyCd = "",
                OcrnDt = "",
                TotItemCnt = 0,
                TotTaxblAmt = 0.0M,
                TotTaxAmt = 0.0M,
                TotAmt = 0.0M,
                RegrId = "",
                RegrNm = "",
                ModrNm = "",
                ModrId = "",
                ItemList = new List<SaveStockItem>
                {
                    new SaveStockItem
                    {
                        ItemSeq = 0,
                        ItemCd = "",
                        ItemClsCd = "",
                        ItemNm = "",
                        PkgUnitCd = "",
                        QtyUnitCd = "",
                        Qty = 0.0M,
                        Prc = 0.0M,
                        SplyAmt = 0.0M,
                        TaxblAmt = 0.0M,
                        VatCatCd = "",
                        TaxAmt = 0.0M,
                        TotAmt = 0.0M
                    }
                }
            }
        };

        public static List<SaveStockMasterRequest> SaveStockMasters = new()
        {
            new SaveStockMasterRequest
            {
                Tpin = "",
                BhfId = "",
                RegrId = "",
                RegrNm = "",
                ModrNm = "",
                ModrId = "",
                StockItemList = new List<MasterStockItem>
                {
                    new MasterStockItem
                    {
                        ItemCd = "",
                        RsdQty = 0.0
                    },
                    new MasterStockItem
                    {
                        ItemCd = "",
                        RsdQty = 0.0
                    }
                }
            }
        };

//----------------------------------------------------------------------------------------------------------------------------------------------------------
        public static List<Sale> sales = new List<Sale>();   //Sales list

//-------------------------------------------------------------------------------------
    public static List<Item> ItemList { get; set; } = new List<Item>();  //Temporary list to hold created items
    public static List<Purchase> PurchaseList { get; set; } = new List<Purchase>(); // Added PurchaseList
    
};

