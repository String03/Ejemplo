using Operacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a, b;
            int result = 0;

            Division op = new Division();
            op.MessageHandler = ShowMessage;

            Console.WriteLine("Ingrese el operador 1");
            a = Console.ReadLine();


            Console.WriteLine("Ingrese el operador 2");
            b = Console.ReadLine();

            result = op.Divide(Convert.ToInt32(a), Convert.ToInt32(b));
            Console.WriteLine($"Resultado: {result}");

            Console.ReadKey();

        }


        public static void ShowMessage(int a, int b)
        {
            Console.WriteLine($"División entre cero, {a} - {b}");
        }
    }
}
