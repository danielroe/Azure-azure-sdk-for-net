// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class MachineLearningContainerRegistryCredentials : IUtf8JsonSerializable, IJsonModel<MachineLearningContainerRegistryCredentials>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineLearningContainerRegistryCredentials>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MachineLearningContainerRegistryCredentials>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningContainerRegistryCredentials>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningContainerRegistryCredentials)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(Location.Value);
            }
            if (Optional.IsCollectionDefined(Passwords))
            {
                writer.WritePropertyName("passwords"u8);
                writer.WriteStartArray();
                foreach (var item in Passwords)
                {
                    writer.WriteObjectValue<MachineLearningPasswordDetail>(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(Username))
            {
                writer.WritePropertyName("username"u8);
                writer.WriteStringValue(Username);
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

        MachineLearningContainerRegistryCredentials IJsonModel<MachineLearningContainerRegistryCredentials>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningContainerRegistryCredentials>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningContainerRegistryCredentials)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningContainerRegistryCredentials(document.RootElement, options);
        }

        internal static MachineLearningContainerRegistryCredentials DeserializeMachineLearningContainerRegistryCredentials(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AzureLocation? location = default;
            IReadOnlyList<MachineLearningPasswordDetail> passwords = default;
            string username = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("passwords"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MachineLearningPasswordDetail> array = new List<MachineLearningPasswordDetail>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MachineLearningPasswordDetail.DeserializeMachineLearningPasswordDetail(item, options));
                    }
                    passwords = array;
                    continue;
                }
                if (property.NameEquals("username"u8))
                {
                    username = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MachineLearningContainerRegistryCredentials(location, passwords ?? new ChangeTrackingList<MachineLearningPasswordDetail>(), username, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MachineLearningContainerRegistryCredentials>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningContainerRegistryCredentials>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MachineLearningContainerRegistryCredentials)} does not support writing '{options.Format}' format.");
            }
        }

        MachineLearningContainerRegistryCredentials IPersistableModel<MachineLearningContainerRegistryCredentials>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningContainerRegistryCredentials>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMachineLearningContainerRegistryCredentials(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MachineLearningContainerRegistryCredentials)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MachineLearningContainerRegistryCredentials>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
