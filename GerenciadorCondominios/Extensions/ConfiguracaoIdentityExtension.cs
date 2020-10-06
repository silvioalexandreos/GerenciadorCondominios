using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciadorCondominios.Extensions
{
    public static class ConfiguracaoIdentityExtension
    {
        public static void ConfigurarNomeUsuario(this IServiceCollection service)
        {
            service.Configure<IdentityOptions>(opcao =>
            {
                opcao.User.AllowedUserNameCharacters = "abcdefghijklmnopqrswxyzABCDEFGHIJKLMNOPQRSWXYZ0123456789-._@+";
                opcao.User.RequireUniqueEmail = true;
            });
        }

        public static void ConfigurarSenhaUsuario(this IServiceCollection service)
        {
            service.Configure<IdentityOptions>(opcao =>
            {
                opcao.Password.RequireDigit = true;
                opcao.Password.RequiredLength = 8;
                opcao.Password.RequireLowercase = true;
                opcao.Password.RequireNonAlphanumeric = true;
                opcao.Password.RequireUppercase = true;
                opcao.Password.RequiredUniqueChars = 0;
            });
        }
    }
}
