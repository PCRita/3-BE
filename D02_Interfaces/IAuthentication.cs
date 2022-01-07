using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D02_Interfaces
{
    //Interface:
    //      nao se usam os acess modifiers: public, private, static, internal,...
    //      nao implementam propriedades, nao podem ter set
    //      nao implementam metodos, nao podem ter corpo(chaves)
    interface IAuthentication
    {
        #region Properties
        string UserName { get; }
        string UserPassword { get; }
        #endregion

        #region Methods
        bool Validate(string userName, string userPassword);
        void Exit();
        void Mensage(string message, string startLine = "", string endLine = "");

        #endregion

    }


}
