using System;
using Xunit;

namespace Microsoft.Web.Redis.Tests
{

    public class KeyGeneratorUtilityTests
    {
        [Fact]
        public void Return_Blank_ifNull()
        {
            string testkey = null;
            string expkey = "";

            Assert.True(KeyGeneratorUtility.AdjustNamespace(testkey) == expkey);

        }

        [Fact]
        public void Return_Blank_ifWhitespace()
        {
            string testkey = "  ";
            string expkey = "";

            Assert.True(KeyGeneratorUtility.AdjustNamespace(testkey) == expkey);

        }

        public void Test_Trimmed()
        {
            string testkey = "ns  ";
            string expkey = "ns:";

            Assert.True(KeyGeneratorUtility.AdjustNamespace(testkey) == expkey);

            testkey = "  ns";
            expkey = "ns:";

            Assert.True(KeyGeneratorUtility.AdjustNamespace(testkey) == expkey);

            testkey = "  ns  ";
            expkey = "ns:";

            Assert.True(KeyGeneratorUtility.AdjustNamespace(testkey) == expkey);
        }

        [Fact]
        public void Do_not_Double_Semicolons()
        {
            string testkey = "ns:";
            string expkey = "ns:";

            Assert.True(KeyGeneratorUtility.AdjustNamespace(testkey) == expkey);
        }

        [Fact]
        public void Append_Namespace_Semicolon()
        {
            string testkey = "ns";
            string expkey = "ns:";

            Assert.True(KeyGeneratorUtility.AdjustNamespace(testkey) == expkey);

        }
    }
}
