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
