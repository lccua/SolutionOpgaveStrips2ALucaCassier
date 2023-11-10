using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StripsBL.Exceptions;
using StripsBL.Managers;
using StripsBL.Model;
using StripsBL.DTOs;
using StripsREST.Mappers;

namespace StripsREST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StripsController : ControllerBase
    {
        private StripsManager stripsManager;
        private string url = "https://localhost:7238/api/strips/beheer";

        public StripsController(StripsManager stripsManager)
        {
            this.stripsManager = stripsManager;
        }

        [HttpGet("beheer/Reeks/{reeksId}")]
        public ActionResult GetReeks(int reeksId)
        {
            Reeks reeks = stripsManager.GetReeks(reeksId);
            return Ok(MapFromDomain.MapFromReeksDomain(url, reeks, stripsManager));


           
        }

    }
}
