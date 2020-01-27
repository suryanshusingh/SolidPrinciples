using Contracts;
using Contracts.DataTypes;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AutomaticRatingMechanism.Inputs
{
    public class SpecificationInputFromFile : ISpecificationInput
    {
        public IPolicy GetPolicyFromSource()
        {
            string policyJson = File.ReadAllText("policy.json");
            var policy = JsonConvert.DeserializeObject<Policy>(policyJson,
                new StringEnumConverter());
            return policy;
        }
    }
}
