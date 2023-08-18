using BeautySolun_API.Integration.Response;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace BeautySolun_API.Integration.Interface
{
    public interface IViaCodeIntegration
    {
        Task<ViaCodeResponse> GetDataCode(string code);
    }
}
