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
        //private ILogger logger;
        //private IPolicyInput policyInput;
        //private IContext ratingContext;
        //public RatingEngine(ILogger logger, IPolicyInput policyInput, IContext ratingContext)
        //{
        //    this.logger = logger;
        //    this.policyInput = policyInput;
        //    this.ratingContext = ratingContext;
        //}
       
        //public decimal Rating { get; set; }
        //public void Rate()
        //{
        //    logger.Log("Starting rate.");

        //    logger.Log("Loading policy.");
        //    var policy = policyInput.GetPolicyFromSource();
        //    var rater = ratingContext.Create(policy, logger);
        //    Rating = rater.Rate(policy);

        //    logger.Log("Rating completed.");
        //}
    }
}
