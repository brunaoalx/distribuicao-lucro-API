using DistribuicaoLucorAPI.Models;
using DistribuicaoLucorAPI.Models.Interface;
using DistribuicaoLucroAPI.Business.Interface;
using DistribuicaoLucrosAPI.DataAccess;
using DistribuicaoLucrosAPI.DataAccess.Interfaces;
using DistribuicaoLucrosAPI.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DistribuicaoLucroAPI.Business
{
    public class DistribuidorBusiness //: IDistribuidorBusiness
    {


        private readonly DataContext dataContext;
        private readonly FuncionarioRepository funcionarioRepository;

        public DistribuidorBusiness(DataContext context)
        {
            dataContext = context;
            funcionarioRepository = new FuncionarioRepository(context);
        }



        public async Task<DistribuicaoResponse> EfetuaDistribuicao(decimal valorLucroDistribuir)
        {

            var funcionarios = funcionarioRepository.SelecionarTodosFuncionarios();


            DistribuicaoResponse distribuicaoResponse = new DistribuicaoResponse();

            return distribuicaoResponse;

        }
    }
}
