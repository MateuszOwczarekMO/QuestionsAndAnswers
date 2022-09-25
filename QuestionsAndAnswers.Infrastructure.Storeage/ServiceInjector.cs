using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace QuestionsAndAnswers.Infrastructure.Storeage
{
    public static class ServiceInjector
    {
        public static IServiceCollection AddQuestionsAndAnswersDbContext(this IServiceCollection services, string connectionString)
        {
            services.AddDbContextPool<QuestionsAndAnswersDbContext>(
                options => options.UseSqlite(connectionString));

            return services;
        }
    }
}
