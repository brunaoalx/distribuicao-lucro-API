using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistribuicaoLucroAPI.Business.Implementation
{
    public class PesoFaixaSalarialBusiness
    {

        private const decimal salarioMinimo = 1100;
        public int pesoPorFaixaSalarial { get; private set; }

        public PesoFaixaSalarialBusiness(decimal valorSalario)
        {
            pesoPorFaixaSalarial = CalculaPesoPorFaixaSalarial(valorSalario);
        }

        public int CalculaPesoPorFaixaSalarial(decimal salario) =>
       (salario / salarioMinimo) switch
       {
           (<= 3) => 1, //Até 1 ano
            (> 3) and (<= 5) => 2, // Mais de 1 e menos de 3
            (> 5) and (<= 8) => 3, //Mais de 3 e menos de 8
            (> 8) => 5 //Mais de 8
        };


    }
}
