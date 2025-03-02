// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Documents.Models
{
    internal partial class UnknownVectorQuery : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
            if (Optional.IsDefined(KNearestNeighborsCount))
            {
                writer.WritePropertyName("k"u8);
                writer.WriteNumberValue(KNearestNeighborsCount.Value);
            }
            if (Optional.IsDefined(FieldsRaw))
            {
                writer.WritePropertyName("fields"u8);
                writer.WriteStringValue(FieldsRaw);
            }
            if (Optional.IsDefined(Exhaustive))
            {
                writer.WritePropertyName("exhaustive"u8);
                writer.WriteBooleanValue(Exhaustive.Value);
            }
            if (Optional.IsDefined(Oversampling))
            {
                writer.WritePropertyName("oversampling"u8);
                writer.WriteNumberValue(Oversampling.Value);
            }
            writer.WriteEndObject();
        }

        internal static UnknownVectorQuery DeserializeUnknownVectorQuery(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            VectorQueryKind kind = "Unknown";
            int? k = default;
            string fields = default;
            bool? exhaustive = default;
            double? oversampling = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = new VectorQueryKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("k"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    k = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("fields"u8))
                {
                    fields = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("exhaustive"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    exhaustive = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("oversampling"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    oversampling = property.Value.GetDouble();
                    continue;
                }
            }
            return new UnknownVectorQuery(kind, k, fields, exhaustive, oversampling);
        }
    }
}
