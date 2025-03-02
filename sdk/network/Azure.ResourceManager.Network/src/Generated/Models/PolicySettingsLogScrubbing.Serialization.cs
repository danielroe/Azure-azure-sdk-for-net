// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class PolicySettingsLogScrubbing : IUtf8JsonSerializable, IJsonModel<PolicySettingsLogScrubbing>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PolicySettingsLogScrubbing>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PolicySettingsLogScrubbing>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PolicySettingsLogScrubbing>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PolicySettingsLogScrubbing)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State.Value.ToString());
            }
            if (Optional.IsCollectionDefined(ScrubbingRules))
            {
                writer.WritePropertyName("scrubbingRules"u8);
                writer.WriteStartArray();
                foreach (var item in ScrubbingRules)
                {
                    writer.WriteObjectValue<WebApplicationFirewallScrubbingRules>(item, options);
                }
                writer.WriteEndArray();
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

        PolicySettingsLogScrubbing IJsonModel<PolicySettingsLogScrubbing>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PolicySettingsLogScrubbing>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PolicySettingsLogScrubbing)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePolicySettingsLogScrubbing(document.RootElement, options);
        }

        internal static PolicySettingsLogScrubbing DeserializePolicySettingsLogScrubbing(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            WebApplicationFirewallScrubbingState? state = default;
            IList<WebApplicationFirewallScrubbingRules> scrubbingRules = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = new WebApplicationFirewallScrubbingState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("scrubbingRules"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<WebApplicationFirewallScrubbingRules> array = new List<WebApplicationFirewallScrubbingRules>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(WebApplicationFirewallScrubbingRules.DeserializeWebApplicationFirewallScrubbingRules(item, options));
                    }
                    scrubbingRules = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PolicySettingsLogScrubbing(state, scrubbingRules ?? new ChangeTrackingList<WebApplicationFirewallScrubbingRules>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PolicySettingsLogScrubbing>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PolicySettingsLogScrubbing>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PolicySettingsLogScrubbing)} does not support writing '{options.Format}' format.");
            }
        }

        PolicySettingsLogScrubbing IPersistableModel<PolicySettingsLogScrubbing>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PolicySettingsLogScrubbing>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePolicySettingsLogScrubbing(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PolicySettingsLogScrubbing)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<PolicySettingsLogScrubbing>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
