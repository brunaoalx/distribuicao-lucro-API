using DistribuicaoLucorAPI.Models.Implementation;
using DistribuicaoLucorAPI.Models.Interface;
using DistribuicaoLucrosAPI.DataAccess.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistribuicaoLucrosAPI.DataAccess.Repositories
{
    public class FuncionarioRepository 
    {

        private readonly DataContext dataContext;

        public FuncionarioRepository(DataContext context)
        {
            dataContext = context;
        }

        public async Task<List<Funcionario>> SelecionarTodosFuncionarios()
        {
            return await dataContext.Funcionarios.ToListAsync();

        }

        
        public async Task<string> InsereFuncionario(Funcionario funcionario)
        {
            try
            {
                await dataContext.Funcionarios.AddAsync(funcionario);
                await dataContext.SaveChangesAsync();

                return "ok";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }


        }


    }
}
