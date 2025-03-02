// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Media.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Media
{
    public partial class MediaLiveEventData : IUtf8JsonSerializable, IJsonModel<MediaLiveEventData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MediaLiveEventData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MediaLiveEventData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MediaLiveEventData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MediaLiveEventData)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(Input))
            {
                writer.WritePropertyName("input"u8);
                writer.WriteObjectValue<LiveEventInput>(Input, options);
            }
            if (Optional.IsDefined(Preview))
            {
                writer.WritePropertyName("preview"u8);
                writer.WriteObjectValue<LiveEventPreview>(Preview, options);
            }
            if (Optional.IsDefined(Encoding))
            {
                writer.WritePropertyName("encoding"u8);
                writer.WriteObjectValue<LiveEventEncoding>(Encoding, options);
            }
            if (Optional.IsCollectionDefined(Transcriptions))
            {
                writer.WritePropertyName("transcriptions"u8);
                writer.WriteStartArray();
                foreach (var item in Transcriptions)
                {
                    writer.WriteObjectValue<LiveEventTranscription>(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState);
            }
            if (options.Format != "W" && Optional.IsDefined(ResourceState))
            {
                writer.WritePropertyName("resourceState"u8);
                writer.WriteStringValue(ResourceState.Value.ToString());
            }
            if (Optional.IsDefined(CrossSiteAccessPolicies))
            {
                writer.WritePropertyName("crossSiteAccessPolicies"u8);
                writer.WriteObjectValue<CrossSiteAccessPolicies>(CrossSiteAccessPolicies, options);
            }
            if (Optional.IsDefined(UseStaticHostname))
            {
                writer.WritePropertyName("useStaticHostname"u8);
                writer.WriteBooleanValue(UseStaticHostname.Value);
            }
            if (Optional.IsDefined(HostnamePrefix))
            {
                writer.WritePropertyName("hostnamePrefix"u8);
                writer.WriteStringValue(HostnamePrefix);
            }
            if (Optional.IsCollectionDefined(StreamOptions))
            {
                writer.WritePropertyName("streamOptions"u8);
                writer.WriteStartArray();
                foreach (var item in StreamOptions)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(CreatedOn))
            {
                writer.WritePropertyName("created"u8);
                writer.WriteStringValue(CreatedOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(LastModifiedOn))
            {
                writer.WritePropertyName("lastModified"u8);
                writer.WriteStringValue(LastModifiedOn.Value, "O");
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

        MediaLiveEventData IJsonModel<MediaLiveEventData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MediaLiveEventData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MediaLiveEventData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMediaLiveEventData(document.RootElement, options);
        }

        internal static MediaLiveEventData DeserializeMediaLiveEventData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IDictionary<string, string> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            string description = default;
            LiveEventInput input = default;
            LiveEventPreview preview = default;
            LiveEventEncoding encoding = default;
            IList<LiveEventTranscription> transcriptions = default;
            string provisioningState = default;
            LiveEventResourceState? resourceState = default;
            CrossSiteAccessPolicies crossSiteAccessPolicies = default;
            bool? useStaticHostname = default;
            string hostnamePrefix = default;
            IList<StreamOptionsFlag> streamOptions = default;
            DateTimeOffset? created = default;
            DateTimeOffset? lastModified = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
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
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("input"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            input = LiveEventInput.DeserializeLiveEventInput(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("preview"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            preview = LiveEventPreview.DeserializeLiveEventPreview(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("encoding"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            encoding = LiveEventEncoding.DeserializeLiveEventEncoding(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("transcriptions"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<LiveEventTranscription> array = new List<LiveEventTranscription>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(LiveEventTranscription.DeserializeLiveEventTranscription(item, options));
                            }
                            transcriptions = array;
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("resourceState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            resourceState = new LiveEventResourceState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("crossSiteAccessPolicies"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            crossSiteAccessPolicies = CrossSiteAccessPolicies.DeserializeCrossSiteAccessPolicies(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("useStaticHostname"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            useStaticHostname = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("hostnamePrefix"u8))
                        {
                            hostnamePrefix = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("streamOptions"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<StreamOptionsFlag> array = new List<StreamOptionsFlag>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(new StreamOptionsFlag(item.GetString()));
                            }
                            streamOptions = array;
                            continue;
                        }
                        if (property0.NameEquals("created"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            created = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("lastModified"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastModified = property0.Value.GetDateTimeOffset("O");
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
            return new MediaLiveEventData(
                id,
                name,
                type,
                systemData,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                location,
                description,
                input,
                preview,
                encoding,
                transcriptions ?? new ChangeTrackingList<LiveEventTranscription>(),
                provisioningState,
                resourceState,
                crossSiteAccessPolicies,
                useStaticHostname,
                hostnamePrefix,
                streamOptions ?? new ChangeTrackingList<StreamOptionsFlag>(),
                created,
                lastModified,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MediaLiveEventData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MediaLiveEventData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MediaLiveEventData)} does not support writing '{options.Format}' format.");
            }
        }

        MediaLiveEventData IPersistableModel<MediaLiveEventData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MediaLiveEventData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMediaLiveEventData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MediaLiveEventData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MediaLiveEventData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
