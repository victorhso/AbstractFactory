using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class OracleFactory : DBfactory
    {
        public override DBcommand createCommand()
        {
            return new OracleCommand();
        }

        public override DBconnection createConnection()
        {
            return new OracleConnection();
        }
    }
}
