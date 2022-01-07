using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E05_EF6_CodeFirst
{

    class Program
    {

        static void Main(string[] args)
        {
            try
            {
                //Chamar os metodos static 
                Blog.InsertBlog();
                //Blog.ListBlog();

                Post.InsertPost();
                Post.ListPost();
                
            }
            catch (Exception)
            {
                Console.WriteLine("\n\n\nAtencao, ocorreu um erro!");
                //throw;
                
            }

            


        }

    }

}
