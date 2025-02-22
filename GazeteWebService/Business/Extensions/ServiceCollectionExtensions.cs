using Business.Contracts;
using Business.Implementation;
using Business.Mapping.AutoMapper.Profiles;
using DataAccess.Contracts.Repositories;
using DataAccess.Ef.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Business.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddBusinessServices(this IServiceCollection services)
        {
            //-------------------------------PROFİLE------------------------------------
            services.AddAutoMapper(typeof(EkonomiProfile));
            services.AddAutoMapper(typeof(GundemProfile));  
            services.AddAutoMapper(typeof(HomeProfile));
            services.AddAutoMapper(typeof(OnsozProfile));
            services.AddAutoMapper(typeof(ResmiIlanlarProfile));
            services.AddAutoMapper(typeof(SporProfile));
            services.AddAutoMapper(typeof(YazarlarProfile));

            //-------------------------------MANAGER------------------------------------

            services.AddScoped<IEkonomiManager,EkonomiManager>();
            services.AddScoped<IGundemManager,GundemManager>();
            services.AddScoped<IHomeManager,HomeManager>();
            services.AddScoped<IOnsozOzelManager,OnsozManager>();
            services.AddScoped<IResmiIlanlarManager,ResmiIlanlarManager>();
            services.AddScoped<ISporManager,SporManager>();
            services.AddScoped<IYazarlarManager,YazarlarManager>();

            //--------------------------Repository Registrations-----------------------------
            services.AddScoped<IEkonomiRepository,EkonomiRepository>();
            services.AddScoped<IGundemRepository,GundemRepository>();
            services.AddScoped<IHomeRepository,HomeRepository>();
            services.AddScoped<IOnsozRepository,OnsozRepository>();
            services.AddScoped<IResmiIlanlarRepository,ResmiIlanlarRepository>();
            services.AddScoped<ISporRepository,SporRepository>();
            services.AddScoped<IYazarlarRepository,YazarlarRepository>();   


        }
    }
}
