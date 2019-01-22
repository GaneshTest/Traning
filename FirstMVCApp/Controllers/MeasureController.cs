using FirstMVCApp.Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace FirstMVCApp.Controllers
{
    public class MeasureController : Controller
    {
        public MeasureController()
        {

        }
        private IMeasureService _measureService;
        public MeasureController(IMeasureService measureService)
        {
            _measureService = measureService;
        }
        public void GetMeasure()
        {
            _measureService.GetHedMeasures();
        }
    }
}
