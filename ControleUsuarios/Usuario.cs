namespace ControleUsuarios
{
    public class Usuario
    {
        public Usuario()
        {
        }

        public Usuario(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public string Nome { get; set; }
        public int Idade { get; set; }

        public bool maiorDeIdade()
        {
            if (Idade >= 18) {
            return true;
            } else {
            return false;
            }
        }
    }
}
