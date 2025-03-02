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

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class CosmosDBAccountCorsPolicy : IUtf8JsonSerializable, IJsonModel<CosmosDBAccountCorsPolicy>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CosmosDBAccountCorsPolicy>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CosmosDBAccountCorsPolicy>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CosmosDBAccountCorsPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CosmosDBAccountCorsPolicy)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("allowedOrigins"u8);
            writer.WriteStringValue(AllowedOrigins);
            if (Optional.IsDefined(AllowedMethods))
            {
                writer.WritePropertyName("allowedMethods"u8);
                writer.WriteStringValue(AllowedMethods);
            }
            if (Optional.IsDefined(AllowedHeaders))
            {
                writer.WritePropertyName("allowedHeaders"u8);
                writer.WriteStringValue(AllowedHeaders);
            }
            if (Optional.IsDefined(ExposedHeaders))
            {
                writer.WritePropertyName("exposedHeaders"u8);
                writer.WriteStringValue(ExposedHeaders);
            }
            if (Optional.IsDefined(MaxAgeInSeconds))
            {
                writer.WritePropertyName("maxAgeInSeconds"u8);
                writer.WriteNumberValue(MaxAgeInSeconds.Value);
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

        CosmosDBAccountCorsPolicy IJsonModel<CosmosDBAccountCorsPolicy>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CosmosDBAccountCorsPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CosmosDBAccountCorsPolicy)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCosmosDBAccountCorsPolicy(document.RootElement, options);
        }

        internal static CosmosDBAccountCorsPolicy DeserializeCosmosDBAccountCorsPolicy(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string allowedOrigins = default;
            string allowedMethods = default;
            string allowedHeaders = default;
            string exposedHeaders = default;
            long? maxAgeInSeconds = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("allowedOrigins"u8))
                {
                    allowedOrigins = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("allowedMethods"u8))
                {
                    allowedMethods = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("allowedHeaders"u8))
                {
                    allowedHeaders = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("exposedHeaders"u8))
                {
                    exposedHeaders = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("maxAgeInSeconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxAgeInSeconds = property.Value.GetInt64();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CosmosDBAccountCorsPolicy(
                allowedOrigins,
                allowedMethods,
                allowedHeaders,
                exposedHeaders,
                maxAgeInSeconds,
                serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AllowedOrigins), out propertyOverride);
            if (Optional.IsDefined(AllowedOrigins) || hasPropertyOverride)
            {
                builder.Append("  allowedOrigins: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    if (AllowedOrigins.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{AllowedOrigins}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{AllowedOrigins}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AllowedMethods), out propertyOverride);
            if (Optional.IsDefined(AllowedMethods) || hasPropertyOverride)
            {
                builder.Append("  allowedMethods: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    if (AllowedMethods.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{AllowedMethods}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{AllowedMethods}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AllowedHeaders), out propertyOverride);
            if (Optional.IsDefined(AllowedHeaders) || hasPropertyOverride)
            {
                builder.Append("  allowedHeaders: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    if (AllowedHeaders.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{AllowedHeaders}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{AllowedHeaders}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ExposedHeaders), out propertyOverride);
            if (Optional.IsDefined(ExposedHeaders) || hasPropertyOverride)
            {
                builder.Append("  exposedHeaders: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    if (ExposedHeaders.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ExposedHeaders}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ExposedHeaders}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(MaxAgeInSeconds), out propertyOverride);
            if (Optional.IsDefined(MaxAgeInSeconds) || hasPropertyOverride)
            {
                builder.Append("  maxAgeInSeconds: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    builder.AppendLine($"'{MaxAgeInSeconds.Value.ToString()}'");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<CosmosDBAccountCorsPolicy>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CosmosDBAccountCorsPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(CosmosDBAccountCorsPolicy)} does not support writing '{options.Format}' format.");
            }
        }

        CosmosDBAccountCorsPolicy IPersistableModel<CosmosDBAccountCorsPolicy>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CosmosDBAccountCorsPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCosmosDBAccountCorsPolicy(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CosmosDBAccountCorsPolicy)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<CosmosDBAccountCorsPolicy>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
