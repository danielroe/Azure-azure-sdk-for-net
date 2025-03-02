// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    public partial class ClusterLogAnalyticsApplicationLogs : IUtf8JsonSerializable, IJsonModel<ClusterLogAnalyticsApplicationLogs>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ClusterLogAnalyticsApplicationLogs>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ClusterLogAnalyticsApplicationLogs>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterLogAnalyticsApplicationLogs>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ClusterLogAnalyticsApplicationLogs)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(IsStdOutEnabled))
            {
                writer.WritePropertyName("stdOutEnabled"u8);
                writer.WriteBooleanValue(IsStdOutEnabled.Value);
            }
            if (Optional.IsDefined(IsStdErrorEnabled))
            {
                writer.WritePropertyName("stdErrorEnabled"u8);
                writer.WriteBooleanValue(IsStdErrorEnabled.Value);
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

        ClusterLogAnalyticsApplicationLogs IJsonModel<ClusterLogAnalyticsApplicationLogs>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterLogAnalyticsApplicationLogs>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ClusterLogAnalyticsApplicationLogs)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeClusterLogAnalyticsApplicationLogs(document.RootElement, options);
        }

        internal static ClusterLogAnalyticsApplicationLogs DeserializeClusterLogAnalyticsApplicationLogs(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool? stdOutEnabled = default;
            bool? stdErrorEnabled = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("stdOutEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    stdOutEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("stdErrorEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    stdErrorEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ClusterLogAnalyticsApplicationLogs(stdOutEnabled, stdErrorEnabled, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ClusterLogAnalyticsApplicationLogs>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterLogAnalyticsApplicationLogs>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ClusterLogAnalyticsApplicationLogs)} does not support writing '{options.Format}' format.");
            }
        }

        ClusterLogAnalyticsApplicationLogs IPersistableModel<ClusterLogAnalyticsApplicationLogs>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterLogAnalyticsApplicationLogs>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeClusterLogAnalyticsApplicationLogs(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ClusterLogAnalyticsApplicationLogs)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ClusterLogAnalyticsApplicationLogs>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
