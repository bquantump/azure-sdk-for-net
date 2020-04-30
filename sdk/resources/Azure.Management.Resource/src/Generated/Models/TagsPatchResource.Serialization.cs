// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Resource.Models
{
    public partial class TagsPatchResource : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Operation != null)
            {
                writer.WritePropertyName("operation");
                writer.WriteStringValue(Operation.Value.ToString());
            }
            if (Properties != null)
            {
                writer.WritePropertyName("properties");
                writer.WriteObjectValue(Properties);
            }
            writer.WriteEndObject();
        }
    }
}
