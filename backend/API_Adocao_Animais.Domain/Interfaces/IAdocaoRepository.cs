using API_Adocao_Animais.Domain.Entities;

namespace API_Adocao_Animais.Domain.Interfaces
{
    public interface IAdocaoRepository
    {
        List<Animal> GetTodos();
        void Adicionar(Animal animal);
        void Remover(Animal animal);

    }
}
