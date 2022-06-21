using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncontrarMultiplos
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Cual es el número?");
            
            int n = int.Parse(Console.ReadLine());
            if (n <= 3)
            {
                Console.WriteLine("El número debe ser superior a 3");
                Console.ReadKey();
                return;
            }

            int Mult3 = 3;
            int Mult5 = 5;
            int sumaMultiplos = Mult3 + Mult5;

            if (n!= 4 || n!= 6)
            {
                Mult3 = 0;
                Mult5 = 0;
                sumaMultiplos = 0;
            }

            for (int i = 0; i < n / 3; i++)
            {

                Mult3 += 3;
                if (Mult3 < n)
                {
                    sumaMultiplos += Mult3;
                }

                Mult5 += 5;
                if (Mult5 < n)
                {
                    sumaMultiplos += Mult5;
                }

            }

            Console.WriteLine(sumaMultiplos);
            Console.ReadKey();
        }
    }
}
