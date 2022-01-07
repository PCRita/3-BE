using Microsoft.JScript;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D02_Interfaces
{
    //herda e implementa o interface
    class User : IAuthentication
    {
        #region Variables
        //variavel de suporte a classe
        string message;
        #endregion

        #region Properties
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        #endregion

        #region Methods
        public void Exit()
        {
            message = "A sair.";
            Mensage(message, "\n\n");
        }

        public void Mensage(string message, string startLine = "", string endLine = "")
        {
            Console.Write($"{startLine} {message} {endLine}");
        }

        public bool Validate(string userName, string userPassword)
        {

            if (userName == "mrs" && userPassword == "123")
            {
                message = "ok";
                Mensage(message, "\n\n", "\n");
                return true;
            }
            else
            {
                message = "NOK";
                Mensage(message, "\n\n", "\n");
                return false;
            }

        }
        #endregion

        #region Constructors
        public User()
        {
            UserName = string.Empty;
            UserPassword = string.Empty;
        }

        public User(string userName, string userPassword)
        {
            UserName = userName;
            UserPassword = userPassword;
        }

        #endregion
    }

}
