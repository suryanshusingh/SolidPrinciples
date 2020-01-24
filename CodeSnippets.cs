public Policy GetPolicyFromSource()
        {
            string policyJson = File.ReadAllText("policy.json");
            var policy = JsonConvert.DeserializeObject<Policy>(policyJson,
                new StringEnumConverter());
            return policy;
        }

public ReadFromFile Reader { get; set; } = new ReadFromFile();

var policy = Reader.GetPolicyFromSource();

switch (policy.Type)
            {
                case PolicyType.Auto:
                    var rater = new AutoPolicyRater(this, Logger);
                    rater.Rate(policy);
                    break;

                case PolicyType.Land:
                    var rater2 = new LandPolicyRater(this, Logger);
                    rater2.Rate(policy);
                    break;

                case PolicyType.Life:
                    var rater3 = new LifePolicyRater(this, Logger);
                    rater3.Rate(policy);
                    break;

                default:
                    Logger.Log("Unknown policy type");
                    break;
            }


var factory = new RaterFactory();

            var rater = factory.Create(policy, this);
            rater.Rate(policy);


return new UnknownPolicyRater(engine, engine.Logger);
