using AutoMapper;
using ProjetoIntegradorII.Application.DTOs;
using ProjetoIntegradorII.Application.Interfaces;
using ProjetoIntegradorII.Domain.Entities;
using ProjetoIntegradorII.Domain.Interfaces;

namespace ProjetoIntegradorII.Application.Services
{
    public class TitleService : ITitleService
    {
        private ITitleRepository _titleRepository;
        
        private readonly IMapper _mapper;

        public TitleService(ITitleRepository titleRepository, IMapper mapper)
        {
            _titleRepository = titleRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<TitleDto>> GetTitles()
        {
            var titleEntity = await _titleRepository.GetTitles();
            return _mapper.Map<IEnumerable<TitleDto>>(titleEntity);
        }

        public async Task<TitleDto> GetById(int? id)
        {
            var titleEntity = await _titleRepository.GetTitleById(id);
            return _mapper.Map<TitleDto>(titleEntity);
        }

        public async Task<TitleDto> Add(TitleDto titleDto)
        {
            var titleEntity = _mapper.Map<Title>(titleDto);
            await _titleRepository.Create(titleEntity);
            return _mapper.Map<TitleDto>(titleEntity);
        }

        public async Task<TitleDto> Update(TitleDto titleDto)
        {
            var titleEntity = _mapper.Map<Title>(titleDto);
            await _titleRepository.Update(titleEntity);
            return _mapper.Map<TitleDto>(titleEntity);
        }

        public async Task Remove(int id)
        {
            var titleEntity = await _titleRepository.GetTitleById(id);
            if(titleEntity != null)
            {
                await _titleRepository.Remove(titleEntity);
            }
        }
    }
}
