using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Estudiante> lista = new List<Estudiante>();
            lista.Add(new Estudiante(1, "Pedro", "Reyes", 20));
            lista.Add(new Estudiante(2, "Pablo", "Suarez", 40));
            lista.Add(new Estudiante(3, "Fernando", "Ganoza", 30));
            lista.Add(new Estudiante(4, "Mateo", "Messi", 10));
            lista.Add(new Estudiante(5, "Carlos", "Tevez", 45));
            imprimir(lista);
            Console.WriteLine("------------------");
            //List<Estudiante> lista1 = lista.OrderBy(x => x.edad).ToList();
            //imprimir(lista1);
            //Console.WriteLine("------------------");
            //List<Estudiante> lista2 = lista.OrderByDescending(x => x.edad).ToList();
            //imprimir(lista2);

            lista.RemoveAll(x => x.codigo == 3);
            imprimir(lista);



            Console.ReadKey();
        }

        public static void imprimir(List<Estudiante> lista)
        {
            foreach (Estudiante e in lista)
            {
                Console.WriteLine($"Id : {e.codigo} - N: {e.nombre} - A: {e.apellido} - E: {e.edad}");
            }
        }

    }
}
