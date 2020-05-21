using cmrModelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cmrService
{
    public interface LoginUsuarioService
    {
        LoginUsuario validarLogin(long id);
    }
}
