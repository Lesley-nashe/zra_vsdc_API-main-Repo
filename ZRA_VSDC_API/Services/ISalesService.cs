using System;
using ZRA_VSDC_API.Models;

namespace ZRA_VSDC_API.Services;

public interface ISalesService
{
     Task<SaveStockRequest> CreateStockRequest(Sale sale);

     Task<SaveStockMasterRequest> CreateStockMasterRequest(Sale sale);

}
