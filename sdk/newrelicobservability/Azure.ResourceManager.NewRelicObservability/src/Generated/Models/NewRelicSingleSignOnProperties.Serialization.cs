// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NewRelicObservability.Models
{
    public partial class NewRelicSingleSignOnProperties : IUtf8JsonSerializable, IJsonModel<NewRelicSingleSignOnProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NewRelicSingleSignOnProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<NewRelicSingleSignOnProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NewRelicSingleSignOnProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NewRelicSingleSignOnProperties)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(SingleSignOnState))
            {
                writer.WritePropertyName("singleSignOnState"u8);
                writer.WriteStringValue(SingleSignOnState.Value.ToString());
            }
            if (Optional.IsDefined(EnterpriseAppId))
            {
                writer.WritePropertyName("enterpriseAppId"u8);
                writer.WriteStringValue(EnterpriseAppId);
            }
            if (Optional.IsDefined(SingleSignOnUri))
            {
                writer.WritePropertyName("singleSignOnUrl"u8);
                writer.WriteStringValue(SingleSignOnUri.AbsoluteUri);
            }
            if (Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
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

        NewRelicSingleSignOnProperties IJsonModel<NewRelicSingleSignOnProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NewRelicSingleSignOnProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NewRelicSingleSignOnProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNewRelicSingleSignOnProperties(document.RootElement, options);
        }

        internal static NewRelicSingleSignOnProperties DeserializeNewRelicSingleSignOnProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            NewRelicSingleSignOnState? singleSignOnState = default;
            string enterpriseAppId = default;
            Uri singleSignOnUrl = default;
            NewRelicProvisioningState? provisioningState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("singleSignOnState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    singleSignOnState = new NewRelicSingleSignOnState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("enterpriseAppId"u8))
                {
                    enterpriseAppId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("singleSignOnUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    singleSignOnUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new NewRelicProvisioningState(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new NewRelicSingleSignOnProperties(singleSignOnState, enterpriseAppId, singleSignOnUrl, provisioningState, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NewRelicSingleSignOnProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NewRelicSingleSignOnProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NewRelicSingleSignOnProperties)} does not support writing '{options.Format}' format.");
            }
        }

        NewRelicSingleSignOnProperties IPersistableModel<NewRelicSingleSignOnProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NewRelicSingleSignOnProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNewRelicSingleSignOnProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NewRelicSingleSignOnProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<NewRelicSingleSignOnProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
