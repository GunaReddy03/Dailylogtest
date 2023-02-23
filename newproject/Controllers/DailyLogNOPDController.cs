using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using newproject.Models;
using newproject.Services;
using newproject.ViewModel;
using System;

//namespace newproject.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class DailyLogNOPDController : ControllerBase
//    {
//        private IAncOpdService ancOpdService;
//        private IDailyLogServices dialylogService;

//        public DailyLogNOPDController(IAncOpdService ancOpdService, IDailyLogServices dialylogService)
//        {
//            this.ancOpdService = ancOpdService;
//            this.dialylogService = dialylogService;
//        }

//        [HttpGet]
//        [Route("GetDailyLogNOPD")]
//        public IActionResult GetDailyLogNOPD()
//        {
//            //var result = service.GetAll();
//            return Ok();
//        }


//        [HttpPost("AddDailyLogNOPD")]
//        public IActionResult AddDailyLogNOPD([FromBody] DailyLogNOPDViewModel DLNVM)
//        {
//            System.Diagnostics.Debug.WriteLine("in AddDailyLogNOPD");
//            System.Diagnostics.Debug.WriteLine(DLNVM);
//            System.Diagnostics.Debug.WriteLine(DLNVM.AncOpd.contactNumber);
//            //System.Diagnostics.Debug.WriteLine(DLNVM.DailyLog);


//            if (DLNVM.AncOpd != null)
//            {
//                System.Diagnostics.Debug.WriteLine("in save DailyLog");
//                DailyLog myobj = dialylogService.AddDailyLog(DLNVM.AncOpd.DailyLog);

//                System.Diagnostics.Debug.WriteLine("in save AncOpd");
//                DLNVM.AncOpd.DailyLog = myobj;
//                //ancOpdService.AddANC(DLNVM.AncOpd);
//            }
//            //service.AddDailyLogNOPD(DLNVM);
//            return Ok(DLNVM);
//        }
//    }
//}
