#region Using

using Ambev.DeveloperEvaluation.Domain.Common;

#endregion

namespace Ambev.DeveloperEvaluation.Domain.Entities
{
    public class Branch : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
    }
}
