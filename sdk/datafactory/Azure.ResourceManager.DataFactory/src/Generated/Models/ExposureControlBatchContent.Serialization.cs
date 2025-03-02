// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class ExposureControlBatchContent : IUtf8JsonSerializable, IJsonModel<ExposureControlBatchContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ExposureControlBatchContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ExposureControlBatchContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExposureControlBatchContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExposureControlBatchContent)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("exposureControlRequests"u8);
            writer.WriteStartArray();
            foreach (var item in ExposureControlRequests)
            {
                writer.WriteObjectValue<ExposureControlContent>(item, options);
            }
            writer.WriteEndArray();
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

        ExposureControlBatchContent IJsonModel<ExposureControlBatchContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExposureControlBatchContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExposureControlBatchContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeExposureControlBatchContent(document.RootElement, options);
        }

        internal static ExposureControlBatchContent DeserializeExposureControlBatchContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<ExposureControlContent> exposureControlRequests = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("exposureControlRequests"u8))
                {
                    List<ExposureControlContent> array = new List<ExposureControlContent>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ExposureControlContent.DeserializeExposureControlContent(item, options));
                    }
                    exposureControlRequests = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ExposureControlBatchContent(exposureControlRequests, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ExposureControlBatchContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExposureControlBatchContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ExposureControlBatchContent)} does not support writing '{options.Format}' format.");
            }
        }

        ExposureControlBatchContent IPersistableModel<ExposureControlBatchContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExposureControlBatchContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeExposureControlBatchContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ExposureControlBatchContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ExposureControlBatchContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
