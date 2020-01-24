using ArdalisRating.Logger;
using ArdalisRating.PolicyRater;

namespace ArdalisRating.Context
{
    public interface IContext
    {
        Rater Create(Policy policy, ILogger logger);
    }
}