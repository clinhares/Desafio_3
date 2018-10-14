namespace Desafio3
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public int Idade { get; set; }

        public Pessoa(int id, string nome, string email, string telefone, int idade)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Telefone = telefone;
            Idade = idade;
        }

        public Pessoa(){}
    }
}