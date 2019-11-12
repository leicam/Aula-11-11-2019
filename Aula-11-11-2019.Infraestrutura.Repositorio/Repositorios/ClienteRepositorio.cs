using Aula_11_11_2019.Dominio.Entidades.Cliente;
using Aula_11_11_2019.Infraestrutura.Repositorio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_11_11_2019.Infraestrutura.Repositorio.Repositorios
{
    public class ClienteRepositorio : IClienteRepositorio
    {
        private List<Cliente> Clientes { get; set; } = new List<Cliente>();

        public void Adicionar(Cliente cliente) => Clientes.Add(cliente);
        public List<Cliente> Listar() => Clientes;
        public void Remover(Cliente cliente) => Clientes.Remove(cliente);
    }
}
