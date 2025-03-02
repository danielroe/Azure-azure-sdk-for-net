// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppComplianceAutomation.Models
{
    public partial class Assessment : IUtf8JsonSerializable, IJsonModel<Assessment>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<Assessment>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<Assessment>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<Assessment>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(Assessment)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W" && Optional.IsDefined(Severity))
            {
                writer.WritePropertyName("severity"u8);
                writer.WriteStringValue(Severity.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (options.Format != "W" && Optional.IsDefined(Remediation))
            {
                writer.WritePropertyName("remediation"u8);
                writer.WriteStringValue(Remediation);
            }
            if (options.Format != "W" && Optional.IsDefined(IsPass))
            {
                writer.WritePropertyName("isPass"u8);
                writer.WriteStringValue(IsPass.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(PolicyId))
            {
                writer.WritePropertyName("policyId"u8);
                writer.WriteStringValue(PolicyId);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(ResourceList))
            {
                writer.WritePropertyName("resourceList"u8);
                writer.WriteStartArray();
                foreach (var item in ResourceList)
                {
                    writer.WriteObjectValue<AssessmentResourceContent>(item, options);
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

        Assessment IJsonModel<Assessment>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<Assessment>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(Assessment)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAssessment(document.RootElement, options);
        }

        internal static Assessment DeserializeAssessment(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            AssessmentSeverity? severity = default;
            string description = default;
            string remediation = default;
            IsPass? isPass = default;
            string policyId = default;
            IReadOnlyList<AssessmentResourceContent> resourceList = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("severity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    severity = new AssessmentSeverity(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("remediation"u8))
                {
                    remediation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isPass"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isPass = new IsPass(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("policyId"u8))
                {
                    policyId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceList"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AssessmentResourceContent> array = new List<AssessmentResourceContent>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AssessmentResourceContent.DeserializeAssessmentResourceContent(item, options));
                    }
                    resourceList = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new Assessment(
                name,
                severity,
                description,
                remediation,
                isPass,
                policyId,
                resourceList ?? new ChangeTrackingList<AssessmentResourceContent>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<Assessment>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<Assessment>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(Assessment)} does not support writing '{options.Format}' format.");
            }
        }

        Assessment IPersistableModel<Assessment>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<Assessment>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAssessment(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(Assessment)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<Assessment>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
