using AccesoDatos;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class ClienteBL
    {
        private ClienteDA clienteDA;

        public ClienteBL()
        {
            clienteDA = new ClienteDA();
        }

        public void registrarCliente(Cliente c)
        {
            clienteDA.registrarCliente(c);
        }

        public BindingList<Cliente> listarClientes()
        {
            return clienteDA.listarClientes();
        }

        public void modificarTerapista(Cliente c)
        {
            clienteDA.modificarCliente(c);
        }
    }
}
