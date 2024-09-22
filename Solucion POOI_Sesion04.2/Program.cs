using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int>();
            lista.Add(10);
            lista.Add(20);
            lista.Add(50);
            lista.Add(5);
            lista.Add(90);
            lista.Add(15);
            lista.Add(50);

            //imprimir(lista);

            int cant = lista.Count;
            Console.WriteLine($"Cantidad :  {cant}");
            imprimir(lista);
            Console.WriteLine("---------------------------");

            //lista.Sort();
            //imprimir(lista);
            //Console.WriteLine("---------------------------");

            //lista.Reverse();
            //imprimir(lista);
            //Console.WriteLine("---------------------------");

            //lista.Remove(50);
            //imprimir(lista);
            //Console.WriteLine("---------------------------");


            //lista.RemoveAt(4);
            //imprimir(lista);
            //Console.WriteLine("---------------------------");

            //lista.Clear();
            //imprimir(lista);
            //Console.WriteLine("---------------------------");

            //lista.RemoveAll(x => x == 50);
            //imprimir(lista);
            //Console.WriteLine("---------------------------");

            //lista.RemoveAll(x => x % 2 == 1);
            //imprimir(lista);
            //Console.WriteLine("---------------------------");

            //lista.RemoveAll(x => x % 2 == 0);
            //imprimir(lista);
            //Console.WriteLine("---------------------------");

            //lista.RemoveRange(2, 1);
            //imprimir(lista);
            //Console.WriteLine("---------------------------");

            //int posicion = lista.IndexOf(5);
            //Console.WriteLine("Posición : " + posicion);
            //Console.WriteLine("---------------------------");

            //int posicion2 = lista.IndexOf(1);
            //Console.WriteLine("Posición 14 : " + posicion2);
            //Console.WriteLine("---------------------------");

            //int numero = lista.First();
            //Console.WriteLine($"Numero : {numero}");
            //Console.WriteLine("---------------------------");

            //int numero2 = lista.FirstOrDefault(x => x == 10);
            //Console.WriteLine($"Numero : {numero2}");
            //Console.WriteLine("---------------------------");
            //int numero3 = lista.FirstOrDefault(x => x == 20050);
            //Console.WriteLine($"Numero : {numero3}");



            Console.ReadKey();

        }

        static void imprimir(List<int> arreglo)
        {


            foreach (int i in arreglo)
            {
                Console.WriteLine(i);
            }

            //for (int i = 0; i < arreglo.Count; i++)
            //{
            //    Console.WriteLine(arreglo[i]);
            //}

            //int contador = 0;
            //while (contador < arreglo.Count)
            //{
            //    Console.WriteLine(arreglo[contador]);
            //    contador++;
            //}

        }
    }
}
