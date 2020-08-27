// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using NUnit.Framework;
using Azure.Management.Resources;
using Azure.Management.Resources.Models;
using Azure.ResourceManager.Dns.Models;
using Azure.ResourceManager.Dns.Tests;
using System.Collections.Generic;
using System;
using Azure.Core;
using Azure.ResourceManager.TestFramework;

namespace Azure.Management.Dns.Tests
{
    [TestFixture]
    public class ScenarioTestsZones : DnsManagementClientBase
    {
        private string location;
        private string resourceGroup;
        private string defaultZoneName;
        private bool setupRun = false;

        public ScenarioTestsZones()
            : base(true)
        {
            resourceGroup = null;
            location = "West US";
            defaultZoneName = "azure.ameredmond.dns";
        }

        [SetUp]
        public async Task ClearChallengeCacheforRecord()
        {
            if ((Mode == RecordedTestMode.Record || Mode == RecordedTestMode.Playback) && !setupRun)
            {
                InitializeClients();
                this.resourceGroup = Recording.GenerateAssetName("Default-Dns-Zones-");
                await Helper.TryRegisterResourceGroupAsync(ResourceGroupsOperations, this.location, this.resourceGroup);

            }
            else if (setupRun)
            {
                initNewRecord();
            }
        }

        [OneTimeTearDown]
        public async Task CleanupResourceGroup()
        {
            await CleanupResourceGroupsAsync();
        }

        [TestCase]
        public async Task DnsCreateZoneDeleteAndUpdate()
        {
            var namespaceName = Recording.GenerateAssetName("sdk-RecordSet");
            var aZone = new Zone("Global");
            aZone.Tags.Add("key1", "value1");
            var response = await ZonesOperations.CreateOrUpdateAsync(resourceGroup, this.defaultZoneName, aZone);
            Assert.IsTrue(Helper.AreEqual(response, aZone, ignoreEtag: true));
            response = await ZonesOperations.GetAsync(resourceGroup, defaultZoneName);
            Assert.IsTrue(Helper.AreEqual(response, aZone, ignoreEtag: true));
            aZone = response.Value;
            aZone.Tags.Clear();
            aZone.Tags.Add("key1", "new_tag_1");
            aZone.Tags.Add("key2", "val2");
            response = await ZonesOperations.CreateOrUpdateAsync(resourceGroup, this.defaultZoneName, aZone);
            Assert.IsTrue(Helper.AreEqual(response, aZone, ignoreEtag: true));
            var delResponse = await ZonesOperations.StartDeleteAsync(resourceGroup, this.defaultZoneName);
            Assert.IsNotNull(delResponse);
        }

        [TestCase]
        public async Task DnsListZone()
        {
            string zoneNameOne = "dns.zoneonename.io";
            string zoneNameTwo = "dns.zonetwoname.io";
            var aZone = new Zone("Global");
            await ZonesOperations.CreateOrUpdateAsync(resourceGroup, zoneNameOne, aZone);
            aZone = new Zone("Global");
            await ZonesOperations.CreateOrUpdateAsync(resourceGroup, zoneNameTwo, aZone);

            var response = ZonesOperations.ListByResourceGroupAsync(resourceGroup, 1);
            var totalList = await response.ToEnumerableAsync();
            var zoneOneFound = false;
            var zoneTwoFound = false;
            foreach (var zone in totalList)
            {
                if (zone.Name == zoneNameOne)
                {
                    zoneOneFound = true;
                }
                else if (zone.Name == zoneNameTwo)
                {
                    zoneTwoFound = true;
                }
            }
            Assert.IsTrue(zoneOneFound && zoneTwoFound);
            await ZonesOperations.StartDeleteAsync(resourceGroup, zoneNameOne);
            await ZonesOperations.StartDeleteAsync(resourceGroup, zoneNameTwo);
        }

        [TestCase]
        public async Task DnsListZonesInSubscription()
        {
            string zoneNameOne = "dns.zoneonename.io";
            string zoneNameTwo = "dns.zonetwoname.io";
            var aZone = new Zone("Global");
            await ZonesOperations.CreateOrUpdateAsync(resourceGroup, zoneNameOne, aZone);

            aZone = new Zone("Global");
            await ZonesOperations.CreateOrUpdateAsync(resourceGroup, zoneNameTwo, aZone);
            await Helper.TryRegisterResourceGroupAsync(ResourceGroupsOperations, this.location, this.resourceGroup + "-Two");
            var response = ZonesOperations.ListAsync();
            var totalList = response.ToEnumerableAsync().Result;
            var zoneOneFound = false;
            var zoneTwoFound = false;
            foreach (var zone in totalList)
            {
                if (zone.Name == zoneNameOne)
                {
                    zoneOneFound = true;
                }
                else if (zone.Name == zoneNameTwo)
                {
                    zoneTwoFound = true;
                }
            }
            Assert.IsTrue(zoneOneFound && zoneTwoFound);
            await ResourceGroupsOperations.StartDeleteAsync(this.resourceGroup + "-Two");
            await ZonesOperations.StartDeleteAsync(resourceGroup, zoneNameOne);
        }

        [TestCase]
        public async Task DnsListZonesWithTopParameter()
        {
            string zoneNameOne = "dns.zoneonename.io";
            string zoneNameTwo = "dns.zonetwoname.io";
            var aZone = new Zone("Global");
            await ZonesOperations.CreateOrUpdateAsync(resourceGroup, zoneNameOne, aZone);
            aZone = new Zone("Global");
            await ZonesOperations.CreateOrUpdateAsync(resourceGroup, zoneNameTwo, aZone);
            var response = ZonesOperations.ListByResourceGroupAsync(resourceGroup, 1);
            var asPages = response.AsPages().ToEnumerableAsync().Result;
            Assert.AreEqual(asPages.Count, 3);
        }


        [TestCase]
        public async Task DnsUpdateZonePreconditionFailed()
        {
            var aZone = new Zone("Global");
            aZone.Tags.Add("key1", "value1");
            var response = await ZonesOperations.CreateOrUpdateAsync(resourceGroup, this.defaultZoneName, aZone);
            bool exceptionCaught = false;
            try
            {
                await ZonesOperations.CreateOrUpdateAsync(resourceGroup, this.defaultZoneName, response, "somegibberish", null);
            }
            catch (Azure.RequestFailedException)
            {
                exceptionCaught = true;
            }
            finally
            {
                Assert.True(exceptionCaught);
                await ZonesOperations.StartDeleteAsync(resourceGroup, this.defaultZoneName);
            }
        }

        [TestCase]
        public async Task GetNonExistingZoneFailsAsExpected()
        {
            bool exceptionCaught = false;
            try
            {
                await ZonesOperations.GetAsync(resourceGroup, "somegibberish");
            }
            catch (Azure.RequestFailedException)
            {
                exceptionCaught = true;
            }
            finally
            {
                Assert.True(exceptionCaught);
            }
        }
    }
}
