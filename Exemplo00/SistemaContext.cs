using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo00
{
    //Classe que usamos para acessar o banco de dados

    public class SistemaContext : DbContext
    {

        //
        public DbSet<Animal> Animais { get; set; }

        public SistemaContext() : base(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=T:\Documentos\BD_EntityFramework.mdf;Integrated Security=True;Connect Timeout=30")
        {

        }

        
    }
}
