// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Insights.Models
{
    public partial class DataContainer
    {
        internal static DataContainer DeserializeDataContainer(JsonElement element)
        {
            WorkspaceInfo workspace = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("workspace"))
                {
                    workspace = WorkspaceInfo.DeserializeWorkspaceInfo(property.Value);
                    continue;
                }
            }
            return new DataContainer(workspace);
        }
    }
}
