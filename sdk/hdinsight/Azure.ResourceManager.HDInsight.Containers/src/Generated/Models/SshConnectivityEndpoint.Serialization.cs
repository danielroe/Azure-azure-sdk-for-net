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
    public partial class SshConnectivityEndpoint : IUtf8JsonSerializable, IJsonModel<SshConnectivityEndpoint>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SshConnectivityEndpoint>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SshConnectivityEndpoint>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SshConnectivityEndpoint>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SshConnectivityEndpoint)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("endpoint"u8);
            writer.WriteStringValue(Endpoint);
            if (Optional.IsDefined(PrivateSshEndpoint))
            {
                writer.WritePropertyName("privateSshEndpoint"u8);
                writer.WriteStringValue(PrivateSshEndpoint);
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

        SshConnectivityEndpoint IJsonModel<SshConnectivityEndpoint>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SshConnectivityEndpoint>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SshConnectivityEndpoint)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSshConnectivityEndpoint(document.RootElement, options);
        }

        internal static SshConnectivityEndpoint DeserializeSshConnectivityEndpoint(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string endpoint = default;
            string privateSshEndpoint = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("endpoint"u8))
                {
                    endpoint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("privateSshEndpoint"u8))
                {
                    privateSshEndpoint = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SshConnectivityEndpoint(endpoint, privateSshEndpoint, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SshConnectivityEndpoint>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SshConnectivityEndpoint>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SshConnectivityEndpoint)} does not support writing '{options.Format}' format.");
            }
        }

        SshConnectivityEndpoint IPersistableModel<SshConnectivityEndpoint>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SshConnectivityEndpoint>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSshConnectivityEndpoint(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SshConnectivityEndpoint)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SshConnectivityEndpoint>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
