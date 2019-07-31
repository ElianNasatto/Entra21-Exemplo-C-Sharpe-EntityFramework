using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo00
{
    //Tudo entre [ esse negocio ] se chama " D A T A    A T T R I B U T E "
    [Table("animais")]
    public class Animal
    {
        [Key] // Define como chave primaria esta coluna
        [Column("id")]
        // Pode ser feito assim tb : [Key,Column("id")]
        public int Id { get; set; }

        [Column("nome")]
        public string Nome { get; set; }


        [Column("extinto")]
        public bool Extinto { get; set; }

        [Column("peso")]
        public decimal Peso { get; set; }
        //Esta propriedade da classe nao sera criada no banco de dados
        //[NotMapped]
        //public decimal IMC { get; set; }
    }
}
