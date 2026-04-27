using CadastrodeClientes.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;


namespace CadastrodeClientes.Entities
{
    public class Cliente
    {
        #region Propriedades
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Nome { get; private set; } = string.Empty;
        public string Cpf { get; private set; } = string.Empty;
        public string Email { get; private set; } = string.Empty;
        public DateTime DataCadastro { get; set; } = DateTime.UtcNow;

        public Guid EmpresaId { get; set; } // Chave estrangeira para a empresa associada ao cliente
        public Empresa Empresa { get; set; } = new();// Propriedade de navegação para a empresa associada ao cliente


        /// <summary>
        /// Aplicando o Enum StatusDoCliente para indicar o status do cliente (Ativo, Inativo, Bloqueado)
        /// </summary>
        public StatusDoCliente Status { get; set; } = StatusDoCliente.Ativo;
        public TipoDeCliente TipoDeCliente { get; set; }


        /// <summary>
        /// Regra de Negocio da Domain Cliente.
        /// </summary>
        public void ValidarSePodeCadastrarProduto()
        {
            {
                if (Status == StatusDoCliente.Bloqueado)
                {
                    throw new InvalidOperationException("O cliente está bloqueado e não pode cadastrar produtos.");
                }

                if (Status == StatusDoCliente.Inativo)
                {
                    throw new InvalidOperationException("O cliente está inativo e não pode cadastrar produtos.");
                }

                // futuramente criar uma regra de negocio para Repository para verificar se o CPF já existe no banco de dados
            }
        }



        //Construtores para as propriedades de Cliente (encapsulamento seguro)
        public Cliente(string Nome, string Email, string Cpf)
        {
            this.Nome = Nome;
            this.Email = Email;
            this.Cpf = Cpf;

            if (string.IsNullOrWhiteSpace(Nome) || Nome.Length < 3)
            {
                throw new ArgumentException("O nome deve ter pelo menos 3 letras válidas.");

            }
            if (string.IsNullOrWhiteSpace(Nome))

                throw new ArgumentException("Nome invalido.");
            this.Nome = Nome;

            if (Email == null || !Email.Contains("@"))
            {
                throw new ArgumentException("Email não pode ser nulo, e precisa conter um @.");
            }

            if (!new EmailAddressAttribute().IsValid(Email))
            {
                this.Email = Email;
                throw new ArgumentException("Email inválido.");
            }

            if (Cpf == null || Cpf.Length < 11)
            {
                throw new ArgumentException("CPF não pode ser nulo,não pode ser diferente de 11 dígitos.");
            }

            if (Cpf.Length != 11 || !long.TryParse(Cpf, out _))
            {
                this.Cpf = Cpf;
                throw new ArgumentException("CPF deve conter exatamente 11 dígitos numéricos.");

            }
        }
    }
}

#endregion
