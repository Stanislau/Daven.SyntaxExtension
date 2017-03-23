using System.Linq;

namespace Daven.SyntaxExtensions
{
    /// <summary>
    /// 123
    /// </summary>
    public static class Are
    {
        /// <summary>
        /// Check that items are not null 123wqe4.
        /// </summary>
        public static bool NotNull(params object[] items)
        {
            return items.All(item => item != null);
        }
    }
}