// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StorageSync.Models
{
    public partial class CloudTieringVolumeFreeSpacePolicyStatus : IUtf8JsonSerializable, IJsonModel<CloudTieringVolumeFreeSpacePolicyStatus>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CloudTieringVolumeFreeSpacePolicyStatus>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CloudTieringVolumeFreeSpacePolicyStatus>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CloudTieringVolumeFreeSpacePolicyStatus>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CloudTieringVolumeFreeSpacePolicyStatus)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(LastUpdatedOn))
            {
                writer.WritePropertyName("lastUpdatedTimestamp"u8);
                writer.WriteStringValue(LastUpdatedOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(EffectiveVolumeFreeSpacePolicy))
            {
                writer.WritePropertyName("effectiveVolumeFreeSpacePolicy"u8);
                writer.WriteNumberValue(EffectiveVolumeFreeSpacePolicy.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(CurrentVolumeFreeSpacePercent))
            {
                writer.WritePropertyName("currentVolumeFreeSpacePercent"u8);
                writer.WriteNumberValue(CurrentVolumeFreeSpacePercent.Value);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        CloudTieringVolumeFreeSpacePolicyStatus IJsonModel<CloudTieringVolumeFreeSpacePolicyStatus>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CloudTieringVolumeFreeSpacePolicyStatus>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CloudTieringVolumeFreeSpacePolicyStatus)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCloudTieringVolumeFreeSpacePolicyStatus(document.RootElement, options);
        }

        internal static CloudTieringVolumeFreeSpacePolicyStatus DeserializeCloudTieringVolumeFreeSpacePolicyStatus(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DateTimeOffset? lastUpdatedTimestamp = default;
            int? effectiveVolumeFreeSpacePolicy = default;
            int? currentVolumeFreeSpacePercent = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("lastUpdatedTimestamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastUpdatedTimestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("effectiveVolumeFreeSpacePolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    effectiveVolumeFreeSpacePolicy = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("currentVolumeFreeSpacePercent"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    currentVolumeFreeSpacePercent = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CloudTieringVolumeFreeSpacePolicyStatus(lastUpdatedTimestamp, effectiveVolumeFreeSpacePolicy, currentVolumeFreeSpacePercent, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CloudTieringVolumeFreeSpacePolicyStatus>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CloudTieringVolumeFreeSpacePolicyStatus>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CloudTieringVolumeFreeSpacePolicyStatus)} does not support writing '{options.Format}' format.");
            }
        }

        CloudTieringVolumeFreeSpacePolicyStatus IPersistableModel<CloudTieringVolumeFreeSpacePolicyStatus>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CloudTieringVolumeFreeSpacePolicyStatus>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCloudTieringVolumeFreeSpacePolicyStatus(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CloudTieringVolumeFreeSpacePolicyStatus)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<CloudTieringVolumeFreeSpacePolicyStatus>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
