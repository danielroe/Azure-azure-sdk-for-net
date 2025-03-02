// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EventGrid.Models
{
    public partial class WebhookUpdatePartnerDestinationInfo : IUtf8JsonSerializable, IJsonModel<WebhookUpdatePartnerDestinationInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<WebhookUpdatePartnerDestinationInfo>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<WebhookUpdatePartnerDestinationInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebhookUpdatePartnerDestinationInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WebhookUpdatePartnerDestinationInfo)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("endpointType"u8);
            writer.WriteStringValue(EndpointType.ToString());
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(EndpointUri))
            {
                writer.WritePropertyName("endpointUrl"u8);
                writer.WriteStringValue(EndpointUri.AbsoluteUri);
            }
            if (Optional.IsDefined(EndpointBaseUri))
            {
                writer.WritePropertyName("endpointBaseUrl"u8);
                writer.WriteStringValue(EndpointBaseUri.AbsoluteUri);
            }
            if (Optional.IsDefined(ClientAuthentication))
            {
                writer.WritePropertyName("clientAuthentication"u8);
                writer.WriteObjectValue<PartnerClientAuthentication>(ClientAuthentication, options);
            }
            writer.WriteEndObject();
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

        WebhookUpdatePartnerDestinationInfo IJsonModel<WebhookUpdatePartnerDestinationInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebhookUpdatePartnerDestinationInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WebhookUpdatePartnerDestinationInfo)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeWebhookUpdatePartnerDestinationInfo(document.RootElement, options);
        }

        internal static WebhookUpdatePartnerDestinationInfo DeserializeWebhookUpdatePartnerDestinationInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            PartnerEndpointType endpointType = default;
            Uri endpointUri = default;
            Uri endpointBaseUri = default;
            PartnerClientAuthentication clientAuthentication = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("endpointType"u8))
                {
                    endpointType = new PartnerEndpointType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("endpointUrl"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            endpointUri = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("endpointBaseUrl"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            endpointBaseUri = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("clientAuthentication"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            clientAuthentication = PartnerClientAuthentication.DeserializePartnerClientAuthentication(property0.Value, options);
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new WebhookUpdatePartnerDestinationInfo(endpointType, serializedAdditionalRawData, endpointUri, endpointBaseUri, clientAuthentication);
        }

        BinaryData IPersistableModel<WebhookUpdatePartnerDestinationInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebhookUpdatePartnerDestinationInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(WebhookUpdatePartnerDestinationInfo)} does not support writing '{options.Format}' format.");
            }
        }

        WebhookUpdatePartnerDestinationInfo IPersistableModel<WebhookUpdatePartnerDestinationInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebhookUpdatePartnerDestinationInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeWebhookUpdatePartnerDestinationInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(WebhookUpdatePartnerDestinationInfo)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<WebhookUpdatePartnerDestinationInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
