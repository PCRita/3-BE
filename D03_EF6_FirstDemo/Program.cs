using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D03_EF6_FirstDemo
{

    class Program
    {

        static void Main(string[] args)
        {

            //Usar a ConnectionString
            using (var db=new GestaoFormacaoDBEntities())//Classe que herda o DbContext
            { 

                //1. intanciamos a classe linha 
                //2.preenchemos as propriedades linha 
                //3.adicionamos o objecto ao dbset linha (que representa a tabela da bd em memoria)
                //4. gravar as alteracoes no contexto  db

                #region AreaCurso
                AreaCurso areaCurso = new AreaCurso();
            
                // areaCurso01.AreaCursoID=3 é ifentity, logo nao  se pode inserir nem manipuler
                areaCurso.Area = "Soft skills";
                db.AreaCurso.Add(areaCurso);
                db.SaveChanges();
                areaCurso.Area = "Gestao";
                db.AreaCurso.Add(areaCurso);
                db.SaveChanges();
                #endregion

                #region SubareaCurso

                #endregion

                #region Curso

                #endregion

                Console.ReadKey();
            }

        }
   
    }
}
