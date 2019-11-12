using Aula_11_11_2019.Aplicacao.Interfaces;
using Aula_11_11_2019.Dominio.Builders;
using Aula_11_11_2019.DTO.Cliente;
using Aula_11_11_2019.Infraestrutura.Repositorio.Interfaces;
using Aula_11_11_2019.Infraestrutura.Repositorio.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_11_11_2019.Aplicacao.Servicos
{
    public class ClienteServico : IClienteServico
    {
        private ClienteRepositorio ClienteRepositorio { get; set; } = new ClienteRepositorio();

        public string Adicionar(ClienteDTO dto)
        {
            try
            {
                var registro = new ClienteBuilder()
                    .ComDocumento(dto.Documento)
                    .ComEmail(dto.Email)
                    .ComNome(dto.Nome)
                    .ComSobrenome(dto.Sobrenome)
                    .Build();

                ClienteRepositorio.Adicionar(registro);
                return "Cliente cadastrado com sucesso!";
            }
            catch(ArgumentException ex)
            {
                return ex.Message;
            }
        }

        public List<ClienteDTO> Listar()
        {
            throw new NotImplementedException();
        }

        public string Remover(ClienteDTO dto)
        {
            throw new NotImplementedException();
        }
    }
}
