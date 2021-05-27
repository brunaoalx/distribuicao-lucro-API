using DistribuicaoLucorAPI.Models.Implementation;
using DistribuicaoLucorAPI.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistribuicaoLucrosAPI.DataAccess.Interfaces
{
    public interface IFuncionarioRepository
    {

        public List<Funcionario> SelecionarTodosFuncionarios();


    }
}
