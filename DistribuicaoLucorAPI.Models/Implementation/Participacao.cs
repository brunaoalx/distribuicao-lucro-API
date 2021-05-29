using DistribuicaoLucorAPI.Models.Interface;
using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace DistribuicaoLucorAPI.Models
{
    public class Participacao : IParticipacao
    {
        [Key]
        [JsonIgnore]
        public int id { get; set; }
        public string matricula { get; set; }
        public string nome { get; set; }
        public string valor_da_participacao { get; set; }

    }
}
