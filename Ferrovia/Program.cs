using Ferrovia.Domain;
using System;
using System.Collections.Generic;

namespace Ferrovia
{
    class Program
    {
        static void Main(string[] args)
        {
            var sRota = "";
            var iDistancia = 0;
            
            Rota rota = new Rota();
            rota.AddRota("AB", 5);
            rota.AddRota("BC", 4);
            rota.AddRota("CD", 8);
            rota.AddRota("DC", 8);
            rota.AddRota("DE", 6);
            rota.AddRota("AD", 5);
            rota.AddRota("CE", 2);
            rota.AddRota("EB", 3);
            rota.AddRota("AE", 7);            

            Console.WriteLine("Informe a rota desejada: ");
            sRota = Console.ReadLine().ToUpper();

            iDistancia = rota.ObterDistancia(sRota);

            if (iDistancia == -1)
                Console.WriteLine("NAO EXISTE ROTA");
            else
                Console.WriteLine(iDistancia);
        }        
    }
}
