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
            List<Cuenta> listaCuentas = new List<Cuenta>();

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
            //Console.WriteLine(usuarioCliente.Cuenta.Saldo);
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
                    CaseUser();
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
            List<Cliente> CuentasClientes = new List<Cliente>();//lista para agregar clientes
            List<Cuenta> cuentasBancarias = new List<Cuenta>();
            int opcion = 0;
            bool salir = false;
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
                        CuentasClientes.Add(cliente);// agregar cliente

                        Console.WriteLine();
                        Console.WriteLine("***********************");
                        break;

                    case 2:
                        Console.WriteLine();
                        Console.WriteLine("**************Eliminar Usuario**************");
                        Console.WriteLine();
                        Console.WriteLine("ingrese el nombre de usuario que desea eliminar:");
                        string borrarUsuario = Console.ReadLine();

                        bool estadoBorrar = false;

                        foreach (Cliente clienteActual in CuentasClientes)
                        {
                            if (clienteActual.NickName.Equals(borrarUsuario))
                            {
                                estadoBorrar = true;
                            }
                        }
                        if (!estadoBorrar)
                        {
                            Console.WriteLine("No se encontraron registros");
                        }
                        else
                        {
                            Cliente clienteTemporal = CuentasClientes.Find(c => c.NickName == borrarUsuario);
                            CuentasClientes.Remove(clienteTemporal);
                        }
                        Console.WriteLine();
                        Console.WriteLine("***********************");
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
                        Console.WriteLine();
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
                            cuentasBancarias.Add(cuentaBasica);
                        }
                        else if (opcionTipoCuenta == 2)
                        {
                            CuentaPremiun cuentaPremiun = new CuentaPremiun(nombreUsuario, monto, idCuenta,
                                idPropietario, fechaCreacion);
                            cuentasBancarias.Add(cuentaPremiun);
                        }
                        Console.WriteLine();
                        Console.WriteLine("***********************");
                        break;

                    case 4:
                        Console.WriteLine();
                        Console.WriteLine("**************Eliminar Cuenta**************");
                        Console.WriteLine();
                        Console.WriteLine("Ingrese el numero de cuenta que desea elimianar");
                        string id = Console.ReadLine();

                        bool estadocuentaBorrar = false;

                        foreach (Cuenta cuentas in cuentasBancarias)
                        {
                            if (cuentas.IdCuenta.Equals(id))
                            {
                                estadocuentaBorrar = true;
                            }
                        }

                        if (!estadocuentaBorrar)
                        {
                            Console.WriteLine("No se encontraron registros");
                        }

                        else
                        {
                            Cuenta temporal = cuentasBancarias.Find(c => c.IdCuenta == id);
                            cuentasBancarias.Remove(temporal);
                            Console.WriteLine("Eliminado con Exito..");
                        }
                        Console.WriteLine();
                        Console.WriteLine("***********************");
                        break;

                   /* case 5:
                        Console.WriteLine("**************Reporte de Cuenta**************");
                        Console.WriteLine();
                        foreach (Cuenta cuentaActual in cuentasBancarias)
                        {
                            Console.WriteLine(cuentaActual.ToString());
                        }
                        Console.WriteLine();
                        Console.WriteLine("***********************");
                        break;*/

                    case 5:
                        salir = true;
                        break;

                    default:
                        Console.WriteLine("Opcion no valida");
                        break;
                }

            }
            while (opcion != 5);
        }
        public static void CaseUser()
        {
            List<Cuenta> cuentasBancarias = new List<Cuenta>();
            int opcion = 0;
            MenuUsuario();
            Console.WriteLine();
            opcion = int.Parse(Console.ReadLine());

            switch (opcion) 
            {
                case 1:
                    Console.WriteLine();
                    Console.WriteLine("*********Depositar*********");
                    Console.WriteLine();
                    Console.WriteLine("Ingrese el numero de cuenta");
                    string numeroCuenta = Console.ReadLine();

                    foreach (Cuenta cuentas in cuentasBancarias)
                    {
                        if (cuentas.IdCuenta.Equals(numeroCuenta))
                        {
                            Console.WriteLine("Ingrese la cantidad a depositar");
                            double deposito = double.Parse(Console.ReadLine());
                            cuentas.Depositar(deposito);
                        }
                    }
                    Console.WriteLine(); 
                    
                    break;
                case 2:
                    Console.WriteLine();
                    Console.WriteLine("*********Retirar*********");
                    Console.WriteLine();
                    Console.WriteLine("Ingrese el numero de cuenta");
                    numeroCuenta = Console.ReadLine();

                    foreach (Cuenta cuentas in cuentasBancarias)
                    {
                        if (cuentas.IdCuenta.Equals(numeroCuenta))
                        {
                            Console.WriteLine("Ingrese la cantidad a depositar");
                            double retiro = double.Parse(Console.ReadLine());
                            cuentas.Retirar(retiro);
                        }
                    }
                    Console.WriteLine();
                    break;

                case 3:
                    foreach (Cuenta cuentas in cuentasBancarias)
                    {
                        Console.WriteLine();
                        Console.WriteLine("*********Retirar*********");
                        Console.WriteLine();
                        Console.WriteLine("Ingrese el numero de cuenta");
                        numeroCuenta = Console.ReadLine();
                        if (cuentas.IdCuenta.Equals(numeroCuenta))
                        {
                            Console.WriteLine("Saldo Actual: " + cuentas.Saldo);   
                        }
                    }
                    Console.WriteLine();
                    break;

                case 4:
                    break;

                default:
                    Console.WriteLine("Opcion no valida.");
                    break;
            }
        }
    }
}
