using api.tork.challenge.DbRepository.Context;
using api.tork.challenge.DbRepository.V1.Repositories;
using api.tork.challenge.domain.Adapters.DbRepositories;
using Microsoft.Extensions.DependencyInjection;

namespace api.tork.challenge.DbRepository.DependencyInjection
{
    public static class DbRepositoryAdapterServiceCollectionExtension
    {
        public static IServiceCollection AddDbRepositoryAdapter(
            this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));
            
            services.AddSingleton<IBookDbRepositoryAdapter, BookDbRepository>();

            return services;
        }
    }
}
