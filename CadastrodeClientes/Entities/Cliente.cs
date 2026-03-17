using System;
using System.Collections.Generic;
using System.Text;


namespace CadastrodeClientes.Entities
{
    public class Cliente
    {
        public Guid Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;   
        public string Telefone { get; set; } = string.Empty;
        public DateTime DataHoraCadastro { get; set; } = DateTime.Now;
    }
}
