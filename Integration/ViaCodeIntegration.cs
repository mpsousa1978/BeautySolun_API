using BeautySolun_API.Integration.Interface;
using BeautySolun_API.Integration.Refit;
using BeautySolun_API.Integration.Response;

namespace BeautySolun_API.Integration
{
    public class ViaCodeIntegration : IViaCodeIntegration
    {
        private readonly IViaCodeIntegrationRefit _viaCodeIntegrationRefit;

        public ViaCodeIntegration (IViaCodeIntegrationRefit viaCodeIntegrationRefit)
        {
            _viaCodeIntegrationRefit = viaCodeIntegrationRefit;
        }

        public async Task<ViaCodeResponse> GetDataCode(string code)
        {
            var responseData = await _viaCodeIntegrationRefit.GetDataCode(code);

            if (responseData != null)
            {
                return responseData.Content;
            }
            return null;
        }
    }
}
