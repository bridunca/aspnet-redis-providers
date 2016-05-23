using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Microsoft.Web.Redis
{
    class KeyGeneratorUtility
    {
        public static string AdjustNamespace(string sessionNamespace)
        {
            if (string.IsNullOrWhiteSpace(sessionNamespace))
                return string.Empty;


            string finalNs = sessionNamespace.Trim();

            if (finalNs.EndsWith(":"))
                return finalNs;

            return finalNs + ":";
        }
    }
}
