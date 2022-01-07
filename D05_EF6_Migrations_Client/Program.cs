using System;
using System.Data.Entity;
using D05_EF6_Migrations_DAL;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D05_EF6_Migrations_Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new
NullDatabaseInitializer<BibliotecaContext>());

            // Executar só a 1ª vez
            InserirEditora();
            InserirLivro();

            Console.Write("Registos inseridos com sucesso!");

            Console.ReadKey();
        }

        public static void InserirEditora()
        {

            var editora = new Editora
            {
                EditoraNome = "Teste"
            };

            using (var context = new BibliotecaContext())
            {
                context.Editora.Add(editora);
                context.SaveChanges();
            }

        }

        public static void InserirLivro()
        {
            var livro = new Livro
            {
                ISBN = "123456789",
                Titulo = "Livro do teste",
                EditoraID = 1
            };

            using (var context = new BibliotecaContext())
            {
                context.Livro.Add(livro);
                context.SaveChanges();
            }
        }
    }

}
    
