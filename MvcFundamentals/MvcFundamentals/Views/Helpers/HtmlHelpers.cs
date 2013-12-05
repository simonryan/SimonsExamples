using System.Web.Mvc;

namespace MvcFundamentals.Views.Helpers
{
    public static class HtmlHelpers
    {
        public static TagBuilder Image(this HtmlHelper helper, string url, string alt)
        {
            if (!string.IsNullOrEmpty(url))
            {
                var imageTag = new TagBuilder("img");
                imageTag.MergeAttribute("src", url);
                imageTag.MergeAttribute("alt", alt);
                return imageTag;
            }
            return null;
        }
    }
}