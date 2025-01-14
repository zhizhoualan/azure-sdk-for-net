// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Models
{
    public partial class MetricAnomalyFeedback : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(StartTime))
            {
                writer.WritePropertyName("startTime");
                writer.WriteStringValue(StartTime, "O");
            }
            if (Optional.IsDefined(EndTime))
            {
                writer.WritePropertyName("endTime");
                writer.WriteStringValue(EndTime, "O");
            }
            if (Optional.IsDefined(ValueInternal))
            {
                writer.WritePropertyName("value");
                writer.WriteObjectValue(ValueInternal);
            }
            if (Optional.IsDefined(AnomalyDetectionConfigurationId))
            {
                if (AnomalyDetectionConfigurationId != null)
                {
                    writer.WritePropertyName("anomalyDetectionConfigurationId");
                    writer.WriteStringValue(AnomalyDetectionConfigurationId);
                }
                else
                {
                    writer.WriteNull("anomalyDetectionConfigurationId");
                }
            }
            if (Optional.IsDefined(AnomalyDetectionConfigurationSnapshot))
            {
                if (AnomalyDetectionConfigurationSnapshot != null)
                {
                    writer.WritePropertyName("anomalyDetectionConfigurationSnapshot");
                    writer.WriteObjectValue(AnomalyDetectionConfigurationSnapshot);
                }
                else
                {
                    writer.WriteNull("anomalyDetectionConfigurationSnapshot");
                }
            }
            writer.WritePropertyName("feedbackType");
            writer.WriteStringValue(Type.ToString());
            writer.WritePropertyName("metricId");
            writer.WriteStringValue(MetricId);
            writer.WritePropertyName("dimensionFilter");
            writer.WriteObjectValue(DimensionFilter);
            writer.WriteEndObject();
        }

        internal static MetricAnomalyFeedback DeserializeMetricAnomalyFeedback(JsonElement element)
        {
            Optional<DateTimeOffset> startTime = default;
            Optional<DateTimeOffset> endTime = default;
            Optional<AnomalyFeedbackValue> value = default;
            Optional<string> anomalyDetectionConfigurationId = default;
            Optional<AnomalyDetectionConfiguration> anomalyDetectionConfigurationSnapshot = default;
            FeedbackType feedbackType = default;
            Optional<string> feedbackId = default;
            Optional<DateTimeOffset> createdTime = default;
            Optional<string> userPrincipal = default;
            string metricId = default;
            FeedbackDimensionFilter dimensionFilter = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("startTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    startTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    endTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    value = AnomalyFeedbackValue.DeserializeAnomalyFeedbackValue(property.Value);
                    continue;
                }
                if (property.NameEquals("anomalyDetectionConfigurationId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        anomalyDetectionConfigurationId = null;
                        continue;
                    }
                    anomalyDetectionConfigurationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("anomalyDetectionConfigurationSnapshot"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        anomalyDetectionConfigurationSnapshot = null;
                        continue;
                    }
                    anomalyDetectionConfigurationSnapshot = AnomalyDetectionConfiguration.DeserializeAnomalyDetectionConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("feedbackType"))
                {
                    feedbackType = new FeedbackType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("feedbackId"))
                {
                    feedbackId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("createdTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    createdTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("userPrincipal"))
                {
                    userPrincipal = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("metricId"))
                {
                    metricId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dimensionFilter"))
                {
                    dimensionFilter = FeedbackDimensionFilter.DeserializeFeedbackDimensionFilter(property.Value);
                    continue;
                }
            }
            return new MetricAnomalyFeedback(feedbackType, feedbackId.Value, Optional.ToNullable(createdTime), userPrincipal.Value, metricId, dimensionFilter, startTime, endTime, value.Value, anomalyDetectionConfigurationId.Value, anomalyDetectionConfigurationSnapshot.Value);
        }
    }
}
