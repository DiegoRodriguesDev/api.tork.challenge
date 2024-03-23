using api.tork.challenge.application.Services;
using api.tork.challenge.domain.Services;
using Microsoft.Extensions.DependencyInjection;

namespace api.tork.challenge.application.DependencyInjection
{
    public static class ApplicationServiceCollectionExtension
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            services.AddScoped<IBookService, BookService>();

            return services;
        }
    }
}
