// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Dns.Models
{
    /// <summary> Describes a DNS zone. </summary>
    public partial class Zone : Resource
    {
        /// <summary> Initializes a new instance of Zone. </summary>
        /// <param name="location"> Resource location. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> is null. </exception>
        public Zone(string location) : base(location)
        {
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }

            NameServers = new ChangeTrackingList<string>();
            RegistrationVirtualNetworks = new ChangeTrackingList<SubResource>();
            ResolutionVirtualNetworks = new ChangeTrackingList<SubResource>();
        }

        /// <summary> Initializes a new instance of Zone. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="etag"> The etag of the zone. </param>
        /// <param name="maxNumberOfRecordSets"> The maximum number of record sets that can be created in this DNS zone.  This is a read-only property and any attempt to set this value will be ignored. </param>
        /// <param name="numberOfRecordSets"> The current number of record sets in this DNS zone.  This is a read-only property and any attempt to set this value will be ignored. </param>
        /// <param name="nameServers"> The name servers for this DNS zone. This is a read-only property and any attempt to set this value will be ignored. </param>
        /// <param name="zoneType"> The type of this DNS zone (Public or Private). </param>
        /// <param name="registrationVirtualNetworks"> A list of references to virtual networks that register hostnames in this DNS zone. This is a only when ZoneType is Private. </param>
        /// <param name="resolutionVirtualNetworks"> A list of references to virtual networks that resolve records in this DNS zone. This is a only when ZoneType is Private. </param>
        internal Zone(string id, string name, string type, string location, IDictionary<string, string> tags, string etag, long? maxNumberOfRecordSets, long? numberOfRecordSets, IReadOnlyList<string> nameServers, ZoneType? zoneType, IList<SubResource> registrationVirtualNetworks, IList<SubResource> resolutionVirtualNetworks) : base(id, name, type, location, tags)
        {
            Etag = etag;
            MaxNumberOfRecordSets = maxNumberOfRecordSets;
            NumberOfRecordSets = numberOfRecordSets;
            NameServers = nameServers;
            ZoneType = zoneType;
            RegistrationVirtualNetworks = registrationVirtualNetworks;
            ResolutionVirtualNetworks = resolutionVirtualNetworks;
        }

        /// <summary> The etag of the zone. </summary>
        public string Etag { get; set; }
        /// <summary> The maximum number of record sets that can be created in this DNS zone.  This is a read-only property and any attempt to set this value will be ignored. </summary>
        public long? MaxNumberOfRecordSets { get; }
        /// <summary> The current number of record sets in this DNS zone.  This is a read-only property and any attempt to set this value will be ignored. </summary>
        public long? NumberOfRecordSets { get; }
        /// <summary> The name servers for this DNS zone. This is a read-only property and any attempt to set this value will be ignored. </summary>
        public IReadOnlyList<string> NameServers { get; }
        /// <summary> The type of this DNS zone (Public or Private). </summary>
        public ZoneType? ZoneType { get; }
        /// <summary> A list of references to virtual networks that register hostnames in this DNS zone. This is a only when ZoneType is Private. </summary>
        public IList<SubResource> RegistrationVirtualNetworks { get; }
        /// <summary> A list of references to virtual networks that resolve records in this DNS zone. This is a only when ZoneType is Private. </summary>
        public IList<SubResource> ResolutionVirtualNetworks { get; }
    }
}
