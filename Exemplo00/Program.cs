using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo00
{
    class Program
    {
        //Exemplo EntityFramework
        //Exemplo 00

        static void Main(string[] args)
        {
            int menu = 1;
            while (menu != 0)
            {
                Console.Clear();
                Console.WriteLine("==========  M E N U  ==========");
                Console.WriteLine("1 - Adicionar");
                Console.WriteLine("2 - Listar");
                Console.WriteLine("3 - Alterar");
                Console.WriteLine("4 - Deletar");
                Console.WriteLine("0 - Sair");
                menu = Convert.ToInt32(Console.ReadLine());

                SistemaContext contexto = new SistemaContext();
                if (menu == 1)
                {
                    Console.Clear();
                    Animal animal = new Animal();

                    #region inserir
                    Console.Write("Nome: ");
                    animal.Nome = Console.ReadLine();

                    Console.Write("Extinto?: ");
                    animal.Extinto = Convert.ToBoolean(Console.ReadLine());

                    Console.Write("Peso: ");
                    animal.Peso = Convert.ToDecimal(Console.ReadLine());

                    contexto.Animais.Add(animal);
                    try
                    {
                        contexto.SaveChanges();
                        Console.WriteLine("Registro salvo com sucesso");
                        Console.ReadLine();


                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Deu erro cara");
                    }

                    Console.ReadLine();
                    #endregion
                }
                if (menu == 2)
                {
                    Listar(contexto);
                    Console.ReadLine();
                }
                if (menu == 3)
                {
                    Listar(contexto);

                    #region alterar
                    Console.WriteLine();
                    Console.WriteLine("Qual registro deseja alterar?: ");
                    int id = Convert.ToInt32(Console.ReadLine());

                    var cachorro = contexto.Animais.First(x => x.Id == id);

                    Console.WriteLine($"Antigo nome: {cachorro.Nome} == Novo Nome:");
                    cachorro.Nome = Console.ReadLine();

                    try
                    {
                        contexto.SaveChanges();
                        Console.WriteLine("Alterado com sucesso");

                    }
                    catch (Exception)
                    {
                        Console.WriteLine("erro");
                    }
                    #endregion


                }
                if (menu == 4)
                {
                    Console.Clear();
                    #region apagar
                    Console.WriteLine("Digie o id que deseja excluir");
                    int id = Convert.ToInt32(Console.ReadLine());
                    Animal animal = contexto.Animais.Where(x => x.Id == id).First();
                    contexto.Animais.Remove(animal);
                    try
                    {
                        contexto.SaveChanges();
                        Console.WriteLine("Apagado");

                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Erro");
                    }
                    Console.ReadLine();
                    #endregion
                    #endregion
                }

            }
        }

        private static void Listar(SistemaContext contexto)
        {
            Console.Clear();

            // Obter todos os registros do banco (ObterTodos)
            List<Animal> lista = contexto.Animais.ToList();
            //.Animais.Where(x => x.Extinto == false).OrderBy(x => x.Nome).ToList();
            //Where(x => x.Extinto == false && xNome.Contains("a")
            foreach (Animal animalLista in lista)
            {
                Console.WriteLine($"Id: {animalLista.Id} Animal: {animalLista.Nome} Extinto: {animalLista.Extinto} Peso: {animalLista.Peso}");
                Console.WriteLine();
            }
        }
    }
}
