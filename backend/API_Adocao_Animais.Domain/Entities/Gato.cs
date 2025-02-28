using API_Adocao_Animais.Domain.Entities;

namespace API_Adocao_Animais.Domain.Entities
{
    public class Gato : Animal
    {
        public Gato()
        {
            Especie = "Gato";
        }
        public override void EmitirSom()
        {
            Console.WriteLine("Miau!");
        }
    }
}
