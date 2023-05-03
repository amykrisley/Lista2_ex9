using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2_ex09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double p, h, r;
            int s;

            Console.Write("Digite\n1-Masculino\n2-Feminino\n");
            s = int.Parse(Console.ReadLine());

            Console.Write("Digite seu peso(em kilos: ");
            p = double.Parse(Console.ReadLine());

            Console.Write("Digite sua altura(em metros):");
            h = double.Parse(Console.ReadLine());

            r = p / Math.Pow(h, 2);

            if (s == 1)
            
                if (r < 20)
                    Console.WriteLine("Abaixo do peso.");
                else
                    if (r < 25)
                    Console.WriteLine("Peso ideal.");

                else
                    Console.WriteLine("Acima do peso.");
            
            else
            
                if (r < 19)
                    Console.WriteLine("Abaixo do peso.");
                else
                    if (r < 24)
                    Console.WriteLine("Peso ideal.");

                else
                    Console.WriteLine("Acima do peso.");
            
            
        }
    }
}
