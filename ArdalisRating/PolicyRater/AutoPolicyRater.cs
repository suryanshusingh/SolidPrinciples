﻿using ArdalisRating.Logger;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArdalisRating.PolicyRater
{
    class AutoPolicyRater : Rater
    {
        private ILogger logger;
        public AutoPolicyRater(ILogger logger)
        {
            this.logger = logger;
        }
        public override decimal Rate(Policy policy)
        {
            logger.Log("Rating AUTO policy...");
            logger.Log("Validating policy.");
            if (String.IsNullOrEmpty(policy.Make))
            {
                logger.Log("Auto policy must specify Make");
                return 0;
            }
            if (policy.Make == "BMW")
            {
                if (policy.Deductible < 500)
                {
                    return 1000m;
                }
                return 900m;
            }
            return 800m;
        }
    }
}
