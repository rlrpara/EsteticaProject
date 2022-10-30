using Microsoft.Extensions.DependencyInjection;
using VendaFacil.Domain.Interface;
using VendaFacil.Infra.Data.Repositories;
using VendaFacil.Service.Interface;
using VendaFacil.Service.Service;

namespace VendaFacil.CrossCutting.Ioc
{
    public static class NativeInjector
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            //services.AddSingleton(configuration);

            #region Services
            services.AddTransient<ICartaoService, CartaoService>();
            services.AddTransient<ICategoriaService, CategoriaServie>();
            services.AddTransient<IEmpresaService, EmpresaService>();
            services.AddTransient<IUsuarioService, UsuarioService>();

            #endregion

            #region Repositories
            services.AddTransient<ICartaoRepository, CartaoRepository>();
            services.AddTransient<ICategoriaRepository, CategoriaRepository>();
            services.AddTransient<IEmpresaRepository, EmpresaRepository>();
            services.AddTransient<IUsuarioRepository, UsuarioRepository>();
            services.AddTransient<IBaseRepository, BaseRepository>();
            #endregion
        }
    }
}