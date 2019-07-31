using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo00
{
    [Table("habilidades")]
    public class Habilidade
    {
        [Key, Column("id")]
        public int Id {get; set;}

        [Column("id_animal")]
        public int IdAnimal { get; set; }

        [ForeignKey("IdAnimal")]
        public Animal Animal { get; set; }

        [Column("nome")]
        public string Nome { get; set; }
    }
}
