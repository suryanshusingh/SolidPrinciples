using AutomaticRatingMechanism.Logger;
using Contracts.DataTypes;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomaticRatingMechanism.PolicyRater
{
    class LandPolicyRater : Rater
    {
        private ILogger logger;
        public LandPolicyRater(ILogger logger)
        {
            this.logger = logger;
        }
        public override decimal Rate(IPolicy policy)
        {
            logger.Log("Rating LAND policy...");
            logger.Log("Validating policy.");
            if (policy.BondAmount == 0 || policy.Valuation == 0)
            {
                logger.Log("Land policy must specify Bond Amount and Valuation.");
                return 0;
            }
            if (policy.BondAmount < 0.8m * policy.Valuation)
            {
                logger.Log("Insufficient bond amount.");
                return 0;
            }
            return policy.BondAmount * 0.05m;
        }
    }
}
