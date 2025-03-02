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
    public partial class A2ACrossClusterMigrationPolicyCreationContent : IUtf8JsonSerializable, IJsonModel<A2ACrossClusterMigrationPolicyCreationContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<A2ACrossClusterMigrationPolicyCreationContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<A2ACrossClusterMigrationPolicyCreationContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<A2ACrossClusterMigrationPolicyCreationContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(A2ACrossClusterMigrationPolicyCreationContent)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
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

        A2ACrossClusterMigrationPolicyCreationContent IJsonModel<A2ACrossClusterMigrationPolicyCreationContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<A2ACrossClusterMigrationPolicyCreationContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(A2ACrossClusterMigrationPolicyCreationContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeA2ACrossClusterMigrationPolicyCreationContent(document.RootElement, options);
        }

        internal static A2ACrossClusterMigrationPolicyCreationContent DeserializeA2ACrossClusterMigrationPolicyCreationContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string instanceType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
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
            return new A2ACrossClusterMigrationPolicyCreationContent(instanceType, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<A2ACrossClusterMigrationPolicyCreationContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<A2ACrossClusterMigrationPolicyCreationContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(A2ACrossClusterMigrationPolicyCreationContent)} does not support writing '{options.Format}' format.");
            }
        }

        A2ACrossClusterMigrationPolicyCreationContent IPersistableModel<A2ACrossClusterMigrationPolicyCreationContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<A2ACrossClusterMigrationPolicyCreationContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeA2ACrossClusterMigrationPolicyCreationContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(A2ACrossClusterMigrationPolicyCreationContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<A2ACrossClusterMigrationPolicyCreationContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
