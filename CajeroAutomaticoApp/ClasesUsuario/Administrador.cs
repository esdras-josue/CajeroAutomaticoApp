using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutomaticoApp.ClasesUsuario
{
    public class Administrador : Usuario
    {
       
        public Administrador() { }
        public Administrador(string nombreCompleto,string numeroIdentidad,string correoElectronico,
            string nickName,string password,string fechaNacimiento,string fechaCreacionUsuario) 
            : base(nombreCompleto,numeroIdentidad,correoElectronico,nickName,
            password,fechaNacimiento,fechaCreacionUsuario) { }
    }
}
