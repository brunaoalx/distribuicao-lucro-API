using DistribuicaoLucorAPI.Models.Implementation;
using DistribuicaoLucrosAPI.DataAccess;
using DistribuicaoLucrosAPI.DataAccess.Interfaces;
using DistribuicaoLucrosAPI.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistribuicaoLucroAPI.Business.Implementation
{
    public class FuncionarioBusiness
    {


        private readonly DataContext dataContext;
        private readonly FuncionarioRepository funcionarioRepository;

        public FuncionarioBusiness(DataContext context)
        {
            dataContext = context;
            funcionarioRepository = new FuncionarioRepository(context);
        }


        public async Task<string> InsereFuncionario(List<Funcionario> funcionarios)
        {

            foreach (var funcionario in funcionarios)
            {

                var ret = await funcionarioRepository.InsereFuncionario(funcionario);

                if (ret != "ok")
                {
                    var erro = string.Format("Erro ao inserir funcionario nome:{0}, matricula: {1} ", funcionario.nome, funcionario.matricula);
                    return erro;
                }

            }

            return "ok";

        }


        public async Task<List<Funcionario>> ListarFuncionarios()
        {

            return await funcionarioRepository.SelecionarTodosFuncionarios();

        }





    }
}
