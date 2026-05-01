using CadastrodeClientes.Entities;
using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace CadastrodeClientes.Repositories
{
    public class EmpresaRepository
    {
        private string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DBCadastroClientes;Integrated Security=True;";

        public void CadastrarEmpresa(Empresa empresa)
        {
            var query = @"INSERT INTO Empresas (Id,RazaoSocial,Cnpj,TipoDeCliente,Status)
                         VALUES (@Id,@RazaoSocial,@Cnpj,@TipoDeCliente,@Status)";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                connection.Execute(query, empresa);
            }
        }

        public void ListarEmpresa(Guid id)
        {
            var query = @"SELECT Empresas
                          WHERE Id = @Id";
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                connection.Execute(query, new {id});
            }
        }
    }
}

///CRIAÇÃO DO BANCO DE DADOS DA EMPRESA REPOSITORY POR QUE, A EMPRESA E UMA ENTIDADE QUE VAI SER ASSOCIADA
///AO CLIENTE, ENTÃO PRECISAMOS CRIAR O BANCO 
///DE DADOS PARA A EMPRESA PARA PODER ASSOCIAR O CLIENTE A EMPRESA.
///NA CONTROLLER AGORA PODEMOS ASSOCIAR O CLIENTE A EMPRESA, POIS AGORA TEMOS O BANCO DE DADOS DA EMPRESA CRIADO.
///
//LEMBRAR DE ASSOCIAR A CONTROLLER AO REPOSITORY PARA PODER ACESSAR OS MÉTODOS DE CADASTRO E LISTAGEM DE EMPRESAS.