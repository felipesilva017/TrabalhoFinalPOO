using System.Collections.Generic;

namespace API_Adocao_Animais.Domain.Entities
{
    public class Adotante : Pessoa
    {
        public Animal AnimalAdotado { get; set; }
        public string TelefoneContato { get; private set; }

        private Adotante() { }

        public Adotante(string nome, string telefone)
        {
            Nome = nome;
            TelefoneContato = telefone;
        }
    }
}
