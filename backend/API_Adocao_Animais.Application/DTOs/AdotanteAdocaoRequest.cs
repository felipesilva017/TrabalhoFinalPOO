using API_Adocao_Animais.Domain.Entities;

namespace API_Adocao_Animais.Application.DTOs
{
    public class AdotanteAdocaoRequest
    {
        public Adotante Adotante { get; set; }
        public Animal Animal { get; set; }
    }
}