using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using newproject.Services;
using newproject.ViewModel;

namespace newproject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TriageController : ControllerBase
    {
        //private IAncOpdService service;
        private ITriageservice _Triageservice;
        public TriageController(IAncOpdService service, ITriageservice triageservice)
        {
            //this.service = service;
            this._Triageservice = triageservice;
        }
        [HttpGet]
        [Route("GetALLTriage")]
        public IActionResult GetAllANc()
        {
            var result = _Triageservice.GetAll();
            return Ok(result);
        }
        [HttpPost]
        [Route("AddTriage")]
        public IActionResult AddAnc([FromBody] TriageViewModel Anc)
        {
            _Triageservice.AddANC(Anc);
            return Ok(Anc);
        }
        [HttpPut("update_Triage")]
        public IActionResult UpdateTriageById(int id, [FromBody] TriageViewModel Triage)
        {
            var update = _Triageservice.UpdateTriage(id, Triage);
            return Ok(update);
        }
    }
}
