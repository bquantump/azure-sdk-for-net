// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Resource.Models
{
    public partial class DeploymentOperation
    {
        internal static DeploymentOperation DeserializeDeploymentOperation(JsonElement element)
        {
            string id = default;
            string operationId = default;
            DeploymentOperationProperties properties = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("operationId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    operationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    properties = DeploymentOperationProperties.DeserializeDeploymentOperationProperties(property.Value);
                    continue;
                }
            }
            return new DeploymentOperation(id, operationId, properties);
        }
    }
}
