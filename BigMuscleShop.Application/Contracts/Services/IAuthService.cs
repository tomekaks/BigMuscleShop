using BigMuscleShop.Application.Dtos.UserDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigMuscleShop.Application.Contracts.Services
{
    public interface IAuthService
    {
        Task Register(RegisterDto registerDto);
        Task<AuthResponseDto> Login(LoginDto loginDto);
    }
}
