using DistribuicaoLucorAPI.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistribuicaoLucorAPI.Models
{
    public class DistribuicaoResponse //: IDistribuicaoResponse
    {
        
        public int id { get; set; }
        public List<IParticipacao> participacoes { get; set; }
        public string total_de_funcionarios { get; set; }
        public string total_distribuido { get; set; }
        public string total_disponibilizado { get; set; }
        public string saldo_total_disponibilizado { get; set; }

    }
}
