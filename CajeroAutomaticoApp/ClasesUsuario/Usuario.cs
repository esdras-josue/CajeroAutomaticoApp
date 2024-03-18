using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutomaticoApp.ClasesUsuario
{
    public abstract class Usuario
    {

        public string NombreCompleto { get; set; }
        public string NumeroIdentidad { get; set; }
        public string CorreoElectronico { get; set; }
        public string NickName { get; set; }
        public string Password { get; set; }
        public string FechaNacimiento { get; set; }
        public string FechaCreacionUsuario { get; set; }
        public Usuario() { }
        public Usuario(string nombreCompleto, string numeroIdentidad,string correoElectronico,
            string nickName, string password, string fechaNacimiento,string fechaCreacioUsuario)
            
        {

            NombreCompleto = nombreCompleto;
            NumeroIdentidad = numeroIdentidad;
            CorreoElectronico = correoElectronico;
            NickName = nickName;
            Password = password;
            FechaNacimiento = fechaNacimiento;
            FechaCreacionUsuario = fechaCreacioUsuario;
           
        }

       
        

    }
}
