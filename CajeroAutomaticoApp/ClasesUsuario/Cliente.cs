using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutomaticoApp.ClasesUsuario
{
    public class Cliente : Usuario
    {
        public Cliente() { }
        public Cliente(string nombreCompleto, string numeroIdentidad, string correoElectronico,
            string nickName, string password, string fechaNacimiento, string fechaCreacioUsuario)
            : base(nombreCompleto, numeroIdentidad, correoElectronico, nickName, password,
                  fechaNacimiento, fechaCreacioUsuario)
        { }
           
        




    }
}

