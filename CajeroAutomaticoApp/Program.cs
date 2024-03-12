using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutomaticoApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CuentaPremiun cuenta = new CuentaPremiun();
            Console.WriteLine("Depositar: ");
            double depositar = int.Parse(Console.ReadLine());
            cuenta.Depositar(depositar);
            Console.WriteLine(cuenta.Saldo);
            Console.WriteLine("Retirar:");
            double retirar = int.Parse(Console.ReadLine()); 
            cuenta.Retirar(retirar);
            Console.WriteLine(cuenta.Saldo);
            Console.ReadKey();

        }
    }
}
