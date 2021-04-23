using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    //Produto concreto (Concret product)
    class SQLconnection : DBconnection
    {
        public override void Open()
        {
            //implementação
            Console.WriteLine("Método Open de SQLconnection foi chamado!");
        }
    }
}
