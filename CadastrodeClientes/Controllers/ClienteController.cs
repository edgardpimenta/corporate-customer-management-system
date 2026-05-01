using CadastrodeClientes.Dtos;
using CadastrodeClientes.Entities;
using CadastrodeClientes.Enums;
using CadastrodeClientes.Repositories;
using CadastrodeClientes.Validations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;

namespace CadastrodeClientes.Controllers
{

}
public class ClienteController
{

    public static void GerenciarClientes()
    {
        var createClienteDto = new CreateClienteDto();
        var repo = new CadastrodeClientes.Repositories.ClienteRepository(); // Instanciando o repositório para acessar os métodos de cadastro e listagem de clientes
        var repoEmpresa = new CadastrodeClientes.Repositories.EmpresaRepository();

        Console.WriteLine("\nMENU DE CADASTRO DE CLIENTE:\n");
        Console.WriteLine("1 - Cadastrar Cliente");
        Console.WriteLine("2 - Listar Cliente");
        Console.WriteLine("3 - Remover Cliente");
        Console.WriteLine("4 - Buscar Cliente por Id");
        Console.WriteLine("0 - Sair");

        var opcao = Console.ReadLine();

        if (opcao == "1")
        {
            Console.WriteLine("Informe o Nome do Cliente:");
            createClienteDto.Nome = Console.ReadLine() ?? string.Empty;

            Console.WriteLine("Informe o Email do Cliente:");
            createClienteDto.Email = Console.ReadLine() ?? string.Empty;

            Console.WriteLine("Informe o Cpf do Cliente:");
            createClienteDto.Cpf = Console.ReadLine() ?? string.Empty;

            var cliente = new Cliente(createClienteDto.Nome, createClienteDto.Email, createClienteDto.Cpf);

            Console.WriteLine("Informe o Tipo de Cliente: " +
                "\n1- PessoaFisica\n" +
                "\n2- PessoaJuridica\n");
            cliente.TipoDeCliente = (TipoDeCliente)Enum.Parse(typeof(TipoDeCliente),Console.ReadLine() ?? "");

            Console.WriteLine("Informe o nome da Empresa do Cliente:");
            var nomeEmpresa = Console.ReadLine() ?? string.Empty;
            

            Console.WriteLine("Informe o Tipo de Empresa do Cliente: " +
                "\n1 -MEI\n" +
                "\n2 -LTDA\n" +
                "\n3 -SA\n");
            cliente.TipoDeEmpresa = (TipoDeEmpresa)Enum.Parse(typeof(TipoDeEmpresa),Console.ReadLine() ?? "");


            Console.WriteLine("Informe o Status do Cliente: " +
                "\n1 -Ativo\n" +
                "\n2 -Inativo\n" +
                "\n3-Bloqueado\n");

            StatusDoCliente status = (StatusDoCliente)Enum.Parse(typeof(StatusDoCliente), Console.ReadLine() ?? "");

            Console.WriteLine($"Cliente salvo com sucesso!\n" +
                $"Cliente:\n Nome: {createClienteDto.Nome}, Email:{createClienteDto.Email}, Cpf:{createClienteDto.Cpf}, Tipo de Cliente:{cliente.TipoDeCliente}, Tipo de Empresa: {cliente.TipoDeEmpresa}");
            repo.CadastrarCliente(cliente);
        }

        if (opcao == "2")
        {
            var clientes = repo.ListarClientes();

            foreach (var Cliente in clientes)
            {
                Console.WriteLine($"Cliente:\n ID: {Cliente.Id} NOME: {Cliente.Nome}, EMAIL: {Cliente.Email}, CPF: {Cliente.Cpf}");
            }
        }

        if (opcao == "3")
        {
            Console.WriteLine("Informe o ID do Cliente");
            repo.DeletarCliente(Guid.Parse(Console.ReadLine() ?? string.Empty));

            Console.WriteLine("Cliente deletado!");
        }

        if (opcao == "4")
        {
            Console.WriteLine("Informe o ID do Cliente");
            repo.BuscarClienteporId(Guid.Parse(Console.ReadLine() ?? string.Empty));
        }

        if(opcao == "0")
        {
            Console.WriteLine("Saindo do menu de clientes...");
        }
    }
}

