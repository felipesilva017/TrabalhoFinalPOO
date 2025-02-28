namespace API_Adocao_Animais.Domain.Entities
{
    public abstract class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
    }
}
