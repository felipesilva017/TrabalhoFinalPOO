using API_Adocao_Animais.Domain.Entities;
using API_Adocao_Animais.Domain.Interfaces;

namespace API_Adocao_Animais.Application.Services
{
    public class AdocaoService : IAdocaoService
    {
        private readonly IAdocaoRepository _adocaoRepository;

        public AdocaoService(IAdocaoRepository adocaoRepository)
        {
            _adocaoRepository = adocaoRepository;
        }

        public List<Animal> GetTodosAnimais()
        {
            return _adocaoRepository.GetTodos();
        }
        public void AdicionarAnimal(Animal animal)
        {
            _adocaoRepository.Adicionar(animal);
        }

        public void AdotarAnimal(Adotante adotante, Animal animal)
        {
            _adocaoRepository.Remover(animal);
        }
    }
}
