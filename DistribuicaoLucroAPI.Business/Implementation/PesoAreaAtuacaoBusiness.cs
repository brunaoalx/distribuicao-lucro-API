using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistribuicaoLucroAPI.Business.Implementation
{
    public class PesoAreaAtuacaoBusiness
    {
        public Dictionary<string, int> PesoAreaAtuacao { get; set; }

        public PesoAreaAtuacaoBusiness()
        {
            CarregaPesoAreaAtuacao();
        }


        private void CarregaPesoAreaAtuacao()
        {
            PesoAreaAtuacao = new Dictionary<string, int>();
            PesoAreaAtuacao.Add("Diretoria", 1);
            PesoAreaAtuacao.Add("Contabilidade", 2);
            PesoAreaAtuacao.Add("Financeiro", 2);
            PesoAreaAtuacao.Add("Tecnologia", 2);
            PesoAreaAtuacao.Add("Serviços Gerais", 3);
            PesoAreaAtuacao.Add("Relacionamento com o Cliente", 5);
        }
    }
}
