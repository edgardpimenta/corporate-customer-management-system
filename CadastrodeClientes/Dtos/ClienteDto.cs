using System;
using System.Collections.Generic;
using System.Text;

namespace CadastrodeClientes.Dtos
{
    public class CreateClienteDto
    { 
        public string Nome { get; set; } = string.Empty;
        public string Cpf { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
    }


    public class ClienteDto
    {
        public Guid Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Cpf { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public DateOnly DataCadastro { get; set; } 
    }
}
