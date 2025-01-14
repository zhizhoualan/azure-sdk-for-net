// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.TextAnalytics
{
    internal partial class HealthcareEntityInternal
    {
        internal static HealthcareEntityInternal DeserializeHealthcareEntityInternal(JsonElement element)
        {
            Optional<HealthcareEntityAssertion> assertion = default;
            Optional<string> name = default;
            Optional<IReadOnlyList<EntityDataSource>> links = default;
            string text = default;
            string category = default;
            Optional<string> subcategory = default;
            int offset = default;
            int length = default;
            double confidenceScore = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("assertion"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    assertion = HealthcareEntityAssertion.DeserializeHealthcareEntityAssertion(property.Value);
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("links"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<EntityDataSource> array = new List<EntityDataSource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(EntityDataSource.DeserializeEntityDataSource(item));
                    }
                    links = array;
                    continue;
                }
                if (property.NameEquals("text"))
                {
                    text = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("category"))
                {
                    category = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("subcategory"))
                {
                    subcategory = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("offset"))
                {
                    offset = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("length"))
                {
                    length = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("confidenceScore"))
                {
                    confidenceScore = property.Value.GetDouble();
                    continue;
                }
            }
            return new HealthcareEntityInternal(text, category, subcategory.Value, offset, length, confidenceScore, assertion.Value, name.Value, Optional.ToList(links));
        }
    }
}
