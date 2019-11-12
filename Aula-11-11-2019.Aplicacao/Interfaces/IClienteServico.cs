using Aula_11_11_2019.DTO.Cliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_11_11_2019.Aplicacao.Interfaces
{
    public interface IClienteServico
    {
        string Adicionar(ClienteDTO dto);
        string Remover(ClienteDTO dto);
        List<ClienteDTO> Listar();
    }
}
