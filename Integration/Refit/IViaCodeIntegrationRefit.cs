using BeautySolun_API.Integration.Response;
using Refit;

namespace BeautySolun_API.Integration.Refit
{
    public interface IViaCodeIntegrationRefit
    {
        [Get("/ws/{code}/json/")]
        Task<ApiResponse<ViaCodeResponse>> GetDataCode(string code);
    }
}
