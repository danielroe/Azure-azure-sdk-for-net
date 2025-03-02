// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class RecoveryWalkResponse : IUtf8JsonSerializable, IJsonModel<RecoveryWalkResponse>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RecoveryWalkResponse>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RecoveryWalkResponse>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecoveryWalkResponse>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RecoveryWalkResponse)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(WalkPerformed))
            {
                writer.WritePropertyName("walkPerformed"u8);
                writer.WriteBooleanValue(WalkPerformed.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(NextPlatformUpdateDomain))
            {
                writer.WritePropertyName("nextPlatformUpdateDomain"u8);
                writer.WriteNumberValue(NextPlatformUpdateDomain.Value);
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

        RecoveryWalkResponse IJsonModel<RecoveryWalkResponse>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecoveryWalkResponse>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RecoveryWalkResponse)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRecoveryWalkResponse(document.RootElement, options);
        }

        internal static RecoveryWalkResponse DeserializeRecoveryWalkResponse(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool? walkPerformed = default;
            int? nextPlatformUpdateDomain = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("walkPerformed"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    walkPerformed = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("nextPlatformUpdateDomain"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    nextPlatformUpdateDomain = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RecoveryWalkResponse(walkPerformed, nextPlatformUpdateDomain, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RecoveryWalkResponse>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecoveryWalkResponse>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RecoveryWalkResponse)} does not support writing '{options.Format}' format.");
            }
        }

        RecoveryWalkResponse IPersistableModel<RecoveryWalkResponse>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecoveryWalkResponse>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRecoveryWalkResponse(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RecoveryWalkResponse)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<RecoveryWalkResponse>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
