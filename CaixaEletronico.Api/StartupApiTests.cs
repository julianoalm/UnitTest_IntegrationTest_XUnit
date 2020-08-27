using CaixaEletronico.Domain;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CaixaEletronico.Api
{
    //A fixture criada neste exemplo lhe dará poder de interagir com camada de Api e testar todo fluxo dali em diante.
    //Você deve criar uma classe similar a classe Startup, mas, preferencialmente removendo todas dependências e serviços desnecessários 
    //para o teste de integração, como por exemplo swagger.Caso você utilize swagger em seu projeto, no startup do teste de integração 
    //seria desnecessário a ativação deste serviço.O projeto Api deve ser referenciado no seu projeto de teste de integração.

    public class StartupApiTests
    {
        public StartupApiTests(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<ICaixa, Caixa>();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_3_0);
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            
        }
    }
}
