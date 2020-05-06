using System;
using System.Collections.Generic;
using System.Linq;
namespace PixForce.Dtos
{
    public class EstoqueDto
    {
        public int Id { get; set; }
        public int CodigoCliente { get; set; }
        public string NomeCliente { get; set; }
        public int QtdEstoque { get; set; }
    }
}
