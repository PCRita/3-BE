using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D04_LINQ
{

    class NumbersGreaterOrEqualTo10
    {
        #region Constructor
        public NumbersGreaterOrEqualTo10()
        {

             //declarar uma lista generica  de inteiros
             List<int> randomList = new List<int>();

            //chamar o metodo para criar a lista enviando a lista vazia
            CreateList(randomList);

            //chamar o metoddo para filtrar e listar, enviando a lista ja preenchida
            FilterAndShowListMethodSyntax(randomList);
            FilterAndShowListQuerySyntax(randomList);
        }
        #endregion

        #region Create random numeric list
        public void CreateList(List<int>randomList)
        {
            Random rnd = new Random();

            for (int i = 0; i < 10; i++)    //10 vezes
            {
                int random = rnd.Next(1, 50);   //aleatorios entre 1 e 50
                randomList.Add(random); //adicionar a List o aleatorio

            }

        }
        #endregion

        #region Filter and show the random list (method syntax)
        public void FilterAndShowListMethodSyntax(List<int> randomList)
        {
            var numbers = randomList.Where(n => n >= 10).OrderBy(n => n);

            Console.WriteLine("NumbersGreaterOrEqualTo10 - Method Syntax\n");

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }

        #endregion

        #region Filter and show the random list (query syntax)
        public void FilterAndShowListQuerySyntax(List<int> randomList)
        {
            //var numbers = randomList.Where(n => n >= 10).OrderBy(n => n);
            var numbers =
                from number in randomList
                where number >= 10
                orderby number
                select number;

            Console.WriteLine("\n\nNumbersGreaterOrEqualTo10 - Query Syntax\n");

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
        #endregion
    }
}

