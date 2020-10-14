// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Threading.Tasks;
using Azure.Core.TestFramework;
using NUnit.Framework;
using Azure.ResourceManager.Dns.Models;
using Azure.ResourceManager.Dns.Tests;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Management.Dns.Tests
{
    [TestFixture]
    public class ScenarioTestsRecordSets : DnsManagementClientBase
    {
        private string location;
        private string resourceGroup;
        private ChangeTrackingList<AaaaRecord> dummyAaaaRecords;
        private ChangeTrackingList<ARecord> dummyARecords;
        private ChangeTrackingList<MxRecord> dummyMxRecords;
        private ChangeTrackingList<NsRecord> dummyNsRecords;
        private ChangeTrackingList<PtrRecord> dummyPtrRecords;
        private ChangeTrackingList<SrvRecord> dummySrvRecords;
        private ChangeTrackingList<TxtRecord> dummyTxtRecords;
        private ChangeTrackingList<CaaRecord> dummyCaaRecords;
        private Dictionary<string, string> metadata;


        public ScenarioTestsRecordSets()
            : base(true)
        {
            resourceGroup = null;
            location = "West US";
            dummyAaaaRecords = new ChangeTrackingList<AaaaRecord>();
            dummyARecords = new ChangeTrackingList<ARecord>();
            dummyMxRecords = new ChangeTrackingList<MxRecord>();
            dummyNsRecords = new ChangeTrackingList<NsRecord>();
            dummyPtrRecords = new ChangeTrackingList<PtrRecord>();
            dummySrvRecords = new ChangeTrackingList<SrvRecord>();
            dummyTxtRecords = new ChangeTrackingList<TxtRecord>();
            dummyCaaRecords = new ChangeTrackingList<CaaRecord>();
            metadata = new Dictionary<string, string>
            {
                {"tag1", "value1"}
            };
        }

        [TestCase]
        public async Task DnsRecordSetListByResourceGroupNoTop()
        {
            //Create RG for dummy test
            this.resourceGroup = Recording.GenerateAssetName("Default-Dns-");
            await Helper.TryRegisterResourceGroupAsync(this.ResourcesManagementClient.ResourceGroups, this.location, this.resourceGroup);
            var namespaceName = Recording.GenerateAssetName("sdk-RecordSet");
            var aZone = new Zone("Global");
            var zoneName = "azure.ameredmondlocalNotoptest.dns";
            await this.DnsManagementClient.Zones.CreateOrUpdateAsync(resourceGroup, zoneName, aZone);

            var AaaaRecords = new ChangeTrackingList<AaaaRecord>
            {
                new AaaaRecord {Ipv6Address = "1:1:1:1:1:ffff:783f:e6dc"},
                new AaaaRecord {Ipv6Address = "0:0:0:0:0:ffff:403:201"},
            };
            var recordName = "aaaa_record";
            var testARecordSet = new RecordSet("test_id1", recordName, "Aaaa", null, this.metadata, 3600, null, null, null, this.dummyARecords, AaaaRecords, this.dummyMxRecords,
                                               this.dummyNsRecords, this.dummyPtrRecords, this.dummySrvRecords, this.dummyTxtRecords, null, null, this.dummyCaaRecords);

            var createRecordSetResponse = await this.DnsManagementClient.RecordSets.CreateOrUpdateAsync(this.resourceGroup, zoneName, recordName, RecordType.Aaaa, testARecordSet);
            Assert.NotNull(createRecordSetResponse);
            recordName = "aaaa_record2";
            testARecordSet = new RecordSet("test_id2", recordName, "Aaaa", null, this.metadata, 3600, null, null, null, this.dummyARecords, AaaaRecords, this.dummyMxRecords,
                                    this.dummyNsRecords, this.dummyPtrRecords, this.dummySrvRecords, this.dummyTxtRecords, null, null, this.dummyCaaRecords);
            createRecordSetResponse = await this.DnsManagementClient.RecordSets.CreateOrUpdateAsync(this.resourceGroup, zoneName, recordName, RecordType.Aaaa, testARecordSet);
            var listResponse = this.DnsManagementClient.RecordSets.ListByDnsZoneAsync(this.resourceGroup, zoneName);
            var t = listResponse.AsPages();
            var pageResults = await t.ToEnumerableAsync();
            Assert.True(pageResults.Count == 1);
            var deleteRecordSetResponse = await this.DnsManagementClient.RecordSets.DeleteAsync(this.resourceGroup, zoneName, recordName, RecordType.A);
        }

    }
}
