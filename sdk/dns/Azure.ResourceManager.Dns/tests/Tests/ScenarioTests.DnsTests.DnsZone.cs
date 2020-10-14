// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using NUnit.Framework;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Dns.Models;
using Azure.ResourceManager.Dns.Tests;

namespace Azure.Management.Dns.Tests
{
    [TestFixture]
    public class ScenarioTestsZones : DnsManagementClientBase
    {
        private string location;
        private string resourceGroup;
        private string defaultZoneName;

        public ScenarioTestsZones()
            : base(true)
        {
            resourceGroup = null;
            location = "West US";
            defaultZoneName = "azure.ameredmond.dns";
        }

        [TestCase]
        public async Task DnsCreateZoneDeleteAndUpdate()
        {
            this.resourceGroup = Recording.GenerateAssetName("Default-Dns-");
            await Helper.TryRegisterResourceGroupAsync(this.ResourcesManagementClient.ResourceGroups, this.location, this.resourceGroup);
            var namespaceName = Recording.GenerateAssetName("sdk-RecordSet");
            var aZone = new Zone("Global");
            aZone.Tags.Add("key1", "value1");
            var response = await this.DnsManagementClient.Zones.CreateOrUpdateAsync(resourceGroup, this.defaultZoneName, aZone);
            Assert.IsTrue(Helper.AreEqual(response, aZone, ignoreEtag: true));
            response = await this.DnsManagementClient.Zones.GetAsync(resourceGroup, defaultZoneName);
            Assert.IsTrue(Helper.AreEqual(response, aZone, ignoreEtag: true));
            aZone = response.Value;
            aZone.Tags.Clear();
            aZone.Tags.Add("key1", "new_tag_1");
            aZone.Tags.Add("key2", "val2");
            response = await this.DnsManagementClient.Zones.CreateOrUpdateAsync(resourceGroup, this.defaultZoneName, aZone);
            Assert.IsTrue(Helper.AreEqual(response, aZone, ignoreEtag: true));
            var delResponse = await this.WaitForCompletionAsync(await this.DnsManagementClient.Zones.StartDeleteAsync(resourceGroup, this.defaultZoneName));
            Assert.AreEqual(delResponse.Value.Status, 200);
        }
    }
}
