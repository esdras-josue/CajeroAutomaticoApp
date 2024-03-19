using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutomaticoApp.ClasesUsuario
{
    public class Cliente : Usuario
    {
        public Cuenta Cuenta { get; set; }
        public Cuenta CuentaId { get; set; } // vincular una cuenta ID al usuario
        public Cliente() { }

        public Cliente(string nombreCompleto, string numeroIdentidad, string correoElectronico,
            string nickName, string password, string fechaNacimiento, string fechaCreacioUsuario)
            : base(nombreCompleto, numeroIdentidad, correoElectronico, nickName, password,
                  fechaNacimiento, fechaCreacioUsuario)
        { }
           
        




    }
}

