using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    // Produto concreto (Concrete Product)
    public class SQLcommand : DBcommand
    {
        public override void Execute()
        {
            //Implementação
            Console.WriteLine("Método Execute() de SQLcommand foi chamado!");
        }
    }
}
