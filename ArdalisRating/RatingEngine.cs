using ArdalisRating.Context;
using ArdalisRating.Inputs;
using ArdalisRating.Logger;
using ArdalisRating.PolicyRater;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.IO;

namespace ArdalisRating
{
    /// <summary>
    /// The RatingEngine reads the policy application details from a file and produces a numeric 
    /// rating value based on the details.
    /// </summary>
    public class RatingEngine
    {
        private ILogger logger;
        private IPolicyInput policyInput;
        private IContext ratingContext;
        private Policy Policy { get; set; }
        public RatingEngine(ILogger logger, IPolicyInput policyInput, IContext ratingContext)
        {
            this.logger = logger;
            this.policyInput = policyInput;
            this.ratingContext = ratingContext;
            Policy = policyInput.GetPolicyFromSource();
        }
       
        public decimal Rating { get; set; }
        public void Rate()
        {
            logger.Log("Starting rate.");

            logger.Log("Loading policy.");
    
            var rater = ratingContext.Create(Policy, logger);
            Rating = rater.Rate(Policy);

            logger.Log("Rating completed.");
        }
    }
}
