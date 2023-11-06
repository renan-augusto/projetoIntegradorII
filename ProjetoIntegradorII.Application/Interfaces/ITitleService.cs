using ProjetoIntegradorII.Application.DTOs;

namespace ProjetoIntegradorII.Application.Interfaces
{
    public interface ITitleService
    {
        Task<IEnumerable<TitleDto>> GetTitles();
        Task<TitleDto> GetById(int? id);
        Task<TitleDto> Add(TitleDto title);
        Task<TitleDto> Update(TitleDto title);
        Task Remove(int id);
    }
}
