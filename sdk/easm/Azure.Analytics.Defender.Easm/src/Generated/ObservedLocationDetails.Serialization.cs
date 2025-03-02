// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Defender.Easm
{
    public partial class ObservedLocationDetails : IUtf8JsonSerializable, IJsonModel<ObservedLocationDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ObservedLocationDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ObservedLocationDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ObservedLocationDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ObservedLocationDetails)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(CountryCode))
            {
                writer.WritePropertyName("countryCode"u8);
                writer.WriteStringValue(CountryCode);
            }
            if (Optional.IsDefined(CountryName))
            {
                writer.WritePropertyName("countryName"u8);
                writer.WriteStringValue(CountryName);
            }
            if (Optional.IsDefined(Region))
            {
                writer.WritePropertyName("region"u8);
                writer.WriteStringValue(Region);
            }
            if (Optional.IsDefined(RegionName))
            {
                writer.WritePropertyName("regionName"u8);
                writer.WriteStringValue(RegionName);
            }
            if (Optional.IsDefined(City))
            {
                writer.WritePropertyName("city"u8);
                writer.WriteStringValue(City);
            }
            if (Optional.IsDefined(AreaCode))
            {
                writer.WritePropertyName("areaCode"u8);
                writer.WriteNumberValue(AreaCode.Value);
            }
            if (Optional.IsDefined(PostalCode))
            {
                writer.WritePropertyName("postalCode"u8);
                writer.WriteStringValue(PostalCode);
            }
            if (Optional.IsDefined(Latitude))
            {
                writer.WritePropertyName("latitude"u8);
                writer.WriteNumberValue(Latitude.Value);
            }
            if (Optional.IsDefined(Longitude))
            {
                writer.WritePropertyName("longitude"u8);
                writer.WriteNumberValue(Longitude.Value);
            }
            if (Optional.IsDefined(DmaCode))
            {
                writer.WritePropertyName("dmaCode"u8);
                writer.WriteNumberValue(DmaCode.Value);
            }
            if (Optional.IsDefined(MetroCodeId))
            {
                writer.WritePropertyName("metroCodeId"u8);
                writer.WriteNumberValue(MetroCodeId.Value);
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

        ObservedLocationDetails IJsonModel<ObservedLocationDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ObservedLocationDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ObservedLocationDetails)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeObservedLocationDetails(document.RootElement, options);
        }

        internal static ObservedLocationDetails DeserializeObservedLocationDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string countryCode = default;
            string countryName = default;
            string region = default;
            string regionName = default;
            string city = default;
            int? areaCode = default;
            string postalCode = default;
            float? latitude = default;
            float? longitude = default;
            int? dmaCode = default;
            int? metroCodeId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("countryCode"u8))
                {
                    countryCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("countryName"u8))
                {
                    countryName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("region"u8))
                {
                    region = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("regionName"u8))
                {
                    regionName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("city"u8))
                {
                    city = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("areaCode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    areaCode = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("postalCode"u8))
                {
                    postalCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("latitude"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    latitude = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("longitude"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    longitude = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("dmaCode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dmaCode = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("metroCodeId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    metroCodeId = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ObservedLocationDetails(
                countryCode,
                countryName,
                region,
                regionName,
                city,
                areaCode,
                postalCode,
                latitude,
                longitude,
                dmaCode,
                metroCodeId,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ObservedLocationDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ObservedLocationDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ObservedLocationDetails)} does not support writing '{options.Format}' format.");
            }
        }

        ObservedLocationDetails IPersistableModel<ObservedLocationDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ObservedLocationDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeObservedLocationDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ObservedLocationDetails)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ObservedLocationDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static ObservedLocationDetails FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeObservedLocationDetails(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue<ObservedLocationDetails>(this, new ModelReaderWriterOptions("W"));
            return content;
        }
    }
}
