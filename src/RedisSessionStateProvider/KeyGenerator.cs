//
// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
//

using System;

namespace Microsoft.Web.Redis
{
    internal class KeyGenerator
    {
        private string id;
        public string DataKey { get; private set; }
        public string LockKey { get; private set; }
        public string InternalKey { get; private set; }

        public KeyGenerator(string id, string applicationName, string sessionNamespace)
        {
            string adjustedNamespace = KeyGeneratorUtility.AdjustNamespace(sessionNamespace);

            this.id = id;
        }

        public void RegenerateKeyStringIfIdModified(string id, string applicationName, string sessionNamespace)
        {
            if (!id.Equals(this.id))
            {
                string adjustedNamespace = KeyGeneratorUtility.AdjustNamespace(sessionNamespace);

                this.id = id;
            }
        }



    }
}
