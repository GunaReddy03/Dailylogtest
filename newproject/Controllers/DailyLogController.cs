using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using newproject.Services;
using newproject.ViewModel;

namespace newproject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DailyLogController : ControllerBase
    {
        private IDailyLogServices _services;
        public DailyLogController(IDailyLogServices services)
        {
            _services = services;
        }
        [HttpGet("GetAllDailyLogs")]
        public IActionResult GetAllDailyLogs()
        {
            var result = _services.GetAll();
            return Ok(result);
        }
        [HttpPost("AddDailyLogs")]
        public IActionResult AddDailyLog([FromBody] DailyLogViewModel DLVM)
        {
            _services.AddDailyLog(DLVM);
            return Ok(DLVM);
        }
    }
}
