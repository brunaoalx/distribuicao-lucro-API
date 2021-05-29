using DistribuicaoLucorAPI.Models;
using DistribuicaoLucorAPI.Models.Interface;
using DistribuicaoLucroAPI.Business;
using DistribuicaoLucroAPI.Business.Implementation;
using DistribuicaoLucroAPI.Business.Interface;
using DistribuicaoLucrosAPI.DataAccess;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DistribuicaoLucroAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DistribuicaoController : ControllerBase
    {

        private DataContext dataContext;
        private DistribuidorBusiness distribuidorBusiness;

        public DistribuicaoController(DataContext context)
        {
            dataContext = context;
            distribuidorBusiness = new DistribuidorBusiness(context);
        }


        // GET: api/<DistribuicaoController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<DistribuicaoController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<DistribuicaoController>
        [HttpPost]
        public async Task<DistribuicaoResponse> Post([FromBody] decimal valorDistribuir)
        {
                        
            return await distribuidorBusiness.EfetuaDistribuicao(valorDistribuir);

        }

        // PUT api/<DistribuicaoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<DistribuicaoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
