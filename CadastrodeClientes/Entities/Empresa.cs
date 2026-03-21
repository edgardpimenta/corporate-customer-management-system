using CadastrodeClientes.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CadastrodeClientes.Entities
{
    // Modelo de Classe que representa uma empresa
    public class Empresa
    {
        #region Propriedades
        public Guid Id { get; set; } = Guid.NewGuid();
        public string RazaoSocial { get; set; } = string.Empty;
        public string Cnpj { get; set; } = string.Empty;
        public List<Cliente> Clientes { get; set; } = new List<Cliente>(); // Propriedade de navegação para os clientes associados à empresa

        /// <summary>
        /// Aplicando enum do TipoDeCliente para indicar o tipo de cliente (Pessoa Física ou Pessoa Jurídica) associado à empresa
        /// </summary>
        public TipoDeCliente TipoDeCliente { get; set; } = TipoDeCliente.PessoaFisica; // Aplicando o Enum TipoDeCliente para indicar o tipo de cliente (Pessoa Física ou Pessoa Jurídica)
        #endregion

    }
}
