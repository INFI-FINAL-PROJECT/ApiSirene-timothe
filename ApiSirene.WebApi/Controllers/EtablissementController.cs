using ApiSirene.Logic.Repository;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiSirene.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EtablissementController : ControllerBase
    {
        private readonly IrecupRepositorie _irecupRepositorie;
        public EtablissementController(IrecupRepositorie irecupRepositorie)
        {
            _irecupRepositorie = irecupRepositorie;
        }
        // GET: api/<EtablissementController>
        [HttpGet]
        public async Task<IActionResult> Get(CancellationToken cancellationToken)
        {
            var getAll = await _irecupRepositorie.FetchAll(cancellationToken);
            return Ok(getAll);
        }


        // GET api/<EtablissementController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}


    }
}
