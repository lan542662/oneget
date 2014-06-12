// 
//  Copyright (c) Microsoft Corporation. All rights reserved. 
//  Licensed under the Apache License, Version 2.0 (the "License");
//  you may not use this file except in compliance with the License.
//  You may obtain a copy of the License at
//  http://www.apache.org/licenses/LICENSE-2.0
//  
//  Unless required by applicable law or agreed to in writing, software
//  distributed under the License is distributed on an "AS IS" BASIS,
//  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//  See the License for the specific language governing permissions and
//  limitations under the License.
//  

namespace Microsoft.PowerShell.OneGet.CmdLets {
    using System.Management.Automation;
    using Microsoft.OneGet.Core.Providers.Package;

    public abstract class CmdletWithSearch : CmdletWithProvider {
        protected CmdletWithSearch(OptionCategory[] categories)
            : base(categories) {
        }

        [Parameter(Position = 0, ValueFromPipeline = true, ParameterSetName = ProviderByNameSet)]
        [Parameter(Position = 0, ValueFromPipeline = true, ParameterSetName = ProviderByObjectSet)]
        public string[] Name { get; set; }

        [Parameter(ParameterSetName = ProviderByNameSet)]
        [Parameter(ParameterSetName = ProviderByObjectSet)]
        public string RequiredVersion { get; set; }

        [Parameter(ParameterSetName = ProviderByNameSet)]
        [Parameter(ParameterSetName = ProviderByObjectSet)]
        public string MinimumVersion {get; set;}

        [Parameter(ParameterSetName = ProviderByNameSet)]
        [Parameter(ParameterSetName = ProviderByObjectSet)]
        public string MaximumVersion { get; set; }
    }
}