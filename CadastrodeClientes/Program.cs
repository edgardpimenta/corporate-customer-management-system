using CadastrodeClientes.Entities;
using CadastrodeClientes.Repository;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Bem-vindo ao sistema de cadastro de clientes!");
        Console.WriteLine("---------------------------------------------");
        Console.WriteLine();

        Cliente cliente = new Cliente();
        {
            Console.WriteLine("Digite o nome do cliente..........:");
            cliente.Nome = Console.ReadLine() ?? string.Empty;

            Console.WriteLine("Digite o email do cliente..........:");
            cliente.Email = Console.ReadLine() ?? string.Empty;

            Console.WriteLine("Digite o telefone do cliente..........:");
            cliente.Telefone = Console.ReadLine() ?? string.Empty;

            Console.WriteLine();

            //Imprimindo os dados do cliente
         


            Console.WriteLine("Imprimindo os dados do cliente.....");
            Console.ReadKey();

            Console.WriteLine();

            Console.WriteLine($"ID: {cliente.Id}");
            Console.WriteLine($"Cliente: {cliente.Nome}");
            Console.WriteLine($"Email: {cliente.Email}");
            Console.WriteLine($"Telefone: {cliente.Telefone}");
            Console.WriteLine($"Data hora do cadastro: {cliente.DataHoraCadastro}");

            Console.WriteLine();

            Console.WriteLine("Cliente cadastrado com sucesso!");
            Console.ReadKey();

            var clienteRepositorio = new ClienteRepository();
            clienteRepositorio.Salvar(cliente);
        }
    }
}