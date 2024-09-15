using System.Collections;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ZRA_VSDC_API.Models;
using ZRA_VSDC_API.Models.Dto;

namespace ZRA_VSDC_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CodesController : ControllerBase
    {

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<Code>> GetCodes(){
            return Ok(Data.codes);
        }

    }
}
