using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace crud.api
{
    [Route("api/[controller]")]
    [ApiController]
    public class CrudController : ControllerBase
    {
        public IActionResult Get() 
        {
            var data = new { name = "name" };
            return new JsonResult(data);
        }
    }
}
