using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_Peaku
{
    class Program
    {
        static void Main(string[] args)
        {

            string hola = "15";
            int result = int.Parse(hola);
            List<List<int>> lista = new List<List<int>>();
            List<int> lista1 = new List<int>();
            lista1.Add(3);
            lista1.Add(4);
            List<int> lista2 = new List<int>();
            lista2.Add(12);
            lista2.Add(32);
            lista2.Add(89);
            List<int> lista3 = new List<int>();
            lista3.Add(0);

            lista.Add(lista1);
            lista.Add(lista2);
            lista.Add(lista3);
            List<int> data= FixMe(lista);
        }

        static List<int> FixMe(List<List<int>> myList)
        {

            List<int> newList = new List<int>();
            if (myList.Count % 2 == 0)
            { // imperative code
                foreach (List<int> item in myList)
                {
                    foreach (int element in item)
                    {
                        newList.Add(element);
                    }
                }
            }
            else
            {  // functional code
                if (myList.Count % 2 > 0) {
                    foreach (List<int> item in myList)
                    {
                        foreach (int element in item)
                        {
                            newList.Add(element);
                        }
                    }
                }
                
            }
            var listordenada = from ordenar in newList
                               orderby ordenar descending
                               select ordenar;
            return listordenada.ToList();
        }
    }
}
