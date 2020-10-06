using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciadorCondominios.Extensions
{
    public static class ConfiguracaoCookiesExtension
    {
        public static void ConfigurarCookies(this IServiceCollection service)
        {
            service.ConfigureApplicationCookie(opcao => 
            {
                opcao.Cookie.Name = "IdentityCookies";
                opcao.Cookie.HttpOnly = true;
                opcao.ExpireTimeSpan = TimeSpan.FromMinutes(60);
                opcao.LoginPath = "/Usuarios/Login";
            });
        }
    }
}
