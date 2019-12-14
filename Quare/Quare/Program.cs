using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quare
{
    class Program
    {
        static void Main(string[] args)
        {
            Quare quare = new Quare(5);
            quare.Euquare(5);
            Console.WriteLine(quare.Dequare());
            Console.WriteLine(quare.Dequare());

        }
    }
}
