// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.KubernetesConfiguration.Models
{
    public partial class KubernetesObjectStatus : IUtf8JsonSerializable, IJsonModel<KubernetesObjectStatus>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<KubernetesObjectStatus>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<KubernetesObjectStatus>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KubernetesObjectStatus>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(KubernetesObjectStatus)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Namespace))
            {
                writer.WritePropertyName("namespace"u8);
                writer.WriteStringValue(Namespace);
            }
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind);
            }
            if (Optional.IsDefined(ComplianceState))
            {
                writer.WritePropertyName("complianceState"u8);
                writer.WriteStringValue(ComplianceState.Value.ToString());
            }
            if (Optional.IsDefined(AppliedBy))
            {
                if (AppliedBy != null)
                {
                    writer.WritePropertyName("appliedBy"u8);
                    writer.WriteObjectValue<KubernetesObjectReference>(AppliedBy, options);
                }
                else
                {
                    writer.WriteNull("appliedBy");
                }
            }
            if (Optional.IsCollectionDefined(StatusConditions))
            {
                if (StatusConditions != null)
                {
                    writer.WritePropertyName("statusConditions"u8);
                    writer.WriteStartArray();
                    foreach (var item in StatusConditions)
                    {
                        writer.WriteObjectValue<KubernetesObjectStatusCondition>(item, options);
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("statusConditions");
                }
            }
            if (Optional.IsDefined(HelmReleaseProperties))
            {
                if (HelmReleaseProperties != null)
                {
                    writer.WritePropertyName("helmReleaseProperties"u8);
                    writer.WriteObjectValue<HelmReleaseProperties>(HelmReleaseProperties, options);
                }
                else
                {
                    writer.WriteNull("helmReleaseProperties");
                }
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

        KubernetesObjectStatus IJsonModel<KubernetesObjectStatus>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KubernetesObjectStatus>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(KubernetesObjectStatus)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeKubernetesObjectStatus(document.RootElement, options);
        }

        internal static KubernetesObjectStatus DeserializeKubernetesObjectStatus(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            string @namespace = default;
            string kind = default;
            KubernetesFluxComplianceState? complianceState = default;
            KubernetesObjectReference appliedBy = default;
            IReadOnlyList<KubernetesObjectStatusCondition> statusConditions = default;
            HelmReleaseProperties helmReleaseProperties = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("namespace"u8))
                {
                    @namespace = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("complianceState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    complianceState = new KubernetesFluxComplianceState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("appliedBy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        appliedBy = null;
                        continue;
                    }
                    appliedBy = KubernetesObjectReference.DeserializeKubernetesObjectReference(property.Value, options);
                    continue;
                }
                if (property.NameEquals("statusConditions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        statusConditions = null;
                        continue;
                    }
                    List<KubernetesObjectStatusCondition> array = new List<KubernetesObjectStatusCondition>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(KubernetesObjectStatusCondition.DeserializeKubernetesObjectStatusCondition(item, options));
                    }
                    statusConditions = array;
                    continue;
                }
                if (property.NameEquals("helmReleaseProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        helmReleaseProperties = null;
                        continue;
                    }
                    helmReleaseProperties = HelmReleaseProperties.DeserializeHelmReleaseProperties(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new KubernetesObjectStatus(
                name,
                @namespace,
                kind,
                complianceState,
                appliedBy,
                statusConditions ?? new ChangeTrackingList<KubernetesObjectStatusCondition>(),
                helmReleaseProperties,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<KubernetesObjectStatus>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KubernetesObjectStatus>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(KubernetesObjectStatus)} does not support writing '{options.Format}' format.");
            }
        }

        KubernetesObjectStatus IPersistableModel<KubernetesObjectStatus>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KubernetesObjectStatus>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeKubernetesObjectStatus(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(KubernetesObjectStatus)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<KubernetesObjectStatus>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
