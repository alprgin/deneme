using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class HesapMakinesi
    {

       
            static void Main(string[] args)
            {
                For(100);
                Console.ReadLine();
            }

            private static void For(int hedef, int n = 0)
            {
                if (n == hedef)
                {
                    return;
                }
                Console.WriteLine(n);
                For(hedef, ++n);
            }
    }
}
