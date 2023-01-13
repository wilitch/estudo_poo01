//namespace -> define a localização da classe no projeto
using ProjetoAula01.Entities;
using ProjetoAula01.Repositories;

namespace ProjetoAula01
{
    //declaração da classe
    public class Program
    {
        //função (método) para executar o projeto
        public static void Main(string[] args)
        {
            //imprimir mensagem no prompt
            Console.WriteLine("\n *** CONTROLE DE CLIENTES *** \n");

            //declarando um objeto para a classe cliente
            var cliente = new Cliente(); //var só pode ser utilizado para variável local e não para atributos

            //gerando o id do cliente
            cliente.Id = Guid.NewGuid();

            //ler o nome do cliente
            Console.Write("ENTRE COM O NOME DO CLIENTE....: ");
            cliente.Nome = Console.ReadLine();

            //ler o telefone do cliente
            Console.Write("ENTRE COM O TELEFONE...........: ");
            cliente.Telefone = Console.ReadLine();

            Console.Write("ENTRE COM O EMAIL..............: ");
            cliente.Email = Console.ReadLine();

            Console.Write("ENTRE COM O CPF................: ");
            cliente.Cpf = Console.ReadLine();

            //imprimindo os dados do cliente no console
            /*
            Console.WriteLine("\nDADOS DO CLIENTE:");
            Console.WriteLine("\tID........: " + cliente.Id);
            Console.WriteLine("\tNOME......: " + cliente.Nome);
            Console.WriteLine("\tTELEFONE..: " + cliente.Telefone);
            Console.WriteLine("\tEMAIL.....: " + cliente.Email);
            Console.WriteLine("\tCPF.......: " + cliente.Cpf);
            */
            //outra forma de imprimir - através da interpolação de cadeia de caracteres usando $
            Console.WriteLine("\nDADOS DO CLIENTE:");
            Console.WriteLine($"\tID........: {cliente.Id}");
            Console.WriteLine($"\tNOME......: {cliente.Nome}");
            Console.WriteLine($"\tTELEFONE..: {cliente.Telefone}");
            Console.WriteLine($"\tEMAIL.....: {cliente.Email}");
            Console.WriteLine($"\tCPF.......: {cliente.Cpf}");

            //exportação dos dados do cliente para arquivo
            try //tentativa
            {
                //criando um objeto (variável de instância) para ClienteRepository
                var clienteRepository = new ClienteRepository();

                //gravando os dados do cliente em arquivo
                clienteRepository.ExportarDados(cliente);

                Console.WriteLine("\nDADOS GRAVADOS COM SUCESSO!");
            
            }
            catch(Exception e) //captura de erro
            { 
                Console.WriteLine("\nERRO AO CADASTRAR CLIENTE!");
            
            }

            //pausar a execução do prompt
            Console.ReadKey();
        }
    }
}