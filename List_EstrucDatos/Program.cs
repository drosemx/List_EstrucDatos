using System;
using System.Collections;
using System.Collections.Generic;


namespace List_EstrucDatos
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> list = new List<string>();
            
            for (int i = 0; i < 100000000; i++) // Loop through List with for
            {
                list.Add("HolaMundo");
            }
            Console.WriteLine("lista llena");
            //foreach (int prime in list) // Loop through List with foreach
            //{
            //    Console.WriteLine(prime);
            //}

            //for (int i = 0; i < list.Count; i++) // Loop through List with for
            //{
            //    Console.WriteLine(list[i]);
            //}

            //Console.ReadKey();
            //Console.WriteLine("lista booleana y como se borra su contenido");
            //Console.ReadKey();
            //List<bool> listbooleano = new List<bool>();
            //listbooleano.Add(true);
            //listbooleano.Add(false);
            //listbooleano.Add(true);
            //Console.WriteLine(list.Count); // 3
            
            //Console.ReadKey();
            //listbooleano.Clear();
            //Console.WriteLine(listbooleano.Count); // 0
            Console.ReadKey();
            list.Clear();
            Console.WriteLine("lista vacia");
            Console.ReadKey();
            Console.WriteLine("casi adios");
            Console.ReadKey();
        }
    }
}
