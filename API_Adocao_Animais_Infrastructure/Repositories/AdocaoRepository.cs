using System.Collections.Generic;
using API_Adocao_Animais.Domain.Entities;
using API_Adocao_Animais.Domain.Interfaces;

namespace API_Adocao_Animais.Infrastructure.Repositories
{
    public class AdocaoRepository : IAdocaoRepository
    {
        private readonly List<Animal> _animais;

        public AdocaoRepository()
        {
            _animais = new List<Animal>
            {
                new Cachorro { Id = 1, Nome = "Rex", Idade = 3 },
                new Gato { Id = 2, Nome = "Mia", Idade = 2 }
            };
        }

        public List<Animal> GetTodos()
        {
            return _animais;
        }
        public void Adicionar(Animal animal)
        {
            // TODO: Pegar ID
            // Verificar se existe esse ID
            // Se não existir, adicionar na List
            _animais.Add(animal);
        }

        public void Remover(Animal animal)
        {
            // TODO: Pegar ID
            // Verificar se existe esse ID
            // Se existir, remover na List
            // Tratar no controller, caso não exista
            _animais.Remove(animal);
        }
    }
}
