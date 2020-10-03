// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Insights.Models
{
    internal static class RecurrenceFrequencyExtensions
    {
        public static string ToSerialString(this RecurrenceFrequency value) => value switch
        {
            RecurrenceFrequency.None => "None",
            RecurrenceFrequency.Second => "Second",
            RecurrenceFrequency.Minute => "Minute",
            RecurrenceFrequency.Hour => "Hour",
            RecurrenceFrequency.Day => "Day",
            RecurrenceFrequency.Week => "Week",
            RecurrenceFrequency.Month => "Month",
            RecurrenceFrequency.Year => "Year",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown RecurrenceFrequency value.")
        };

        public static RecurrenceFrequency ToRecurrenceFrequency(this string value)
        {
            if (string.Equals(value, "None", StringComparison.InvariantCultureIgnoreCase)) return RecurrenceFrequency.None;
            if (string.Equals(value, "Second", StringComparison.InvariantCultureIgnoreCase)) return RecurrenceFrequency.Second;
            if (string.Equals(value, "Minute", StringComparison.InvariantCultureIgnoreCase)) return RecurrenceFrequency.Minute;
            if (string.Equals(value, "Hour", StringComparison.InvariantCultureIgnoreCase)) return RecurrenceFrequency.Hour;
            if (string.Equals(value, "Day", StringComparison.InvariantCultureIgnoreCase)) return RecurrenceFrequency.Day;
            if (string.Equals(value, "Week", StringComparison.InvariantCultureIgnoreCase)) return RecurrenceFrequency.Week;
            if (string.Equals(value, "Month", StringComparison.InvariantCultureIgnoreCase)) return RecurrenceFrequency.Month;
            if (string.Equals(value, "Year", StringComparison.InvariantCultureIgnoreCase)) return RecurrenceFrequency.Year;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown RecurrenceFrequency value.");
        }
    }
}
