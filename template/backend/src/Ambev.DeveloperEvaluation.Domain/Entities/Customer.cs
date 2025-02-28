#region Using

using Ambev.DeveloperEvaluation.Domain.Common;

#endregion

namespace Ambev.DeveloperEvaluation.Domain.Entities
{
    public class Customer : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
    }
}
