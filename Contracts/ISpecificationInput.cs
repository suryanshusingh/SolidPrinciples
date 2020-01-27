using Contracts.DataTypes;

namespace Contracts
{
    public interface ISpecificationInput
    {
        IPolicy GetPolicyFromSource();
    }
}
