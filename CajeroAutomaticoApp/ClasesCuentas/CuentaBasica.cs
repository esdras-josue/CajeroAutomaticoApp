using CajeroAutomaticoApp.ClasesUsuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutomaticoApp
{
    public class CuentaBasica : Cuenta
    {
        public CuentaBasica() { }
        public CuentaBasica(string nombre, double saldo,
            string idCuenta, string idPropietario, string fecha) 
            : base(nombre, saldo, idCuenta, idPropietario,fecha)
        {
            /*el saldo minimo para que la cuenta basica sea
             creada es de 100 lps*/
            
            if (saldo >= 100)
            {
                Saldo = saldo;
                Console.WriteLine("Su saldo es: " + Saldo + "lps.");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente, el saldo minimo para" +
                    "crear una cuenta basica es 100.00lps");
            }
        }
        public override void Depositar(double deposito)
        {
            if (deposito > 0)
            {
                Saldo += deposito;
                Console.WriteLine("Deposito exitoso");
            }
            else
            {
                Console.WriteLine("Su deposito no pudo ser realizado, intente de nuevo");
            }
        }
        public override void Retirar(double retiro)
        {
            if (Saldo - retiro >= 100 && retiro > 0) // la cuenta basica debe mantener un saldo minimo de 100.00lps
            {
                Saldo -= retiro;
                Console.WriteLine("Su retiro fue exitoso");
            }
            else
            {
                Console.WriteLine("Transaccion no valida, consulte su saldo");
            }
        }
        public override string ToString()
        {
            string respuesta = "Id Cuenta: " + base.IdCuenta +
                "\nNombre Propietario: " + base.Nombre +
                "\nBalance: " + base.Saldo + "lps.";
            return respuesta;
        }
    }
}
