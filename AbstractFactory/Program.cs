using System;

namespace AbstractFactory
{
    class Program
    {
        //Cliente
        static void Main(string[] args)
        {
            DBfactory db = new OracleFactory();
            //DBfactory db = new SQLfactory();

            var con = db.createConnection();
            con.Open();

            var cmd = db.createCommand();
            cmd.Execute();
        }
    }
}
