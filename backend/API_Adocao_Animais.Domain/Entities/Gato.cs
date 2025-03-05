using API_Adocao_Animais.Domain.Entities;

namespace API_Adocao_Animais.Domain.Entities
{
    public class Gato : Animal
    {
        public int AbrigoId { get; set; }

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
