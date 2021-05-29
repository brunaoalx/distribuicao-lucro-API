using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistribuicaoLucroAPI.Business.Implementation
{
    public class PesoTempoAdimissaoBusiness
    {

        public int pesoTempoAdimissao { get; private set; }

        public PesoTempoAdimissaoBusiness(int tempoDeTrabalho)
        {
            pesoTempoAdimissao = CalculaPesoTempoAdimissao(tempoDeTrabalho);
        }

        public int CalculaPesoTempoAdimissao(int tempoDeAdmissao) =>
        tempoDeAdmissao switch
        {
            (<= 365) => 1, //Até 1 ano
            (> 365) and (<= 1095) => 2, // Mais de 1 e menos de 3
            (> 1095) and (<= 2920) => 3, //Mais de 3 e menos de 8
            (> 2920) => 5 //Mais de 8
        };

    }
}
