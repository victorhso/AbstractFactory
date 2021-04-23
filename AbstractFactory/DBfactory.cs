using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    //Fábrica abstrata (Abstract Factory)
    public abstract class DBfactory
    {
        public abstract DBconnection createConnection();
        public abstract DBcommand createCommand();
    }
}
