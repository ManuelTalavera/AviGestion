using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AviGestion_.Datos;

namespace AviGestion_.Logica
{
    public class ClienteLogica
    {
        private ClienteDatos clienteDatos = new ClienteDatos();

        public List<Cliente> ObtenerClientes()
        {
            return clienteDatos.ListarTodos();
        }

        public List<string> ValidarFormatosLogicos(string telefono, string dniCuil, string correo, string responsable)
        {
            List<string> errores = new List<string>();

            if (!responsable.Contains(" "))
                errores.Add("- Debe ingresar nombre y apellido separados por un espacio.");

            string telLimpio = telefono.Replace("-", "").Replace(" ", "");
            if (!telefono.Contains("+"))
                errores.Add("- El teléfono debe incluir el código de país (ej: +54).");
            else if (telLimpio.Length < 10)
                errores.Add("- El número de teléfono es demasiado corto.");

            if (!correo.Contains("@") || !correo.Contains("."))
                errores.Add("- El formato del correo electrónico no es válido.");

            string dniLimpio = dniCuil.Replace("-", "");
            if (dniLimpio.Length != 8 && dniLimpio.Length != 11)
                errores.Add("- El DNI debe tener 8 dígitos o el CUIL 11 dígitos.");

            return errores; // Devuelve la lista de errores encontrados
        }
        public void GuardarCliente(Cliente cliente)
        {
            if (string.IsNullOrWhiteSpace(cliente.Empresa))
                throw new ArgumentException("El nombre de la empresa/negocio es obligatorio.");

            if (string.IsNullOrWhiteSpace(cliente.Nombre))
                throw new ArgumentException("El nombre del responsable es obligatorio.");

            // Si el ID es -1 procesa el alta, sino modifica
            if (cliente.Id_Cliente == -1)
            {
                clienteDatos.Insertar(cliente);
            }
            else
            {
                clienteDatos.Modificar(cliente);
            }
        }

    }
}
