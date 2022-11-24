using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace LojaDesapega10.Models
{
    public class Produto
    {
        public int Id { get; set; }

        public String Nome { get; set; }

        public String Descricao { get; set; }

        public int Preco { get; set; }

        [DataType(DataType.Date)]
        public DateTime Data { get; set; }

    }
}
