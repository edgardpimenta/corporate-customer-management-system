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

            if (string.IsNullOrWhiteSpace(nome))
            {
                throw new Exception("Nome não pode ser nulo.");
            }

            if (string.IsNullOrWhiteSpace(email))
            {
                throw new Exception("Email não pode ser nulo.");
            }

        }
    }
}

