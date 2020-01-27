using AutomaticRatingMechanism.Logger;
using Contracts.DataTypes;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomaticRatingMechanism.PolicyRater
{
    public class UnknownPolicyRater : Rater
    {
        private ILogger logger;
        public UnknownPolicyRater(ILogger logger)
        {
            this.logger = logger;
        }
        public override decimal Rate(IPolicy policy)
        {
            logger.Log("Unknown Policy Type");
            return 0;
        }
    }
}
