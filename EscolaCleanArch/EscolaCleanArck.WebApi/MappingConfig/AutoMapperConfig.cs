using EscolaCleanArch.Application.Mappings;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EscolaCleanArch.WebApi.MappingConfig
{
    public static class AutoMapperConfig
    {
        public static void AddAutoMapperConfiguration(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentException(nameof(services));

            services.AddAutoMapper(typeof(DomainToViewModelMappinggProfile),
            typeof(ViewModelToDomainMappingProfile));

        }
    }
}
