using CajeroAutomaticoApp.ClasesUsuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutomaticoApp
{
    public class CuentaPremiun : Cuenta
    {
        public CuentaPremiun() { }
        public CuentaPremiun( string nombre,double saldo,
            string idCuenta, string idPropietario, string fecha) 
            : base(nombre,saldo, idCuenta, idPropietario, fecha)
        {
            /*El saldo minimo para que la cuenta premiun 
             sea creada es de un monto
             minimo de 1500 lps*/
            if (saldo >= 1500)
            {
                Saldo += saldo;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente, el saldo minimo para" +
                    "crear una cuenta premiun es 1500.00lps");
            }   
        }
        public override void Depositar(double deposito)
        {
            if(deposito > 0) 
            {
                Saldo += deposito;
                //Console.WriteLine("Deposito realizado exitosamente.");
            }
            else
            {
                Console.WriteLine("La transaccion no pudo ser realizada, intente de nuevo");
            }
        }
        public override void Retirar(double retiro)
        {
            if(Saldo > 1500)
            {
                Saldo -= retiro;
                //Console.WriteLine("Retiro realizado exitosamente.");
            }
            else
            {
                Console.WriteLine("La transaccion no pudo ser realizada, intente de nuevo");
            }
        }
        public override string ToString()
        {
            string respuesta = "Id Cuenta: " + base.IdCuenta +
                "\nNombre Propietario: " + base.UsuarioCliente +
                "\nBalance: " + base.Saldo;
            return respuesta;
        }

    }
}
