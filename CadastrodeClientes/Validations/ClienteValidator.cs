using CadastrodeClientes.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CadastrodeClientes.Validations
{

    public class ClienteValidator
    {
        public void ValidarCliente(Cliente cliente,string nome, string cpf, string email)
        {
            

            if (string.IsNullOrWhiteSpace(cpf) || cpf.Length < 11)
            {
                throw new ArgumentException("CPF não pode ser nulo,não pode ser diferente de 11 dígitos.");
            }

            if (string.IsNullOrWhiteSpace(email) || !email.Contains("@"))
            {
                throw new ArgumentException("Email não pode ser nulo, e precisa conter um @.");
            }

            if(!new EmailAddressAttribute().IsValid(email))
            {
                throw new ArgumentException("Email inválido.");
            }
             if (cpf.Length != 11 || !long.TryParse(cpf, out _))
            {
                throw new ArgumentException("CPF deve conter exatamente 11 dígitos numéricos.");
            }
            if (string.IsNullOrWhiteSpace(nome) || nome.Length < 3)
            {
                throw new ArgumentException("O nome deve ter pelo menos 3 letras válidas.");
            }

           
        }
    }
}

