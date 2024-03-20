using CajeroAutomaticoApp.ClasesUsuario;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutomaticoApp
{
    public abstract class Cuenta
    {
        public double Saldo { get; set; }
        public string IdCuenta { get; set; }
        public string IdPropietario { get; set; }
        public string FechaCreacion { get; set; }
        public Cliente UsuarioCliente { get; set; }
        public string Nombre {  get; set; }
        public Cuenta() { }

        public Cuenta(string nombre,double saldo,string idCuenta,
            string idPropietario, string fecha)
        { 
            //UsuarioCliente = usuarioCliente;
            Nombre = nombre;
            Saldo = saldo;
            IdCuenta = idCuenta;
            IdPropietario = idPropietario;
            FechaCreacion = fecha;   
        }

        public abstract void Depositar(double deposito);
        public abstract void Retirar(double retiro);

    }
}
