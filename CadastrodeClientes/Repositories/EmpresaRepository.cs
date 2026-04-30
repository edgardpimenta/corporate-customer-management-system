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
            var query = @"INSERT INTO Empresas (Id,RazaoSocial,Cnpj
                         VALUES (@Id,@RazaoSocial,@Cnpj)";

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
