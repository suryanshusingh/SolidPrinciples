using AutomaticRatingMechanism.Logger;
using AutomaticRatingMechanism.PolicyRater;
using Contracts.DataTypes;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomaticRatingMechanism
{
    public class RaterFactory
    {
        public Rater Create(IPolicy policy, ILogger logger)
        {
            try
            {
                return (Rater)Activator.CreateInstance(
                    Type.GetType($"AutomaticRatingMechanism.PolicyRater.{policy.Type}PolicyRater"),
                    new object[] { logger });
            }
            catch
            {
                return new UnknownPolicyRater(logger);
            }
        }
    }
}
