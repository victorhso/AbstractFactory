using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    //Fabrica concreta (Concrete Factory) 
    public class SQLfactory :DBfactory
    {
        public override DBcommand createCommand()
        {
            return new SQLcommand();
        }

        public override DBconnection createConnection()
        {
            return new SQLconnection();
        }
    }
}
