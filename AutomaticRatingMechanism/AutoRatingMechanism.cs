using AutomaticRatingMechanism.Inputs;
using AutomaticRatingMechanism.Logger;
using Contracts;
using Contracts.DataTypes;
using System;
using Unity;

namespace AutomaticRatingMechanism
{
    public class AutoRatingMechanism : IMechanism
    {
        private ILogger logger;
        private IPolicy policy;
        public AutoRatingMechanism(ILogger logger)
        {
            this.logger = logger;
        }

        public decimal Rating { get; set; }

        [InjectionMethod]
        public void GetPolicy(ISpecificationInput sourceInput)
        {
            policy = sourceInput.GetPolicyFromSource();
        }
        
        public decimal Rate()
        {
            LogStart();

            var factory = new RaterFactory();
            var rater = factory.Create(policy, logger);
            Rating = rater.Rate(policy);

            logger.Log("Rating completed.");
            return Rating;
        }

        private void LogStart()
        {
            logger.Log("Starting rate.");
            logger.Log("Loading policy.");
        }
    }
}
