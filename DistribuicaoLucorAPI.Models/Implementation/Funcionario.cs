using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistribuicaoLucorAPI.Models.Implementation
{
    public class Funcionario
    {
        public int id { get; set; }
        public string matricula { get; set; }
        public string nome { get; set; }
        public string area { get; set; }
        public string cargo { get; set; }
        public string salario_bruto { get; set; }
        public string data_de_admissao { get; set; }
    }
}
