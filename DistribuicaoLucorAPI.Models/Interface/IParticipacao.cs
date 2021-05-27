using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistribuicaoLucorAPI.Models.Interface
{
    public interface IParticipacao
    {
        public string matricula { get; set; }
        public string nome { get; set; }
        public string valor_da_participacao { get; set; }
    }
}
