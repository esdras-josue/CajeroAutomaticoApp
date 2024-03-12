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
        public CuentaPremiun()  : base()
        {
            /*El constructor de la cuenta premiun 
             debe tener un monto
             minimo de 1500 lps*/
             saldo = saldoMinimo;
        } 
    }
}
