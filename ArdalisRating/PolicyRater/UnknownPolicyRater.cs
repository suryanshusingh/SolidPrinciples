using ArdalisRating.Logger;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArdalisRating.PolicyRater
{
    public class UnknownPolicyRater : Rater
    {
        private ILogger logger;
        public UnknownPolicyRater(ILogger logger)
        {
            this.logger = logger;
        }
        public override decimal Rate(Policy policy)
        {
            logger.Log("Unknown Policy Type");
            return 0;
        }
    }
}
