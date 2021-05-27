using DistribuicaoLucorAPI.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistribuicaoLucroAPI.Business.Interface
{
    public interface IDistribuidorBusiness
    {


        List<IDistribuicaoResponse> EfetuaDistribuicao(decimal valorLucroDistribuir);


    }
}
