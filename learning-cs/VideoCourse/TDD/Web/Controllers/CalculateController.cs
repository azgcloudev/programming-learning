using Domain;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculateController : ControllerBase
    {
        [HttpGet("Add/{left}/{right}")]
        public int Get(int left, int right)
        {
            throw new NotImplementedException();
        }
    }
}
