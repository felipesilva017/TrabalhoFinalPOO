using API_Adocao_Animais.Domain.Entities;
using API_Adocao_Animais.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

public class AdocaoRepository : IAdocaoRepository
{
    private readonly AdocaoDbContext _context;

    public AdocaoRepository(AdocaoDbContext context)
    {
        _context = context;
    }

    public List<Animal> GetTodos()
    {
        return _context.Animais.ToList();
    }

    public void Adicionar(Animal animal)
    {
        _context.Animais.Add(animal);
        _context.SaveChanges();
    }

    public void Remover(Animal animal)
    {
        _context.Animais.Remove(animal);
        _context.SaveChanges();
    }
}
