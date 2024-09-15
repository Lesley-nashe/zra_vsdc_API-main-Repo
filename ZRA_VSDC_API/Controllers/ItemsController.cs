using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using ZRA_VSDC_API.Models;
using ZRA_VSDC_API.Models.Dto;

namespace ZRA_VSDC_API.Controllers
{
    public class Response {
        public required string ResultCd {get;set;}

        public required string ResultMsg {get;set;}

        public DateTime Date {get;set;}
    }


    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<Item>> GetItems(){
            return Ok(Data.items);
        }


        [HttpGet("{TPin:int}", Name = "GetItem" )]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<Item> GetItem(int TPin)
        {
            if(TPin == 0)
            {
                return BadRequest();
            }
            var item = Data.items.FirstOrDefault(u => u.TPin == TPin);
            if(item == null) return NotFound();

            return Ok(item);
        } 

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<Item> SaveItem([FromBody]Item item)
        {
                if(item is not null)
                {
                    if(Data.items.FirstOrDefault(u => u.TPin == item.TPin) != null)
                    {
                         // Error handling when creating a item that already exists
                            ModelState.AddModelError("CustomError","Item Already Exists");
                            return BadRequest(ModelState);
                    }
                    if(item == null)return BadRequest(item);
                    Data.items.Add(item);
                    var response = new Response() 
                    {
                        ResultCd = "000",
                        ResultMsg = "It is succeeded",
                        Date = DateTime.Now
                    };
                    return Ok(response);
                } else {
                     return BadRequest("Item could not be created");
                };
        }

        [HttpPut("{TPin:int}", Name = "UpdateItem")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<Item> UpdateItem(int TPin, [FromBody] Item updateItem)
        {
            if(TPin != updateItem.TPin) return BadRequest();
            var item = Data.items.FirstOrDefault(u => u.TPin == TPin);
            if(item == null) return NotFound();
            item.ItemNm = updateItem.ItemNm;
            return Ok(item) ;
        }
    }
}
