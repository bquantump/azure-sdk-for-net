// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Insights.Models
{
    public partial class LocalizableString
    {
        internal static LocalizableString DeserializeLocalizableString(JsonElement element)
        {
            string value = default;
            Optional<string> localizedValue = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    value = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("localizedValue"))
                {
                    localizedValue = property.Value.GetString();
                    continue;
                }
            }
            return new LocalizableString(value, localizedValue.Value);
        }
    }
}
