using Angband.Core;
using Microsoft.AspNetCore.Mvc;

namespace Angband.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SumController : ControllerBase
    {
        [HttpGet]
        public long Get([FromQuery] int[] n)
        {
            var somme = new Somme(n);
            return somme.Resultat;
        }
    }
}