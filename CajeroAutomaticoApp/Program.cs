using CajeroAutomaticoApp.ClasesUsuario;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutomaticoApp
{
    public class Program
    {
        // listas para guardar los usuarios y cuentas
        public static List<Cuenta> CuentasBancarias = new List<Cuenta>();
        public static List<Cliente> listaUsuarioCliente = new List<Cliente>();
        public static List<Administrador> ListaAdministrador = new List<Administrador>();
        static void Main(string[] args)
        {
           
   
            bool continuar = true;
            // administrador por defecto
            Administrador admin = new Administrador();
            admin.NombreCompleto = "Esdras Peña";
            admin.NumeroIdentidad = "1621200000375";
            admin.CorreoElectronico = "esdraspea@gmail.com";
            admin.NickName = "adminesdras".ToLower();
            admin.Password = "topuser123".ToLower();
            admin.FechaNacimiento = "9/17/1999";
            admin.FechaCreacionUsuario = "3/17/2024";
            ListaAdministrador.Add(admin);

            
            do
            {
                Console.WriteLine();
                Console.WriteLine("Cajero Automatico Del Banco T1172");
                Console.WriteLine();
                Console.WriteLine("Iniciar Sesion");
                Console.WriteLine("======================");
                Console.WriteLine();
                Console.WriteLine("Nombre de Usuario:");
                string nombreUser = Console.ReadLine();

                Console.WriteLine("Contraseña:");
                string contraseña = Console.ReadLine();

                // metodo para buscar el nombre de usuario y contraseña para hacer log in
                Cliente usuario = listaUsuarioCliente.Find(u => u.NickName == nombreUser && u.Password == contraseña); 
                if (usuario != null)                                                                                        
                {
                    Console.WriteLine();
                    Console.WriteLine("=================");
                    Console.WriteLine("Hola  " + usuario.NickName + " ,Bienvenido al Cajero Automatico Del Banco T1172");
                    CaseUser();      
                }
                else
                {
                    Administrador administrador = ListaAdministrador.Find(a => a.NickName == nombreUser && a.Password == contraseña);
                    if(administrador != null)
                    {
                        Console.WriteLine();
                        Console.WriteLine("=================");
                        Console.WriteLine("Hola " + administrador.NickName + " ,Bienvenido al Cajero Automatico Del Banco T1172");
                        Console.WriteLine();
                        CaseAdmi();
                    }
                    else
                    {
                        Console.WriteLine("Credenciales Incorrectas.");
                    }
                }

                Console.WriteLine("Desea Continuar?(s/n)");
                string respuesta = Console.ReadLine();
                continuar = respuesta.ToLower() == "s";

            }
            while (continuar);


            Console.ReadKey();
        }

        public static void MenuUsuario()
        {
            Console.WriteLine("Menu\n");
            Console.WriteLine("1.Depositar" +
                "\r\n2.Retirar" +
                "\r\n3.Verificar Saldo" +
                "\r\n4.Estado de Cuenta" +
                "\r\n5.Salir");
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
                        Console.WriteLine("=================Registro de Usuario=================");
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
                        listaUsuarioCliente.Add(cliente);// agregar cliente
                        listaUsuarioCliente.Add(cliente);


                        Console.WriteLine("Se agrego exitosamente.");

                        Console.WriteLine();
                        Console.WriteLine("=================");
                    break;

                    case 2:
                        Console.WriteLine();
                        Console.WriteLine("=================Eliminar Usuario=================");
                        Console.WriteLine();
                        Console.WriteLine("ingrese el nombre de usuario que desea eliminar:");
                        string borrarUsuario = Console.ReadLine();

                        bool estadoBorrar = false;

                        foreach (Cliente clienteActual in listaUsuarioCliente)
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
                            Cliente clienteTemporal = listaUsuarioCliente.Find(c => c.NickName == borrarUsuario);
                            listaUsuarioCliente.Remove(clienteTemporal);
                            Console.WriteLine("Se elimino exitosamente");
                        }
                        Console.WriteLine();
                        Console.WriteLine("=================");
                    break;

                    case 3:
                        int opcionTipoCuenta = 0;
                        Console.WriteLine("Elija su opcion\n" +
                            "\n\r1.Cuenta Basica" +
                            "\n\r2.Cuenta Premiun" +
                            "\n\r3.Cancelar");

                        opcionTipoCuenta = int.Parse(Console.ReadLine());

                        Console.WriteLine();
                        Console.WriteLine("=================Registro de Cuenta=================");
                        Console.WriteLine();
                        Console.WriteLine("nombre de usuario:");
                        string nombreUsuario = Console.ReadLine();
                        Console.WriteLine("Monto inicial para crear la cuenta:");
                        double monto = double.Parse(Console.ReadLine());
                        Console.WriteLine("ID de la cuenta:");
                        string idCuenta = Console.ReadLine();
                        Console.WriteLine("Id del propietario:");
                        string idPropietario = Console.ReadLine();
                        Console.WriteLine("Fecha de creacion de la cuenta");
                        string fechaCreacion = Console.ReadLine();

                        if (opcionTipoCuenta == 1)
                        {
                            CuentaBasica cuentaBasica = new CuentaBasica(nombreUsuario, monto, idCuenta,
                               idPropietario, fechaCreacion);
                            CuentasBancarias.Add(cuentaBasica);
                            cuentaBasica.UsuarioCliente = new Cliente();

                        }
                        else if (opcionTipoCuenta == 2)
                        {
                            CuentaPremiun cuentaPremiun = new CuentaPremiun(nombreUsuario, monto, idCuenta,
                                idPropietario, fechaCreacion);
                            CuentasBancarias.Add(cuentaPremiun);
                        }
                        Console.WriteLine();
                        Console.WriteLine("=================");
                    break;

                    case 4:
                        Console.WriteLine();
                        Console.WriteLine("=================Eliminar Cuenta=================");
                        Console.WriteLine();
                        Console.WriteLine("Ingrese el numero de cuenta que desea elimianar");
                        string id = Console.ReadLine();

                        bool estadocuentaBorrar = false;

                        foreach (Cuenta cuentas in CuentasBancarias)
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
                            Cuenta temporal = CuentasBancarias.Find(c => c.IdCuenta == id);
                            CuentasBancarias.Remove(temporal);
                            Console.WriteLine("Eliminado con Exito..");
                        }
                        Console.WriteLine();
                        Console.WriteLine("=================");
                    break;

                    case 5:
                        Console.WriteLine("Gracias por usar nuestros servicios");
                    break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("=================");
                        Console.WriteLine("Opcion no valida");
                    break;
                }

            }
            while (opcion != 5);
        }
        public static void CaseUser()
        {
            int opcion = 0;
            do
            {
                MenuUsuario();
                Console.WriteLine();
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine();
                        Console.WriteLine("=================Depositar=================");
                        Console.WriteLine();
                        Console.WriteLine("Ingrese ID de cuenta");
                        string numeroCuenta = Console.ReadLine();

                        foreach (Cuenta cuentas in CuentasBancarias)
                        {
                            if (cuentas.IdCuenta.Equals(numeroCuenta))
                            {
                                Console.WriteLine("Ingrese la cantidad a depositar");
                                double deposito = double.Parse(Console.ReadLine());
                                cuentas.Depositar(deposito);
                            }
                        }
                        Console.WriteLine("===================================================");
                        Console.WriteLine();

                    break;

                    case 2:
                        Console.WriteLine();
                        Console.WriteLine("=================Retirar=================");
                        Console.WriteLine();
                        Console.WriteLine("Ingrese el ID de cuenta");
                        numeroCuenta = Console.ReadLine();

                        foreach (Cuenta cuentas in CuentasBancarias)
                        {
                            if (cuentas.IdCuenta.Equals(numeroCuenta))
                            {
                                Console.WriteLine("Ingrese la cantidad a retirar");
                                double retiro = double.Parse(Console.ReadLine());
                                cuentas.Retirar(retiro);
                            }
                        }
                        Console.WriteLine("===================================================");
                        Console.WriteLine();
                    break;

                    case 3:
                        foreach (Cuenta cuentas in CuentasBancarias)
                        {
                            Console.WriteLine();
                            Console.WriteLine("=================Consulta de Saldo=================");
                            Console.WriteLine();
                            Console.WriteLine("Ingrese el ID de cuenta");
                            numeroCuenta = Console.ReadLine();
                            if (cuentas.IdCuenta.Equals(numeroCuenta))
                            {
                                Console.WriteLine("Saldo Actual: " + cuentas.Saldo);
                            }
                        }
                        Console.WriteLine("===================================================");
                        Console.WriteLine();
                    break;

                    case 4:
                        Console.WriteLine();
                        Console.WriteLine("=================Reporte de Cuentas=================");
                        Console.WriteLine();
                        foreach (Cuenta cuentas in CuentasBancarias)
                        {
                            Console.WriteLine(cuentas.ToString());
                            Console.WriteLine();
                        }
                        Console.WriteLine("===================================================");
                        Console.WriteLine();
                    break;

                    case 5:
                        Console.WriteLine("Gracias por usar nuestros servicios.");
                    break;

                    default:
                        Console.WriteLine("===================================================");
                        Console.WriteLine();
                        Console.WriteLine("Opcion no valida.");
                    break;
                }

            }
            while (opcion != 5);    
        }
    }
}
