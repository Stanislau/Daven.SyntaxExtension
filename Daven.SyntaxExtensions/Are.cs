using System.Linq;

namespace Daven.SyntaxExtensions
{
    public static class Are
    {
        /// <summary>
        /// Check that items are not null 123wqe4. sdfe
        /// </summary>
        public static bool NotNull(params object[] items)
        {
            return items.All(item => item != null);
        }
    }
}