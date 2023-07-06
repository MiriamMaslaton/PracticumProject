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
    public class UserSevice: IUserService
    {
        private readonly IUserRepository _UserRepository;
        private readonly IMapper _mapper;

        public UserSevice(IUserRepository userRepository, IMapper mapper)
        {
            _UserRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<UserDTO> AddAsync(UserDTO user)
        {
           throw new NotImplementedException();
        }

  
        public async Task DeleteAsync(string id)
        {
            await _UserRepository.DeleteAsync(id);
        }


        public async Task<UserDTO> GetByIdAsync(string id)
        {
            return _mapper.Map<UserDTO>(await _UserRepository.GetByIdAsync(id));

        }

 
        public async Task<List<UserDTO>> GetListAsync()
        {
            return _mapper.Map<List<UserDTO>>(await _UserRepository.GetAllAsync());
        }

        public async Task<UserDTO> UpdateAsync(UserDTO user)
        {
            return _mapper.Map<UserDTO>(await _UserRepository.UpdateAsync(_mapper.Map<User>(user)));

        }

    }
}
