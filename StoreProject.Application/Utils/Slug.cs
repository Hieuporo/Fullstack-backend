using Slugify;
using System.Xml.Linq;


namespace StoreProject.Application.Utils
{
    public static class Slug
    {
        public static string Create(string name)
        {
            var config = new SlugHelperConfiguration();

            // Add individual replacement rules
            config.StringReplacements.Add("&", "-");
            config.StringReplacements.Add(",", "-");

            // Keep the casing of the input string
            config.ForceLowerCase = false;

            // Create a helper instance with our new configuration
            var helper = new SlugHelper(config);

            var result = helper.GenerateSlug(name);

            return result;
        }
    }
}
