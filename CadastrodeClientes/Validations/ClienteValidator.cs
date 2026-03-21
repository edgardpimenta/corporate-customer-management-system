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


            if (string.IsNullOrWhiteSpace(cpf))
            {
                throw new Exception("CPF não pode ser nulo.");
            }

            if (string.IsNullOrWhiteSpace(email))
            {
                throw new Exception("Email não pode ser nulo.");
            }

            if(!new EmailAddressAttribute().IsValid(email))
            {
                throw new Exception("Email inválido.");
            }
             if (cpf.Length != 11 || !long.TryParse(cpf, out _))
            {
                throw new Exception("CPF deve conter exatamente 11 dígitos numéricos.");
            }
            if (string.IsNullOrWhiteSpace(nome) || nome.Length < 3)
            {
                throw new ArgumentException("O nome deve ter pelo menos 3 letras válidas.");
            }
        }
    }
}

