using AutoMapper;
using Registration.Common.DTOs;
using Registration.Repositories.Entities;
using Registration.Repositories.Interface;
using Registration.Repositories.Repositories;
using Registration.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration.Services.Services
{
    public class ChildService: IChildService
    {
        private readonly IChildRepository _childRepository;
        private readonly IMapper _mapper;

        public ChildService(IChildRepository childRepository, IMapper mapper)
        {
            _childRepository = childRepository;
            _mapper = mapper;
        }

        public async Task<ChildDTO> AddAsync(ChildDTO child)
        {
            return _mapper.Map<ChildDTO>(await _childRepository.AddAsync(_mapper.Map<Child>(child)));

        }


        public async Task DeleteAsync(string id)
        {
            await _childRepository.DeleteAsync(id);
        }


        public async Task<ChildDTO> GetByIdAsync(string id)
        {
            return _mapper.Map<ChildDTO>(await _childRepository.GetByIdAsync(id));

        }


        public async Task<List<ChildDTO>> GetListAsync()
        {
            return _mapper.Map<List<ChildDTO>>(await _childRepository.GetAllAsync());
        }

        public async Task<ChildDTO> UpdateAsync(ChildDTO child)
        {
            return _mapper.Map<ChildDTO>(await _childRepository.UpdateAsync(_mapper.Map<Child>(child)));

        }





    }
}
