using Contracts.DataTypes;

namespace AutomaticRatingMechanism.PolicyRater
{
    public abstract class Rater
    {
        public abstract decimal Rate(IPolicy policy);
    }
}
