// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Resource.Models
{
    public partial class DeploymentOperationProperties
    {
        internal static DeploymentOperationProperties DeserializeDeploymentOperationProperties(JsonElement element)
        {
            ProvisioningOperation? provisioningOperation = default;
            string provisioningState = default;
            DateTimeOffset? timestamp = default;
            string duration = default;
            string serviceRequestId = default;
            string statusCode = default;
            object statusMessage = default;
            TargetResource targetResource = default;
            HttpMessage request = default;
            HttpMessage response = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provisioningOperation"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningOperation = property.Value.GetString().ToProvisioningOperation();
                    continue;
                }
                if (property.NameEquals("provisioningState"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("timestamp"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timestamp = property.Value.GetDateTimeOffset("S");
                    continue;
                }
                if (property.NameEquals("duration"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    duration = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serviceRequestId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    serviceRequestId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("statusCode"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    statusCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("statusMessage"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    statusMessage = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("targetResource"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetResource = TargetResource.DeserializeTargetResource(property.Value);
                    continue;
                }
                if (property.NameEquals("request"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    request = HttpMessage.DeserializeHttpMessage(property.Value);
                    continue;
                }
                if (property.NameEquals("response"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    response = HttpMessage.DeserializeHttpMessage(property.Value);
                    continue;
                }
            }
            return new DeploymentOperationProperties(provisioningOperation, provisioningState, timestamp, duration, serviceRequestId, statusCode, statusMessage, targetResource, request, response);
        }
    }
}
