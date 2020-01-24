using ArdalisRating.Context;
using ArdalisRating.Logger;
using ArdalisRating.PolicyRater;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArdalisRating
{
    public class RaterFactory : IContext
    {
        //public Rater Create(Policy policy, RatingEngine engine)
        //{
        //    switch(policy.Type)
        //    {
        //        case PolicyType.Auto:
        //            return new AutoPolicyRater(engine, engine.Logger);

        //        case PolicyType.Land:
        //            return new LandPolicyRater(engine, engine.Logger);

        //        case PolicyType.Life:
        //            return new LifePolicyRater(engine, engine.Logger);

        //        default:
        //            return null;
        //    }
        //}

        public Rater Create(Policy policy, ILogger logger)
        {
            try
            {
                return (Rater)Activator.CreateInstance(
                    Type.GetType($"ArdalisRating.PolicyRater.{policy.Type}PolicyRater"),
                    new object[] {logger});
            }
            catch
            {
                return new UnknownPolicyRater(logger);
            }
        }
    }
}
