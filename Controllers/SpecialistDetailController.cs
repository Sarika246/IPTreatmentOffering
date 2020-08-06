using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IPTreatmentOffering.Models;
using Microsoft.AspNetCore.Mvc;

namespace IPTreatmentOffering.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpecialistDetailController : ControllerBase
    {
        static readonly log4net.ILog _log4net = log4net.LogManager.GetLogger(typeof(SpecialistDetailController));
        private List<SpecialistDetail> specialist = new List<SpecialistDetail>()
            {
                new SpecialistDetail
                {
                    Name="Dr. Rohit Sharma",
                    AreaOfExpertise="Orthopaedics",
                    ExperienceInYears=5,
                    ContactNumber="7017325296"
                },
                new SpecialistDetail
                {
                    Name="Dr. Upadhyay",
                    AreaOfExpertise="Urology",
                    ExperienceInYears=10,
                    ContactNumber="7251910796"
                },
                 new SpecialistDetail
                {
                    Name="Dr. Mishra",
                    AreaOfExpertise="Urology",
                    ExperienceInYears=7,
                    ContactNumber="9876543210"
                },
                  new SpecialistDetail
                {
                    Name="Dr.Gupta",
                    AreaOfExpertise="Orthopaedics",
                    ExperienceInYears=11,
                    ContactNumber="6549871235"
                }
        };
      
        [HttpGet]
        public List<SpecialistDetail> Get()
        {
            _log4net.Info("Specialist Get Method");
            return specialist;
        }

       
    }
}
