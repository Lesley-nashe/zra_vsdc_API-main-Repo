using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using ZRA_VSDC_API.Models;
using ZRA_VSDC_API.Models.Dto;

namespace ZRA_VSDC_API.Controllers{
    [ApiController]
    [Route("api/[controller]")]
    public class StockController : ControllerBase
    {
        private static List<SaveStockRequest> stockRequests = new List<SaveStockRequest>();
        private static List<SaveStockMasterRequest> stockMasterRequests = new List<SaveStockMasterRequest>();

        [HttpPost("saveStockItems")]
        public ActionResult SaveStockItems([FromBody] SaveStockRequest request)
        {
            if (request == null)
                return BadRequest("Invalid stock request");

            // Store the request in the list (or handle it as needed, e.g., save to a database)
            stockRequests.Add(request);

            var response = new
            {
                ResultCd = "000",
                ResultMsg = "Stock items saved successfully",
                Date = DateTime.Now
            };

            return Ok(response);
        }

        [HttpPost("saveStockMaster")]
        public ActionResult SaveStockMaster([FromBody] SaveStockMasterRequest request)
        {
            if (request == null)
                return BadRequest("Invalid stock master request");

            // Store the request in the list (or handle it as needed, e.g., save to a database)
            stockMasterRequests.Add(request);

            var response = new
            {
                ResultCd = "000",
                ResultMsg = "Stock master saved successfully",
                Date = DateTime.Now
            };

            return Ok(response);
        }
    }
}