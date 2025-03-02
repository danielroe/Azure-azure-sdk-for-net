// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class VMwareV2FabricCreationContent : IUtf8JsonSerializable, IJsonModel<VMwareV2FabricCreationContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VMwareV2FabricCreationContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<VMwareV2FabricCreationContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VMwareV2FabricCreationContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VMwareV2FabricCreationContent)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(VMwareSiteId))
            {
                writer.WritePropertyName("vmwareSiteId"u8);
                writer.WriteStringValue(VMwareSiteId);
            }
            if (Optional.IsDefined(PhysicalSiteId))
            {
                writer.WritePropertyName("physicalSiteId"u8);
                writer.WriteStringValue(PhysicalSiteId);
            }
            writer.WritePropertyName("migrationSolutionId"u8);
            writer.WriteStringValue(MigrationSolutionId);
            writer.WritePropertyName("instanceType"u8);
            writer.WriteStringValue(InstanceType);
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

        VMwareV2FabricCreationContent IJsonModel<VMwareV2FabricCreationContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VMwareV2FabricCreationContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VMwareV2FabricCreationContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVMwareV2FabricCreationContent(document.RootElement, options);
        }

        internal static VMwareV2FabricCreationContent DeserializeVMwareV2FabricCreationContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier vmwareSiteId = default;
            ResourceIdentifier physicalSiteId = default;
            ResourceIdentifier migrationSolutionId = default;
            string instanceType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("vmwareSiteId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    vmwareSiteId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("physicalSiteId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    physicalSiteId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("migrationSolutionId"u8))
                {
                    migrationSolutionId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("instanceType"u8))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new VMwareV2FabricCreationContent(instanceType, serializedAdditionalRawData, vmwareSiteId, physicalSiteId, migrationSolutionId);
        }

        BinaryData IPersistableModel<VMwareV2FabricCreationContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VMwareV2FabricCreationContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(VMwareV2FabricCreationContent)} does not support writing '{options.Format}' format.");
            }
        }

        VMwareV2FabricCreationContent IPersistableModel<VMwareV2FabricCreationContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VMwareV2FabricCreationContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVMwareV2FabricCreationContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VMwareV2FabricCreationContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<VMwareV2FabricCreationContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
