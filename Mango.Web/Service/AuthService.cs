using Mango.Web.Models;
using Mango.Web.Service.IService;
using Mango.Web.Utility;

namespace Mango.Web.Service
{
    public class AuthService : IAuthService
    {
        private readonly IBaseService _baseServiceService;

        public AuthService(IBaseService baseServiceService)
        {
            _baseServiceService = baseServiceService;
        }

        public async Task<ResponseDto> AssigneRoleAsync(RegistrationRequestDto registrationRequestDTO)
        {
            return await _baseServiceService.SendAsync(new RequestDto()
            {
                ApiType = Utility.SD.ApiType.POST,
                Data = registrationRequestDTO,
                Url = SD.AuthAPIBase + "/api/auth/AssignRole"
            });
        }

        public async Task<ResponseDto> LoginAsync(LoginRequestDto loginRequestDto)
        {
            return await _baseServiceService.SendAsync(new RequestDto()
            {
                ApiType = Utility.SD.ApiType.POST,
                Data = loginRequestDto,
                Url = SD.AuthAPIBase + "/api/auth/login"
            });
        }

        public async Task<ResponseDto> RegisterAsync(RegistrationRequestDto registrationRequestDTO)
        {
            return await _baseServiceService.SendAsync(new RequestDto()
            {
                ApiType = Utility.SD.ApiType.POST,
                Data = registrationRequestDTO,
                Url = SD.AuthAPIBase + "/api/auth/register"
            });
        }
    }
}
