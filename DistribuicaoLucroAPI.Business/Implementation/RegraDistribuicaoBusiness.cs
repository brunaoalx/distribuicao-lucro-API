using DistribuicaoLucorAPI.Models.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistribuicaoLucroAPI.Business.Implementation
{
    public class RegraDistribuicaoBusiness
    {


        PesoAreaAtuacaoBusiness PesoAreaAtuacaoBusiness;
        PesoTempoAdimissaoBusiness pesoTempoAdimissaoBusiness;
        PesoFaixaSalarialBusiness pesoFaixaSalarialBusiness;

        public RegraDistribuicaoBusiness()
        {

            PesoAreaAtuacaoBusiness = new PesoAreaAtuacaoBusiness();
            //pesoTempoAdimissaoBusiness = new PesoTempoAdimissaoBusiness();
            //pesoFaixaSalarialBusiness = new PesoFaixaSalarialBusiness();
        }


        public decimal CalculaBonus(Funcionario funcionario)
        {
            decimal valorBonus = 0;

            var pesoAreaAtuacao = PesoAreaAtuacaoBusiness.PesoAreaAtuacao[funcionario.area];

            return valorBonus;

        }





    }





}
