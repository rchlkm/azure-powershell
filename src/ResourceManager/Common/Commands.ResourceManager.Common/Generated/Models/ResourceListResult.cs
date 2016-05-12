// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using Hyak.Common;
using System;
using System.Collections.Generic;

namespace Microsoft.Azure.Management.Internal.Resources.Models
{
    /// <summary>
    /// List of resource groups.
    /// </summary>
    public partial class ResourceListResult : AzureOperationResponse
    {
        private string _nextLink;

        /// <summary>
        /// Required. Gets or sets the URL to get the next set of results.
        /// </summary>
        public string NextLink
        {
            get { return this._nextLink; }
            set { this._nextLink = value; }
        }

        private IList<GenericResourceExtended> _resources;

        /// <summary>
        /// Optional. Gets or sets the list of resource groups.
        /// </summary>
        public IList<GenericResourceExtended> Resources
        {
            get { return this._resources; }
            set { this._resources = value; }
        }

        /// <summary>
        /// Initializes a new instance of the ResourceListResult class.
        /// </summary>
        public ResourceListResult()
        {
            this.Resources = new LazyList<GenericResourceExtended>();
        }

        /// <summary>
        /// Initializes a new instance of the ResourceListResult class with
        /// required arguments.
        /// </summary>
        public ResourceListResult(string nextLink)
            : this()
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException("nextLink");
            }
            this.NextLink = nextLink;
        }
    }
}
