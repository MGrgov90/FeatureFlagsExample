using Microsoft.FeatureManagement;

namespace FeatureFlags.Http
{
    [FilterAlias(nameof(MyCustomFilter))]
    public class MyCustomFilter : IFeatureFilter
    {
        public Task<bool> EvaluateAsync(FeatureFilterEvaluationContext context)
        {
            var settings = context.Parameters.Get<MyCustomFilterSettings>()
                ?? throw new ArgumentNullException(nameof(MyCustomFilterSettings));
            return Task.FromResult(settings.LuckyNumber == 47);
        }
    }
}