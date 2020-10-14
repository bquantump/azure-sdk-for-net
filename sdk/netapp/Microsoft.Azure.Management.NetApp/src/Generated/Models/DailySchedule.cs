// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.NetApp.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Daily Schedule properties
    /// </summary>
    public partial class DailySchedule
    {
        /// <summary>
        /// Initializes a new instance of the DailySchedule class.
        /// </summary>
        public DailySchedule()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DailySchedule class.
        /// </summary>
        /// <param name="snapshotsToKeep">Daily snapshot count to keep</param>
        /// <param name="hour">Indicates which hour in UTC timezone a snapshot
        /// should be taken</param>
        /// <param name="minute">Indicates which minute snapshot should be
        /// taken</param>
        /// <param name="usedBytes">Resource size in bytes, current storage
        /// usage for the volume in bytes</param>
        public DailySchedule(int? snapshotsToKeep = default(int?), int? hour = default(int?), int? minute = default(int?), long? usedBytes = default(long?))
        {
            SnapshotsToKeep = snapshotsToKeep;
            Hour = hour;
            Minute = minute;
            UsedBytes = usedBytes;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets daily snapshot count to keep
        /// </summary>
        [JsonProperty(PropertyName = "snapshotsToKeep")]
        public int? SnapshotsToKeep { get; set; }

        /// <summary>
        /// Gets or sets indicates which hour in UTC timezone a snapshot should
        /// be taken
        /// </summary>
        [JsonProperty(PropertyName = "hour")]
        public int? Hour { get; set; }

        /// <summary>
        /// Gets or sets indicates which minute snapshot should be taken
        /// </summary>
        [JsonProperty(PropertyName = "minute")]
        public int? Minute { get; set; }

        /// <summary>
        /// Gets or sets resource size in bytes, current storage usage for the
        /// volume in bytes
        /// </summary>
        [JsonProperty(PropertyName = "usedBytes")]
        public long? UsedBytes { get; set; }

    }
}
