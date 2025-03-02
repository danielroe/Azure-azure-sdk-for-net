// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HybridContainerService.Models
{
    public partial class HybridContainerServiceCredential : IUtf8JsonSerializable, IJsonModel<HybridContainerServiceCredential>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HybridContainerServiceCredential>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<HybridContainerServiceCredential>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HybridContainerServiceCredential>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HybridContainerServiceCredential)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W" && Optional.IsDefined(Value))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteBase64StringValue(Value, "D");
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

        HybridContainerServiceCredential IJsonModel<HybridContainerServiceCredential>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HybridContainerServiceCredential>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HybridContainerServiceCredential)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHybridContainerServiceCredential(document.RootElement, options);
        }

        internal static HybridContainerServiceCredential DeserializeHybridContainerServiceCredential(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            byte[] value = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    value = property.Value.GetBytesFromBase64("D");
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new HybridContainerServiceCredential(name, value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<HybridContainerServiceCredential>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HybridContainerServiceCredential>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(HybridContainerServiceCredential)} does not support writing '{options.Format}' format.");
            }
        }

        HybridContainerServiceCredential IPersistableModel<HybridContainerServiceCredential>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HybridContainerServiceCredential>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeHybridContainerServiceCredential(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(HybridContainerServiceCredential)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<HybridContainerServiceCredential>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
