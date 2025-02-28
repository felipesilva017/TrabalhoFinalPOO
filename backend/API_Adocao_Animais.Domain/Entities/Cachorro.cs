using API_Adocao_Animais.Domain.Entities;

namespace API_Adocao_Animais.Domain.Entities
{
    public class Cachorro : Animal
    {
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
