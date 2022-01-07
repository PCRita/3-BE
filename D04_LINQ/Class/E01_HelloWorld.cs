using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D04_LINQ
{

    /*
     Escrevero famoso Hello World em LINQ, usando query e method syntax
    */

    class HelloWorld
    {
        
        #region Method Syntax
        public void HelloWorldMethodSyntax()
        {
            //1.Criar um array de strings
            string[] words =
            {
                "method",
                "hello",
                "wonderfull",
                "linq",
                "beautiful",
                "world"
            };

            //2.Filtrar: palavras de comprimento igual a 5
            var shortWords = words
                .Where(word => word.Length == 5)
                .OrderByDescending(word => word);

            //Mostrar tudo
            //var shortWords = words.Select(word => word);

            //3.Listar o array filtrado
            foreach (var item in shortWords)
            {
                Console.WriteLine(item.ToUpper());
            }

        }

        #endregion

        #region Query Syntax
        public void HelloWorldQuerySyntax()
        {
            //1.Criar um array de strings
            string[] words =
            {
                "method",
                "hello",
                "wonderfull",
                "linq",
                "beautiful",
                "world"
            };

            //2.Filtrar: palavras de comprimento igual a 5
            var shortWords =
                from word in words
                where word.Length == 5
                //orderby word descending
                select word;

            //3.Listar o array filtrado
            foreach (var item in shortWords)
            {
                Console.WriteLine(item.ToUpper());
            }

        }
        #endregion

    }

}
