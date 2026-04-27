using CadastrodeClientes.Entities;
using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace CadastrodeClientes.Repositories
{
    public class ClienteRepository
    {
        private string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DBCadastroClientes;Integrated Security=True;"; // Defina a string de conexão com o banco de dados

       public void CadastrarCliente(Cliente cliente)
        {
            var query = @"INSERT INTO Cliente (Id, Nome, Cpf, Email, DataCadastro, EmpresaId, Status, TipoDeCliente) 
                          VALUES (@Id, @Nome, @Cpf, @Email, @DataCadastro, @EmpresaId, @Status, @TipoDeCliente)";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                connection.Execute(query, cliente);
               
            }
        }

        public void AtualizarCliente(Cliente cliente)
        {
            var query = @"UPDATE Clientes
                          SET Nome = @Nome, Cpf = @Cpf, Email = @Email, DataCadastro = 
                           @DataCadastro, EmpresaId = @EmpresaId, Status = @Status, TipoDeCliente = @TipoDeCliente
                            WHERE Id = @Id";
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                connection.Execute(query, cliente);
            }
        }

        public void DeletarCliente(Guid id)
        {
            var query = @"DELETE FROM Clientes
                          WHERE Id = @Id";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                connection.Execute(query, new { Id = id });
            }
        }

        public void BuscarClienteporId(Guid id)
        {
            var query = @"SELECT * FROM Clientes
                          WHERE Id = @Id";

            using(var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var cliente = connection.QueryFirstOrDefault<Cliente>(query, new { Id = id });
                if (cliente != null)
                {
                    Console.WriteLine($"Cliente encontrado: {cliente.Nome}, {cliente.Email}, {cliente.Cpf}");
                }
                else
                {
                    Console.WriteLine("Cliente não encontrado.");
                }
            }
        }

        public List<Cliente>ListarClientes()
        {
            var query = @"SELECT * FROM Clientes";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var clientes = connection.Query<Cliente>(query).AsList();

                return clientes;
            }

        }
    }
}
