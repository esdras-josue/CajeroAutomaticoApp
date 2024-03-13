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
        public CuentaPremiun(string tipo, double saldoMinimo) : base(tipo,saldoMinimo)
        {
            /*El saldo minimo para que la cuenta premiun 
             sea creada es de un monto
             minimo de 1500 lps*/
            this.saldo = saldoMinimo;
            this.tipo = tipo;
        } 
    }
}
