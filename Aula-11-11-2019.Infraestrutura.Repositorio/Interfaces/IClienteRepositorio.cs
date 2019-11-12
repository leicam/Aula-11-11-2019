using Aula_11_11_2019.Dominio.Entidades.Cliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_11_11_2019.Infraestrutura.Repositorio.Interfaces
{
    public interface IClienteRepositorio
    {
        void Adicionar(Cliente cliente);
        void Remover(Cliente cliente);
        List<Cliente> Listar();
    }
}
