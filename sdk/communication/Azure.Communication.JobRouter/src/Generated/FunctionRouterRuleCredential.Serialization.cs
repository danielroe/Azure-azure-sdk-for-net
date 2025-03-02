// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.JobRouter
{
    public partial class FunctionRouterRuleCredential : IUtf8JsonSerializable, IJsonModel<FunctionRouterRuleCredential>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FunctionRouterRuleCredential>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<FunctionRouterRuleCredential>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FunctionRouterRuleCredential>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FunctionRouterRuleCredential)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(FunctionKey))
            {
                writer.WritePropertyName("functionKey"u8);
                writer.WriteStringValue(FunctionKey);
            }
            if (Optional.IsDefined(AppKey))
            {
                writer.WritePropertyName("appKey"u8);
                writer.WriteStringValue(AppKey);
            }
            if (Optional.IsDefined(ClientId))
            {
                writer.WritePropertyName("clientId"u8);
                writer.WriteStringValue(ClientId);
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

        FunctionRouterRuleCredential IJsonModel<FunctionRouterRuleCredential>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FunctionRouterRuleCredential>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FunctionRouterRuleCredential)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFunctionRouterRuleCredential(document.RootElement, options);
        }

        internal static FunctionRouterRuleCredential DeserializeFunctionRouterRuleCredential(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string functionKey = default;
            string appKey = default;
            string clientId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("functionKey"u8))
                {
                    functionKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("appKey"u8))
                {
                    appKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("clientId"u8))
                {
                    clientId = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new FunctionRouterRuleCredential(functionKey, appKey, clientId, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<FunctionRouterRuleCredential>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FunctionRouterRuleCredential>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(FunctionRouterRuleCredential)} does not support writing '{options.Format}' format.");
            }
        }

        FunctionRouterRuleCredential IPersistableModel<FunctionRouterRuleCredential>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FunctionRouterRuleCredential>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeFunctionRouterRuleCredential(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FunctionRouterRuleCredential)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<FunctionRouterRuleCredential>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static FunctionRouterRuleCredential FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeFunctionRouterRuleCredential(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue<FunctionRouterRuleCredential>(this, new ModelReaderWriterOptions("W"));
            return content;
        }
    }
}
