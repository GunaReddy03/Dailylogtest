using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using newproject.Services;
using newproject.ViewModel;

namespace newproject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AncOpdController : ControllerBase
    {
        private IAncOpdService service;
        public AncOpdController(IAncOpdService service)
        {
            this.service = service;
        }
        [HttpGet]
        [Route("GetAllANCOPD")]
        public IActionResult GetAllANc()
        {
            var result = service.GetAll();
            return Ok(result);
        }
        [HttpPost]
        [Route("AddANCOPD")]
        public IActionResult AddAnc([FromBody] AncOpdViewModel Anc)
        {
            service.AddANC(Anc);
            return Ok(Anc);
        }
    }
}
