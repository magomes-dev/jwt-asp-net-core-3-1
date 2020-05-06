using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PixForce.Dtos.Param
{
    public class EstoqueParamDto
    {
        [JsonIgnore] //A chave(ID) é sempre passada na URL do método API.
        public int Id { get; set; }
        public int CodigoCliente { get; set; }
        public string NomeCliente { get; set; }
        public int? QtdEstoque { get; set; }
    }
}
