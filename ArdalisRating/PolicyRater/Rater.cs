using System;
using System.Collections.Generic;
using System.Text;

namespace ArdalisRating.PolicyRater
{
    public abstract class Rater
    {
        public abstract decimal Rate(Policy policy);
    }
}
