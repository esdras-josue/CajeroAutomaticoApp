using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutomaticoApp
{
    public class CuentaBasica : Cuenta
    {
        public CuentaBasica() : base()
        {
            /*el constructor debe ser inicializado
            con un saldo minimo de 100*/
            this.saldo += saldoMinimo;
        }         
    }
}
