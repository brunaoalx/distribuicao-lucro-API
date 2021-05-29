using DistribuicaoLucorAPI.Models.Implementation;
using DistribuicaoLucroAPI.Business.Implementation;
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
    public class FuncionarioController : ControllerBase
    {

        private DataContext dataContext;
        private FuncionarioBusiness funcionarioBusiness;
        public FuncionarioController(DataContext context)
        {
            dataContext = context;
            funcionarioBusiness = new FuncionarioBusiness(context);
        }

        // GET: api/<FuncionarioController>
        [HttpGet]
        public async Task<List<Funcionario>> Get()
        {
            return await funcionarioBusiness.ListarFuncionarios();
        }

        // GET api/<FuncionarioController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<FuncionarioController>
        [HttpPost]
        public async void Post([FromBody] List<Funcionario> funcionarios)
        {

            await funcionarioBusiness.InsereFuncionario(funcionarios);


        }

        // PUT api/<FuncionarioController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<FuncionarioController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
