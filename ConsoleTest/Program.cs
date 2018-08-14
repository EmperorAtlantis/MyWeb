using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dao;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            using (DataModel data=new DataModel())
            {
                data.SaveChanges();
            }
            Console.WriteLine("ok");
            Console.Read();
        }
    }
}
