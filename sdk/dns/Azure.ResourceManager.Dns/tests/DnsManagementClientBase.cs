// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Threading.Tasks;
using System;
using Azure.Core.TestFramework;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.TestFramework;
using NUnit.Framework;


//Everything is this class should be code generated with the exception users wanting to write custom resources
namespace Azure.ResourceManager.Dns.Tests
{

    [RunFrequency(RunTestFrequency.Manually)]
    public abstract class DnsManagementClientBase : ManagementRecordedTestBase<DnsManagementTestEnvironment>
    {
        public ResourcesManagementClient ResourcesManagementClient { get; set; }
        public DnsManagementClient DnsManagementClient { get; set; }
        protected DnsManagementClientBase(bool isAsync) : base(isAsync)
        {

        }

        //These could be made into properties, but thought here is user wanted to add other clients they will use for each test
        //this would be an easy spot for them to put it (resource in this case)
        [SetUp]
        protected void InitializeClients()
        {
            ResourcesManagementClient = this.GetResourceManagementClient();
            DnsManagementClient = this.GetManagementClient<DnsManagementClient>(new DnsManagementClientOptions());
        }
    }
}
