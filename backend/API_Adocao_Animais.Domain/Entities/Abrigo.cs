using System.Collections.Generic;

namespace API_Adocao_Animais.Domain.Entities
{
    public class Abrigo
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public List<Animal> Animais { get; set; } = new List<Animal>();
        public static int GetQuantidadeAnimais(Abrigo abrigo) => abrigo.Animais.Count;
    }
}
