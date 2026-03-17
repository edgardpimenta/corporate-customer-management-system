using CadastrodeClientes.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CadastrodeClientes.Repository
{
    public class ClienteRepository
    {
        public void Salvar(Cliente cliente)
        {
            {

                Cliente clienteSalvo = new Cliente();
                var caminhoArquivo = @"C:\Windows\temp\CadastrodeFuncionario.txt";
                var streamWriter = new StreamWriter(caminhoArquivo, true);

                streamWriter.WriteLine(cliente.Id);
                streamWriter.WriteLine(cliente.Nome);
                streamWriter.WriteLine(cliente.Email);
                streamWriter.WriteLine(cliente.Telefone);
                streamWriter.WriteLine(cliente.DataHoraCadastro);

                //fechando o streamWriter
                streamWriter.Close();

            }
        }
    }
}
