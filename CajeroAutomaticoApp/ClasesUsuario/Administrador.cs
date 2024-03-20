using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutomaticoApp.ClasesUsuario
{
    public class Administrador : Usuario
    {
        private string tipoUsuario;
        public string TipoUsuario
        {
            get
            {
                return tipoUsuario;

            }
            set
            {
                tipoUsuario = "Administrador";
            }
        }

       
        public Administrador() { }
        public Administrador(string nombreCompleto,string numeroIdentidad,string correoElectronico,
            string nickName,string password,string fechaNacimiento,string fechaCreacionUsuario) 
            : base(nombreCompleto,numeroIdentidad,correoElectronico,nickName,
            password,fechaNacimiento,fechaCreacionUsuario) { }
    }
}
