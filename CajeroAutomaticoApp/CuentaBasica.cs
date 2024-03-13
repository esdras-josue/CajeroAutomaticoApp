using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutomaticoApp
{
    public class CuentaBasica : Cuenta
    {
        public CuentaBasica(string tipo, double saldoMinimo) : base(tipo,saldoMinimo)
        {
            /*el saldo minimo para que la cuenta basica sea
             creada es de 100 lps*/
            this.tipo = tipo;
            this.saldo = saldoMinimo;
        }         
    }
}
