using api.tork.challenge.DbRepository.V1.Repositories;
using api.tork.challenge.domain.Adapters.DbRepositories;
using Microsoft.Extensions.DependencyInjection;

namespace api.tork.challenge.DbRepository.DependencyInjection
{
    public static class DbRepositoryAdapterServiceCollectionExtension
    {
        public static IServiceCollection AddDbRepositoryAdapter(
            this IServiceCollection services,
            DbRepositoryAdapterConfiguration dbRepositoryAdapterConfiguration)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));
            if (dbRepositoryAdapterConfiguration == null) throw new ArgumentNullException(nameof(dbRepositoryAdapterConfiguration));

            services.AddSingleton<IBookDbRepositoryAdapter, BookDbRepository>();

            return services;
        }
    }
}
