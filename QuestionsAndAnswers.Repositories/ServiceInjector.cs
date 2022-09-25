using Microsoft.Extensions.DependencyInjection;

namespace QuestionsAndAnswers.Repositories
{
    public static class ServiceInjector
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IQnARepository, QnARepository>();
            return services;
        }
    }
}
