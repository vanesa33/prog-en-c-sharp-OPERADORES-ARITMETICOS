using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace operadores_aritmes
{
    class Program
    {
        static void Main(string[] args)
        {
            //operadores aritmeticos

            double num, pot, resultado;

            Console.WriteLine("Digite el numero que quiere elevar: ");
            num = NewMethod();

            Console.WriteLine("digite a la potencia que quiera elevar: ");
            pot = Convert.ToDouble(Console.ReadLine());

            resultado = Math.Pow(num, pot);
            Console.WriteLine("el resultado es: "+ resultado);
            Console.ReadKey();


        }

        private static double NewMethod()
        {
            return Convert.ToDouble(Console.ReadLine());
        }
    }
}
