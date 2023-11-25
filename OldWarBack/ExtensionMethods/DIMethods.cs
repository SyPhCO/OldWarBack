using Domain.Concrete;
using Infrastructure.Repository;

namespace OldWarBack.ExtensionMethods
{
    public static class DIMethods
    {
        #region Public Method
        /// <summary>
        /// Prepare l'injection de dépendance Custom
        /// </summary>
        /// <param name="services"></param>
        public static IServiceCollection AddInjections(this IServiceCollection services)
        {
            services.AddScoped<Repository<Rank>, RankRepository>();
            services.AddScoped<Repository<Category>, CategoryRepository>();
            services.AddScoped<Repository<Battle>, BattleRepository>();
            services.AddScoped<Repository<Country>, CountryRepository>();
            services.AddScoped<Repository<Alliance>, AllianceRepository>();
            services.AddScoped<UnitRepository>();
            services.AddScoped<Repository<GlobalWar>, GlobalWarRepository>();
            services.AddScoped<Repository<Faction>, FactionRepository>();
            services.AddScoped<Repository<ByHour>, ByHourRepository>();






            return services;
        }
        #endregion
    }
}
