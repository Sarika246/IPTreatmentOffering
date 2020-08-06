using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using IPTreatmentOffering.Models;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json.Linq;

namespace IPTreatmentOffering.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IPTreatmentPackagesController : ControllerBase
    {
      
        static readonly log4net.ILog _log4net = log4net.LogManager.GetLogger(typeof(IPTreatmentPackagesController));
       
        private List<IPTreatmentPackages> itp = new List<IPTreatmentPackages>()
            {
                new IPTreatmentPackages
                {
                    AilmentCategory="Orthopaedics",
                    TreatmentPackageName="Package1",
                    TestDetails="OPT1, OPT2",
                    Cost=2500,
                    TreatmentDuration=4
                },
                new IPTreatmentPackages
                {
                    AilmentCategory="Orthopaedics",
                    TreatmentPackageName="Package2",
                    TestDetails="OPT3, OPT4",
                    Cost=3000,
                    TreatmentDuration=6
                },
                new IPTreatmentPackages
                {
                    AilmentCategory="Urology",
                    TreatmentPackageName="Package1",
                    TestDetails="UPT1, UPT2",
                    Cost=4000,
                    TreatmentDuration=4
                },
                new IPTreatmentPackages
                {
                    AilmentCategory="Urology",
                    TreatmentPackageName="Package2",
                    TestDetails="UPT3, UPT4",
                    Cost=5000,
                    TreatmentDuration=6
                }
             };
     
        [HttpGet]
        public List<IPTreatmentPackages> Get()
        {
            _log4net.Info("IPTreatmentPackage Get Method");
            return itp;
        }

        [HttpGet("{name}")]
        public IPTreatmentPackages Get(string name)
        {
            IPTreatmentPackages package = (from p in itp
                                           where p.TreatmentPackageName == name
                                           select p).FirstOrDefault();
            return package;

        }
      
    }
}
