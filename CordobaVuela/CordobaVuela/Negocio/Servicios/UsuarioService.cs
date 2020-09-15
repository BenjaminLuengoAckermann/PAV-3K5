using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CordobaVuela.Datos.Dao.Implementacion;
using CordobaVuela.Negocio.Entidades;

namespace CordobaVuela.Negocio.Servicios
{
    public class UsuarioService
    {
        private UsuarioDaoSqlImp dao;

        public UsuarioService()
        {
            dao = new UsuarioDaoSqlImp();
        }
        public bool BorrarUsuario(string id)
        {
            return dao.delete(id);
        }

        public bool CrearUsuario(string idUsu, string pass)
        {                             
            Usuario UsuNuevo = new Usuario(idUsu, pass);
            return dao.add(UsuNuevo);
        }

        public bool validarUsuario(Usuario u)
        {
            return dao.FindByName(u);
        }
    
        public bool ValidarPermiso(Usuario u)
        {
            return dao.PermisoUser(u);
        }
    
        public bool ValidarNombreUsuario (string nombre)
        {
            return dao.ValidarUsuario(nombre);
        }
    
    }

    
}
