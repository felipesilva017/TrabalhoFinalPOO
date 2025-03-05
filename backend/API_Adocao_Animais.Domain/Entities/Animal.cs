namespace API_Adocao_Animais.Domain.Entities
{
    public abstract class Animal
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Especie { get; protected set; }
        public int AbrigoId { get; set; }
        public Abrigo Abrigo { get; set; }

        public abstract void EmitirSom();
    }
}
