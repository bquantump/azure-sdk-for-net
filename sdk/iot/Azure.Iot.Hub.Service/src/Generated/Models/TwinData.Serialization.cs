// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Iot.Hub.Service.Models
{
    public partial class TwinData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(DeviceId))
            {
                writer.WritePropertyName("deviceId");
                writer.WriteStringValue(DeviceId);
            }
            if (Optional.IsDefined(ModuleId))
            {
                writer.WritePropertyName("moduleId");
                writer.WriteStringValue(ModuleId);
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags");
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(Properties))
            {
                writer.WritePropertyName("properties");
                writer.WriteObjectValue(Properties);
            }
            if (Optional.IsDefined(Etag))
            {
                writer.WritePropertyName("etag");
                writer.WriteStringValue(Etag);
            }
            if (Optional.IsDefined(Version))
            {
                writer.WritePropertyName("version");
                writer.WriteNumberValue(Version.Value);
            }
            if (Optional.IsDefined(DeviceEtag))
            {
                writer.WritePropertyName("deviceEtag");
                writer.WriteStringValue(DeviceEtag);
            }
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status");
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (Optional.IsDefined(StatusReason))
            {
                writer.WritePropertyName("statusReason");
                writer.WriteStringValue(StatusReason);
            }
            if (Optional.IsDefined(StatusUpdateTime))
            {
                writer.WritePropertyName("statusUpdateTime");
                writer.WriteStringValue(StatusUpdateTime.Value, "O");
            }
            if (Optional.IsDefined(ConnectionState))
            {
                writer.WritePropertyName("connectionState");
                writer.WriteStringValue(ConnectionState.Value.ToString());
            }
            if (Optional.IsDefined(LastActivityTime))
            {
                writer.WritePropertyName("lastActivityTime");
                writer.WriteStringValue(LastActivityTime.Value, "O");
            }
            if (Optional.IsDefined(CloudToDeviceMessageCount))
            {
                writer.WritePropertyName("cloudToDeviceMessageCount");
                writer.WriteNumberValue(CloudToDeviceMessageCount.Value);
            }
            if (Optional.IsDefined(AuthenticationType))
            {
                writer.WritePropertyName("authenticationType");
                writer.WriteStringValue(AuthenticationType.Value.ToString());
            }
            if (Optional.IsDefined(X509Thumbprint))
            {
                writer.WritePropertyName("x509Thumbprint");
                writer.WriteObjectValue(X509Thumbprint);
            }
            if (Optional.IsDefined(Capabilities))
            {
                writer.WritePropertyName("capabilities");
                writer.WriteObjectValue(Capabilities);
            }
            if (Optional.IsDefined(DeviceScope))
            {
                writer.WritePropertyName("deviceScope");
                writer.WriteStringValue(DeviceScope);
            }
            writer.WriteEndObject();
        }

        internal static TwinData DeserializeTwinData(JsonElement element)
        {
            Optional<string> deviceId = default;
            Optional<string> moduleId = default;
            Optional<IDictionary<string, object>> tags = default;
            Optional<TwinProperties> properties = default;
            Optional<string> etag = default;
            Optional<long> version = default;
            Optional<string> deviceEtag = default;
            Optional<TwinStatus> status = default;
            Optional<string> statusReason = default;
            Optional<DateTimeOffset> statusUpdateTime = default;
            Optional<TwinConnectionState> connectionState = default;
            Optional<DateTimeOffset> lastActivityTime = default;
            Optional<int> cloudToDeviceMessageCount = default;
            Optional<TwinAuthenticationType> authenticationType = default;
            Optional<X509Thumbprint> x509Thumbprint = default;
            Optional<DeviceCapabilities> capabilities = default;
            Optional<string> deviceScope = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("deviceId"))
                {
                    deviceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("moduleId"))
                {
                    moduleId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tags"))
                {
                    Dictionary<string, object> dictionary = new Dictionary<string, object>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetObject());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    properties = TwinProperties.DeserializeTwinProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("etag"))
                {
                    etag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("version"))
                {
                    version = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("deviceEtag"))
                {
                    deviceEtag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"))
                {
                    status = new TwinStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("statusReason"))
                {
                    statusReason = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("statusUpdateTime"))
                {
                    statusUpdateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("connectionState"))
                {
                    connectionState = new TwinConnectionState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("lastActivityTime"))
                {
                    lastActivityTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("cloudToDeviceMessageCount"))
                {
                    cloudToDeviceMessageCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("authenticationType"))
                {
                    authenticationType = new TwinAuthenticationType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("x509Thumbprint"))
                {
                    x509Thumbprint = X509Thumbprint.DeserializeX509Thumbprint(property.Value);
                    continue;
                }
                if (property.NameEquals("capabilities"))
                {
                    capabilities = DeviceCapabilities.DeserializeDeviceCapabilities(property.Value);
                    continue;
                }
                if (property.NameEquals("deviceScope"))
                {
                    deviceScope = property.Value.GetString();
                    continue;
                }
            }
            return new TwinData(deviceId.Value, moduleId.Value, Optional.ToDictionary(tags), properties.Value, etag.Value, Optional.ToNullable(version), deviceEtag.Value, Optional.ToNullable(status), statusReason.Value, Optional.ToNullable(statusUpdateTime), Optional.ToNullable(connectionState), Optional.ToNullable(lastActivityTime), Optional.ToNullable(cloudToDeviceMessageCount), Optional.ToNullable(authenticationType), x509Thumbprint.Value, capabilities.Value, deviceScope.Value);
        }
    }
}
