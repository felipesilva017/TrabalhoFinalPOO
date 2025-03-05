using API_Adocao_Animais.Domain.Entities;

namespace API_Adocao_Animais.Domain.Entities
{
    public class Cachorro : Animal
    {
        public int AbrigoId { get; set; }
        public Cachorro()
        {
            Especie = "Cachorro";
        }
        public override void EmitirSom()
        {
            Console.WriteLine("Au Au!");
        }
    }
}
