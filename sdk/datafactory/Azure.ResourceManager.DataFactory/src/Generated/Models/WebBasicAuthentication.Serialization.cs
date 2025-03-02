// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class WebBasicAuthentication : IUtf8JsonSerializable, IJsonModel<WebBasicAuthentication>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<WebBasicAuthentication>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<WebBasicAuthentication>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebBasicAuthentication>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WebBasicAuthentication)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("username"u8);
            JsonSerializer.Serialize(writer, Username);
            writer.WritePropertyName("password"u8);
            JsonSerializer.Serialize(writer, Password);
            writer.WritePropertyName("url"u8);
            JsonSerializer.Serialize(writer, Uri);
            writer.WritePropertyName("authenticationType"u8);
            writer.WriteStringValue(AuthenticationType.ToString());
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

        WebBasicAuthentication IJsonModel<WebBasicAuthentication>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebBasicAuthentication>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WebBasicAuthentication)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeWebBasicAuthentication(document.RootElement, options);
        }

        internal static WebBasicAuthentication DeserializeWebBasicAuthentication(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DataFactoryElement<string> username = default;
            DataFactorySecret password = default;
            DataFactoryElement<string> url = default;
            WebAuthenticationType authenticationType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("username"u8))
                {
                    username = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("password"u8))
                {
                    password = JsonSerializer.Deserialize<DataFactorySecret>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("url"u8))
                {
                    url = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("authenticationType"u8))
                {
                    authenticationType = new WebAuthenticationType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new WebBasicAuthentication(url, authenticationType, serializedAdditionalRawData, username, password);
        }

        BinaryData IPersistableModel<WebBasicAuthentication>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebBasicAuthentication>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(WebBasicAuthentication)} does not support writing '{options.Format}' format.");
            }
        }

        WebBasicAuthentication IPersistableModel<WebBasicAuthentication>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebBasicAuthentication>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeWebBasicAuthentication(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(WebBasicAuthentication)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<WebBasicAuthentication>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
