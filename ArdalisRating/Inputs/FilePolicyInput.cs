using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ArdalisRating.Inputs
{
    public class FilePolicyInput : IPolicyInput
    {
        public Policy GetPolicyFromSource()
        {
            string policyJson = File.ReadAllText("policy.json");
            var policy = JsonConvert.DeserializeObject<Policy>(policyJson,
                new StringEnumConverter());
            return policy;
        }
        
    }
}
