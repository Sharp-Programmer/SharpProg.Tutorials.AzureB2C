
using System.Collections.Generic;

namespace SharpProg.Tutorials.AzureB2C.Core
{
    public class B2CConstants
    {
        public const string AzureAdConfigSection = "AzureAd";
        public const string ApiConfigSection = "ProductApi";
        public readonly static List<string> Scopes = new List<string> { "demo.read", "demo.write" };
        public const string Bearer = nameof(Bearer);
        public const string ProductClientName = "ProductClient";
    }
}
