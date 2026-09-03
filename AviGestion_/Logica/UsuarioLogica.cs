using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AviGestion_.Datos;

namespace AviGestion_.Logica
{
    public class UsuarioLogica
    {
        private UsuarioDatos usuarioDatos = new UsuarioDatos();

        public Usuario ValidarLogin(string nombre, string contrasena)
        {
            Usuario usuario = usuarioDatos.ObtenerUsuarioPorNombre(nombre);

            if (usuario == null)
            {
                return null; // no existe el usuario
            }

            if (usuario.Contrasena != contrasena)
            {
                return null; // contraseña incorrecta
            }

            return usuario; // login correcto
        }

        public List<Usuario> ObtenerTodos()
        {
            return usuarioDatos.ObtenerTodos();
        }

        public void Insertar(Usuario usuario)
        {
            usuarioDatos.Insertar(usuario);
        }
        public void Actualizar(Usuario usuario)
        {
            usuarioDatos.Actualizar(usuario);
        }

        public void Eliminar(int idUsuario)
        {
            usuarioDatos.Eliminar(idUsuario);
        }
    }
}
