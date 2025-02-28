using System.Collections.Generic;
using API_Adocao_Animais.Domain.Entities;

namespace API_Adocao_Animais.Domain.Interfaces
{
    public interface IAdocaoService
    {
        List<Animal> GetTodosAnimais();
        void AdicionarAnimal(Animal animal);
        void AdotarAnimal(Adotante adotante, Animal animal);
    }
}
