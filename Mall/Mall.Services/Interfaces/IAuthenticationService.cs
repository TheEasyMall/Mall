using Mall.DTOs.Auth.Requests;
using Mall.DTOs.Auth.Responses;
using MayNghien.Models.Response.Base;

namespace Mall.Services.Interfaces
{
    public interface IAuthenticationService
    {
        Task<AppResponse<LogInResponse>> LogInUser(LogInRequest request);
        Task<AppResponse<LogInRequest>> GetInforAccount();
        Task<AppResponse<SignUpResponse>> SignUpUser(SignUpRequest request);
    }
}
