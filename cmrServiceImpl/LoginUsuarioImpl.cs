using cmrModelo;
using cmrService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cmrServiceImpl
{
    public class LoginUsuarioImpl : LoginUsuarioService
    {
        private CrmTributariaEntities db = new CrmTributariaEntities();
        public LoginUsuario validarLogin(long id)
        {
            LoginUsuario loginUsuario = db.LoginUsuario.Find(id);
            return loginUsuario;
        }
    }
}
