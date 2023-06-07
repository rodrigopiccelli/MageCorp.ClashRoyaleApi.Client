using System.Collections.Specialized;
using System.Web;

namespace MageCorp.ClashRoyaleApi.Client.Extensions
{
    internal static class NameValueCollectionExtensions
    {

        internal static NameValueCollection ConvertToHttpValueColletion(this NameValueCollection nameValueCollection)
        {
            var values = HttpUtility.ParseQueryString(string.Empty);
            var keys = nameValueCollection.AllKeys.Where(a => nameValueCollection[a] != null).ToList();
            foreach (var key in keys)
                values[key] = nameValueCollection[key];
            return values;
        }

    }
}
