using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//localização da classe dentro do projeto
namespace ProjetoAula01.Entities
{
    //declaração da classe
    public class Cliente
    {
        //atributos da classe (dados/campos)
        private Guid _id; //é uma boa prática o nome dos atributos começar com underline e em minúsculo.
        private string _nome;
        private string _telefone;
        private string _email;
        private string _cpf;

        //métodos da classe (funções para encapsulamento)
        public Guid Id //o nome do método deve ser igual ao do atributo, mas sendo a primeira letra em caixa alta
        {
            set { _id = value; } //entrada
            get { return _id; } //saída
        }
        public string Nome
        {
            set { _nome = value; }
            get { return _nome; }
        }
        public string Telefone
        {
            set { _telefone = value; }
            get { return _telefone; }
        }
        public string Email
        {
            set { _email = value; }
            get { return _email; }
        }
        public string Cpf
        {
            set { _cpf = value; }
            get { return _cpf; }           
        }
    }
}
