using DistribuicaoLucorAPI.Models.Interface;
using System;

namespace DistribuicaoLucorAPI.Models
{
    public class Participacao : IParticipacao
    {
        public int id { get; set; }
        public string matricula { get; set; }
        public string nome { get; set; }
        public string valor_da_participacao { get; set; }

    }
}
