using System.Linq;

namespace Daven.SyntaxExtensions
{
    public static class Are
    {
        public static bool NotNull(params object[] items)
        {
            return items.All(item => item != null);
        }
    }
}