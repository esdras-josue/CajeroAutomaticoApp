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
            string tipo;
            double montoMinimo;

            Console.WriteLine("Ingrese el tipo de cuenta que desea crear: ");
            tipo = Console.ReadLine();
            Console.WriteLine("Ingrese el monto que va depositar, para la cuenta premiun es 1500");
            montoMinimo = int.Parse(Console.ReadLine());

            Cuenta usuario = new CuentaPremiun(tipo,montoMinimo);
            
            usuario.Tipo = tipo;
            usuario.SaldoMinimo = montoMinimo;

            
            Console.WriteLine("Tipo Cuenta: " + usuario.Tipo);
            Console.WriteLine("Saldo Actual: " + usuario.SaldoMinimo);
            Console.WriteLine("Cuanto quiere depositar: ");
            double cantidad = int .Parse(Console.ReadLine());   
            usuario.Depositar(cantidad);
            Console.WriteLine("Saldo actual: "+usuario.Saldo);
            Console.WriteLine("Cuenta creada exitosamente: ");

            Console.ReadKey();
        }
    }
}
