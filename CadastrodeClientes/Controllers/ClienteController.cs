using CadastrodeClientes.Dtos;
using CadastrodeClientes.Entities;
using CadastrodeClientes.Enums;
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

            Console.WriteLine("Informe o Tipo de Cliente:" +
                "1 - PessoaFisica" +
                "2 - PessoaJuridica");
            cliente.TipoDeCliente = (TipoDeCliente)Enum.Parse(typeof(TipoDeCliente), Console.ReadLine() ?? "");

            Console.WriteLine("Informe a Empresa do Cliente:" +
                "1 - MEI" +
                "2 - LTDA" +
                "3 - SA");
            cliente.EmpresaId = Guid.Parse(Console.ReadLine() ?? string.Empty);

            Console.WriteLine("Informe o Status do Cliente:" +
                "1 - Ativo" +
                "2 - Inativo" +
                "3 - Bloqueado");
            
            repo.CadastrarCliente(cliente);

            Console.WriteLine($"Cliente salvo com sucesso!" +
                $"Cliente: {createClienteDto.Nome}, {createClienteDto.Email}, {createClienteDto.Cpf}");
        }

        if (opcao == "2")
        {
            var clientes = repo.ListarClientes();

            foreach (var Cliente in clientes)
            {
                Console.WriteLine($"Cliente: {Cliente.Nome}, {Cliente.Email}, {Cliente.Cpf}");
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

