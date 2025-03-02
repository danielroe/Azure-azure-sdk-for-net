// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class ContainerCpuUsage : IUtf8JsonSerializable, IJsonModel<ContainerCpuUsage>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerCpuUsage>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ContainerCpuUsage>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerCpuUsage>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerCpuUsage)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(TotalUsage))
            {
                writer.WritePropertyName("totalUsage"u8);
                writer.WriteNumberValue(TotalUsage.Value);
            }
            if (Optional.IsCollectionDefined(PerCpuUsage))
            {
                writer.WritePropertyName("perCpuUsage"u8);
                writer.WriteStartArray();
                foreach (var item in PerCpuUsage)
                {
                    writer.WriteNumberValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(KernelModeUsage))
            {
                writer.WritePropertyName("kernelModeUsage"u8);
                writer.WriteNumberValue(KernelModeUsage.Value);
            }
            if (Optional.IsDefined(UserModeUsage))
            {
                writer.WritePropertyName("userModeUsage"u8);
                writer.WriteNumberValue(UserModeUsage.Value);
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

        ContainerCpuUsage IJsonModel<ContainerCpuUsage>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerCpuUsage>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerCpuUsage)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerCpuUsage(document.RootElement, options);
        }

        internal static ContainerCpuUsage DeserializeContainerCpuUsage(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            long? totalUsage = default;
            IList<long> perCpuUsage = default;
            long? kernelModeUsage = default;
            long? userModeUsage = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("totalUsage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    totalUsage = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("perCpuUsage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<long> array = new List<long>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetInt64());
                    }
                    perCpuUsage = array;
                    continue;
                }
                if (property.NameEquals("kernelModeUsage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    kernelModeUsage = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("userModeUsage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    userModeUsage = property.Value.GetInt64();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ContainerCpuUsage(totalUsage, perCpuUsage ?? new ChangeTrackingList<long>(), kernelModeUsage, userModeUsage, serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(TotalUsage), out propertyOverride);
            if (Optional.IsDefined(TotalUsage) || hasPropertyOverride)
            {
                builder.Append("  totalUsage: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    builder.AppendLine($"'{TotalUsage.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(PerCpuUsage), out propertyOverride);
            if (Optional.IsCollectionDefined(PerCpuUsage) || hasPropertyOverride)
            {
                if (PerCpuUsage.Any() || hasPropertyOverride)
                {
                    builder.Append("  perCpuUsage: ");
                    if (hasPropertyOverride)
                    {
                        builder.AppendLine($"{propertyOverride}");
                    }
                    else
                    {
                        builder.AppendLine("[");
                        foreach (var item in PerCpuUsage)
                        {
                            builder.AppendLine($"    '{item.ToString()}'");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(KernelModeUsage), out propertyOverride);
            if (Optional.IsDefined(KernelModeUsage) || hasPropertyOverride)
            {
                builder.Append("  kernelModeUsage: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    builder.AppendLine($"'{KernelModeUsage.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(UserModeUsage), out propertyOverride);
            if (Optional.IsDefined(UserModeUsage) || hasPropertyOverride)
            {
                builder.Append("  userModeUsage: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    builder.AppendLine($"'{UserModeUsage.Value.ToString()}'");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<ContainerCpuUsage>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerCpuUsage>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ContainerCpuUsage)} does not support writing '{options.Format}' format.");
            }
        }

        ContainerCpuUsage IPersistableModel<ContainerCpuUsage>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerCpuUsage>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContainerCpuUsage(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContainerCpuUsage)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerCpuUsage>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
