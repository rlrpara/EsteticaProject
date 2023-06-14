using Microsoft.Extensions.DependencyInjection;
using Estetica.Domain.Interface;
using Estetica.Infra.Data.Repositories;
using Estetica.Service.Interface;
using Estetica.Service.Service;

namespace Estetica.CrossCutting.Ioc
{
    public static class NativeInjector
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            //services.AddSingleton(configuration);

            #region Services
            services.AddTransient<IEmpresaService, EmpresaService>();
            services.AddTransient<IUsuarioService, UsuarioService>();
            services.AddTransient<ILoginService, LoginServices>();
            services.AddTransient<IClientesService, ClientesService>();

            #endregion

            #region Repositories
            services.AddTransient<IEmpresaRepository, EmpresaRepository>();
            services.AddTransient<IUsuarioRepository, UsuarioRepository>();
            services.AddTransient<ILoginRepository, LoginRepository>();
            services.AddTransient<IClientesRepository, ClientesRepository>();
            services.AddTransient<IBaseRepository, BaseRepository>();
            #endregion
        }
    }
}