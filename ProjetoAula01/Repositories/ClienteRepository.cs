using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoAula01.Entities;

//define a localização da classe
namespace ProjetoAula01.Repositories
{
    public class ClienteRepository
    {
        //método para receber um objeto do tipo Cliente
        //e gravar os seus dados em um arquivo TXT
        public void ExportarDados(Cliente cliente)
        {
            //abrindo um arquivo novo para escrita
            using (var streamWriter = new StreamWriter($"d:\\coti\\clientes\\cliente_{cliente.Id}.txt"))
            {
                //escrevendo o conteúdo do arquivo...
                streamWriter.WriteLine($"ID DO CLIENTE...: {cliente.Id}");
                streamWriter.WriteLine($"NOME............: {cliente.Nome}");
                streamWriter.WriteLine($"TELEFONE........: {cliente.Telefone}");
                streamWriter.WriteLine($"EMAIL...........: {cliente.Email}");
                streamWriter.WriteLine($"CPF.............: {cliente.Cpf}");                
            }
        }
    }
}
