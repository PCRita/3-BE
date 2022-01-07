using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E05_EF6_CodeFirst
{
    //tabela n
    class Post
    {

        #region Properties
        //Scalar properties
        public int PostID { get; set; } //PK+ identity
        public int BlogID { get; set; }//FK
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [Required] 
        [MaxLength(200)]
        public string Content { get; set; }
        public DateTime PostDate { get; set; }

        //Navigation property
        //1 post pode ter somente 1 blog
        public virtual Blog blog { get; set; }
       
        #endregion

        #region Methods
        public static void InsertPost()
        {
            using (var db = new BlogContext())
            {
                string newPost, newContent;

                Post post = new Post();

                //vou ter de pedir ao user para escolher o blog
                //onde vai inserir este novo post!

                //1.listar os blogs
               
                Blog.ListBlog();
                Console.WriteLine("\n\n");

                //2.Pedir ao user para escolher 1 blog, pelo numero

                //3.Verificar se esse numero de blog existe

                //3.1.Se nao existir
                //Obrigar o user a escolher 1 numero de blog existente(while)
                //OU
                //Sair e dizer ao user para repetir a operacao

                //3.2.Se existir, pedir os outros dados do podt e gravar

                Console.Write("Novo post: ");
                newPost = Console.ReadLine();

                Console.Write("Texto: ");
                newContent = Console.ReadLine();

                post.BlogID = 1; //Atencao!!Implementar
                post.Name = newPost;
                post.Content = newContent;
                db.Post.Add(post);
                db.SaveChanges();

            }

        }

        public static void ListPost()
        {
            using (var db = new BlogContext())
            {
                var query = db.Post.Select(r => r).OrderBy(r => r.PostID);

                Console.WriteLine("\n\n-----------------\nPosts\n---------------------------");

                foreach (var item in query)
                {
                    Console.WriteLine($"{item.BlogID}{item.Name}");
                }

                Console.ReadKey();

            }
        }

        #endregion
    }
}
