// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ManagementGroups.Models
{
    public partial class ManagementGroupNameAvailabilityResult : IUtf8JsonSerializable, IJsonModel<ManagementGroupNameAvailabilityResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ManagementGroupNameAvailabilityResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ManagementGroupNameAvailabilityResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagementGroupNameAvailabilityResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagementGroupNameAvailabilityResult)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(NameAvailable))
            {
                writer.WritePropertyName("nameAvailable"u8);
                writer.WriteBooleanValue(NameAvailable.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(Reason))
            {
                writer.WritePropertyName("reason"u8);
                writer.WriteStringValue(Reason.Value.ToSerialString());
            }
            if (options.Format != "W" && Optional.IsDefined(Message))
            {
                writer.WritePropertyName("message"u8);
                writer.WriteStringValue(Message);
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

        ManagementGroupNameAvailabilityResult IJsonModel<ManagementGroupNameAvailabilityResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagementGroupNameAvailabilityResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagementGroupNameAvailabilityResult)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeManagementGroupNameAvailabilityResult(document.RootElement, options);
        }

        internal static ManagementGroupNameAvailabilityResult DeserializeManagementGroupNameAvailabilityResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool? nameAvailable = default;
            ManagementGroupNameUnavailableReason? reason = default;
            string message = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nameAvailable"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    nameAvailable = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("reason"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    reason = property.Value.GetString().ToManagementGroupNameUnavailableReason();
                    continue;
                }
                if (property.NameEquals("message"u8))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ManagementGroupNameAvailabilityResult(nameAvailable, reason, message, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(NameAvailable), out propertyOverride);
            if (Optional.IsDefined(NameAvailable) || hasPropertyOverride)
            {
                builder.Append("  nameAvailable: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    var boolValue = NameAvailable.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Reason), out propertyOverride);
            if (Optional.IsDefined(Reason) || hasPropertyOverride)
            {
                builder.Append("  reason: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    builder.AppendLine($"'{Reason.Value.ToSerialString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Message), out propertyOverride);
            if (Optional.IsDefined(Message) || hasPropertyOverride)
            {
                builder.Append("  message: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    if (Message.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Message}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Message}'");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<ManagementGroupNameAvailabilityResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagementGroupNameAvailabilityResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ManagementGroupNameAvailabilityResult)} does not support writing '{options.Format}' format.");
            }
        }

        ManagementGroupNameAvailabilityResult IPersistableModel<ManagementGroupNameAvailabilityResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagementGroupNameAvailabilityResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeManagementGroupNameAvailabilityResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ManagementGroupNameAvailabilityResult)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ManagementGroupNameAvailabilityResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
