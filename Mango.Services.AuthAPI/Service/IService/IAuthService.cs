using Mango.Services.AuthAPI.Models.DTO;

namespace Mango.Services.AuthAPI.Service.IService
{
    public interface IAuthService
    {
        Task<UserDto> Register(RegistrationRequestDTO registrationRequestDTO);
        Task<LoginResponseDto> Login(LoginRequestDto loginRequestDto);
    }
}
