using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutomaticoApp
{
    public class Cuenta
    {
        protected string nombreCompleto;
       //protected List<Usuario> usuarios;
        protected double saldo;
        protected double saldoMinimo;
        protected int idCuenta;
        protected int idPropietario;
        protected DateTime fechaCreacion;

        public Cuenta()
        {
            //Usuarios = new List<Usuario>();
            this.saldo += saldoMinimo;  
        }

        public double Saldo
        {
            get { return saldo; }
            set { saldo += value; }
        }
        public string NombreCompleto { get; set; }
        //public List<Usuario> Usuarios { get; set; }
        public int IdCuenta { get; set; }
        public int IdPropietario { get; set; }
        public DateTime FechaCreacion { get; set; }
        
        public void Depositar(double deposito)
        {
            if(deposito > 0)
            {
                this.saldo += deposito;
                Console.WriteLine("Deposito exitoso");
            }  
        }
        public void Retirar(double retiro)
        {
            if (this.saldo - retiro >= saldoMinimo)
            {
                this.saldo -= retiro;
                Console.WriteLine("Su retiro fue exitoso su saldo actual es " + this.saldo);
            }
            else
            {
                Console.WriteLine("Transaccion no valida, consulte su saldo");
            }   
        }
        /*public void agregarUsuario(Usuario usuario)
        {
            Usuarios.Add(usuario);
        }
        metodos para agregar y eliminar usuarios de las cuenta
        falta clase implementar clase Usuario.

        public void eliminarUsuario(Usuario usuario)
        {
            usuario.remove(usuario);
        }*/
    }
}
