using Microsoft.AspNetCore.Mvc;
using UdemyRestApi.Models;

namespace UdemyRestApi.Controllers
{
    [Route("api/VillaApi")]
    [ApiController]
    public class VillaApiController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Villa> GetVillas()
        {
            return
            [
                new() {Id = 1, Name = "Pool Villa" },
                new() {Id = 2, Name = "Beach Villa" }
            ];
        }
    }
}
b