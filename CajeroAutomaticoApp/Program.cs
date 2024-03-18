using CajeroAutomaticoApp.ClasesUsuario;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutomaticoApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // crear listas como metoso para el administrador
            List<Cliente> CuentasBancarias = new List<Cliente>();
            List<Administrador> administrators = new List<Administrador>();
            int opcion = 0;
            // administrador por defecto
            Administrador admin = new Administrador();
            admin.NombreCompleto = "Esdras Peña";
            admin.NumeroIdentidad = "1621200000375";
            admin.CorreoElectronico = "esdraspea@gmail.com";
            admin.NickName = "adminesdras".ToLower();
            admin.Password = "topuser123".ToLower();
            admin.FechaNacimiento = "9/17/1999";
            admin.FechaCreacionUsuario = "3/17/2024";
            administrators.Add(admin);  

            // creacion de usuario cliente por defecto
            Cliente usuarioCliente = new Cliente();
            usuarioCliente.NombreCompleto = "Gerson Castillos";
            usuarioCliente.NumeroIdentidad = "162119950000458";
            usuarioCliente.CorreoElectronico = "gersoca@gmail.com";
            usuarioCliente.NickName = "gersoncas01".ToLower();
            usuarioCliente.Password = "3011";
            usuarioCliente.FechaNacimiento = "4/17/2004";
            usuarioCliente.FechaCreacionUsuario = "3/17/2024";
            // se crea una cuenta por defecto
            usuarioCliente.Cuenta = new CuentaBasica();
            usuarioCliente.Cuenta.Depositar(2000);
            Console.WriteLine(usuarioCliente.Cuenta.Saldo);
            // se agrega a la lista de clientes
            CuentasBancarias.Add(usuarioCliente);


            do
            {
                Console.WriteLine();
                Console.WriteLine("Cajero Automatico Del Banco T1172");
                Console.WriteLine();
                Console.WriteLine("Ingrese su nombre de Usuario");
                string nombreUser = Console.ReadLine();
                Console.WriteLine("Ingrese su contraseña");
                string contraseña = Console.ReadLine();

                if (nombreUser == admin.NickName && contraseña == admin.Password)
                {
                    Console.WriteLine();
                    Console.WriteLine("Hola " + nombreUser + "" +
                    ",Bienvenido al Cajero Automatico Del Banco T1172");
                    Console.WriteLine();
                    Console.WriteLine("*******Menu del Administrador*******");
                    CaseAdmi();

                }
                else if (nombreUser == usuarioCliente.NickName && contraseña == usuarioCliente.Password)
                {
                    Console.WriteLine("Hola " + nombreUser + "" +
                    ",Bienvenido al Cajero Automatico Del Banco T1172");
                    Console.WriteLine();
                    Console.WriteLine("*******Menu del Cliente*******");
                    MenuUsuario();
                }
                else
                {
                    Console.WriteLine("Credenciales Incorrectas.");
                }
             
            }
            while (opcion!=5);
         
           
            Console.ReadKey();
          
        }
        public static void MenuUsuario()
        {
            Console.WriteLine("Menu\n");
            Console.WriteLine("1.Depositar" +
                "\r\n2.Retirar" +
                "\r\n3.Verificar Saldo" +
                "\r\n4.Salir");
        }

        public static void MenuAdmin()
        {
            Console.WriteLine("Control de Cuentas Bancarias");
            Console.WriteLine("1.Crear Usuario" +
                "\r\n2.Dar de Baja Usuario" +
                "\r\n3.Crear Cuenta" +
                "\r\n4.Dar de Baja Cuenta" +
                "\r\n5.Salir");
        }
        
        public static void CaseAdmi()
        {
            int opcion = 0;
            do
            {
                MenuAdmin();
                opcion = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (opcion)
                {                  
                    case 1:
                        Console.WriteLine();
                        Console.WriteLine("**************Registro de Usuario**************");
                        Console.WriteLine();
                        Console.WriteLine("Nombre Completo:");
                        string nombre = Console.ReadLine();
                        Console.WriteLine("Numero de indentidad:");
                        string numeroId = Console.ReadLine();
                        Console.WriteLine("Correo Electronico:");
                        string correoElectronico = Console.ReadLine();
                        Console.WriteLine("Nombre de Usuario:");
                        string nickName = Console.ReadLine();
                        Console.WriteLine("Contraseña:");
                        string password = Console.ReadLine();
                        Console.WriteLine("Fecha Nacimiento");
                        string fechaNacimiento = Console.ReadLine();
                        Console.WriteLine("Fecha de creacion del usuario");
                        string fechaCreacionUsuaro = Console.ReadLine();  
                        
                        Cliente cliente = new Cliente(nombre, numeroId, correoElectronico, nickName,
                            password, fechaNacimiento, fechaCreacionUsuaro);
                        

                        break;
                    case 2:
                        Console.WriteLine();
                        Console.WriteLine("**************Eliminar Usuario**************");

                        break;
                    case 3:
                        int opcionTipoCuenta = 0;
                        Console.WriteLine("Elija su opcion\n" +
                            "\n\r1.Cuenta Basica" +
                            "\n\r2.Cuenta Premiun" +
                            "\n\r3.Cancelar");

                        opcionTipoCuenta = int.Parse(Console.ReadLine());

                        Console.WriteLine();
                        Console.WriteLine("**************Registro de Cuenta**************");
                        Console.WriteLine("Ingrese su nombre de usuario:");
                        string nombreUsuario = Console.ReadLine();
                        Console.WriteLine("Monto inicial para crear la cuenta:");
                        double monto = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el ID de la cuenta:");
                        string idCuenta = Console.ReadLine();
                        Console.WriteLine("Ingrese el Id del propietario:");
                        string idPropietario = Console.ReadLine();
                        Console.WriteLine("Ingrese la fecha de creacion de la cuenta");
                        string fechaCreacion = Console.ReadLine();

                        if (opcionTipoCuenta == 1)
                        {
                            CuentaBasica cuentaBasica = new CuentaBasica(nombreUsuario, monto, idCuenta,
                               idPropietario, fechaCreacion);
                        }
                        else if (opcionTipoCuenta == 2)
                        {
                            CuentaPremiun cuentaPremiun = new CuentaPremiun(nombreUsuario, monto, idCuenta,
                                idPropietario, fechaCreacion);
                        }
                        break;
                }

            }
            while (opcion != 5);
        }
    }
}
