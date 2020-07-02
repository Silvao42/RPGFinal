using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using WebCommerce.Dados;
using WebCommerce.Dominio.Interfaces;
using WebCommerce.Servico;

namespace WebCommerce.WebApi
{
    public class Startup
    {

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IArmaServico, ArmaServico>();
            services.AddTransient<IArmaRepositorio, ArmaRepositorio>();
            services.AddTransient<IArmaduraServico, ArmaduraServico>();
            services.AddTransient<IArmaduraRepositorio, ArmaduraRepositorio>();
            services.AddTransient<IArmaduraInventarioServico, ArmaduraInventarioServico>();
            services.AddTransient<IArmaduraInventarioRepositorio, ArmaduraInventarioRepositorio>();
            services.AddTransient<IArmaInventarioServico, ArmaInventarioServico>();
            services.AddTransient<IArmaInventarioRepositorio, ArmaInventarioRepositorio>();
            services.AddTransient<IAtributoServico, AtributoServico>();
            services.AddTransient<IAtributoRepositorio, AtributoRepositorio>();
            services.AddTransient<IClasseServico, ClasseServico>();
            services.AddTransient<IClasseRepositorio, ClasseRepositorio>();
            services.AddTransient<IFichaServico, FichaServico>();
            services.AddTransient<IFichaRepositorio, FichaRepositorio>();
            services.AddTransient<IFichaAtributoServico, FichaAtributoServico>();
            services.AddTransient<IFichaAtributoRepositorio, FichaAtributoRepositorio>();
            services.AddTransient<IFichaIdiomaServico, FichaIdiomaServico>();
            services.AddTransient<IFichaIdiomaRepositorio, FichaIdiomaRepositorio>();
            services.AddTransient<IIdiomaServico, IdiomaServico>();
            services.AddTransient<IIdiomaRepositorio, IdiomaRepositorio>();
            services.AddTransient<IItemServico, ItemServico>();
            services.AddTransient<IItemRepositorio, ItemRepositorio>();
            services.AddTransient<IItemInventarioServico, ItemInventarioServico>();
            services.AddTransient<IItemInventarioRepositorio, ItemInventarioRepositorio>();
            services.AddTransient<IJogadorServico, JogadorServico>();
            services.AddTransient<IJogadorRepositorio, JogadorRepositorio>();
            services.AddTransient<IListaMagiaServico, ListaMagiaServico>();
            services.AddTransient<IListaMagiaRepositorio, ListaMagiaRepositorio>();
            services.AddTransient<IMagiaServico, MagiaServico>();
            services.AddTransient<IMagiaRepositoro, MagiaRepositorio>();
            services.AddTransient<IMoedaServico, MoedaServico>();
            services.AddTransient<IMoedaRepositorio, MoedaRepositorio>();
            services.AddTransient<IMoedaInventarioServico, MoedaInventarioServico>();
            services.AddTransient<IMoedaInventarioRepositorio, MoedaInventarioRepositorio>();
            services.AddTransient<IPericiaServico, PericiaServico>();
            services.AddTransient<IPericiaRepositorio, PericiaRepositorio>();
            services.AddTransient<IPericiaFichaServico, PericiaFichaServico>();
            services.AddTransient<IPericiaFichaRepositorio, PericiaFichaRepositorio>();
            services.AddTransient<IRacaServico, RacaServico>();
            services.AddTransient<IRacaRepositorio, RacaRepositorio>();

            services.AddScoped(typeof(IRepositorioBase<>), typeof(RepositorioBase<>));

            services.AddCors();
            services.AddControllers();

            //services.AddAuthorization((x) => x.AddPolicy("AutenticacaoBasica"));

            services.AddSwaggerGen(c => {
                c.SwaggerDoc("v1",
                    new OpenApiInfo
                    {
                        Title = "WebCommerce da disciplina de Lab 2 - 2020",
                        Version = "v1",
                        Description = "Projeto de WebApi - Descritivo",
                        Contact = new OpenApiContact
                        {
                            Name = "Sistemas de Informação 2020",
                            Url = new Uri("https://github.com/rcjuliano")
                        }
                    });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment()) {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors(x =>
                x.AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader()
            );

            // Ativando middlewares para uso do Swagger
            app.UseSwagger();
            app.UseSwaggerUI(c => {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "WebCommerce - v1");
            });

            app.UseRouting();
            app.UseAuthorization();

            app.UseEndpoints(endpoints => {
                endpoints.MapControllers();
            });
        }
    }
}
