using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp1.ClassLibrary.Services
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddBlazorToastr(this IServiceCollection services)
        => services.AddScoped<ToastrService>();

        
    }
}
