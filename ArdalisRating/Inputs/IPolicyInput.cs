using System;
using System.Collections.Generic;
using System.Text;

namespace ArdalisRating.Inputs
{
     public interface IPolicyInput
    {
        Policy GetPolicyFromSource();
    }
}
