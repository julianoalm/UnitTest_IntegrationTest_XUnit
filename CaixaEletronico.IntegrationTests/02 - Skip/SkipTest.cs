using CaixaEletronico.Api;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Training_Tests.IntegrationTests
{
    [Collection(nameof(IntegrationApiTestFixtureCollection))]
    public class SkipTest
    {
        private readonly IntegrationTestFixture<StartupApiTests> _integrationTestFixture;

        public SkipTest(IntegrationTestFixture<StartupApiTests> integrationTestFixture)
        {
            _integrationTestFixture = integrationTestFixture;

        }

        [Fact(DisplayName = "Saque com sucesso", Skip = "Teste defasado, não mais necessário")]
        public async Task Saque_com_sucesso()
        {
            var requisicao = await _integrationTestFixture.Client.PostAsync($"/api/CaixaEletronico/saque/100", new StringContent("", Encoding.UTF8, "application/json"));
            var resposta = await requisicao.Content.ReadAsStringAsync();

            Assert.True(requisicao.IsSuccessStatusCode);
        }
    }
}
