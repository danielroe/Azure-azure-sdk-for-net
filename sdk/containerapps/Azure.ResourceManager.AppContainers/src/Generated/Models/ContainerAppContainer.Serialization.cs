// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppContainers.Models
{
    public partial class ContainerAppContainer : IUtf8JsonSerializable, IJsonModel<ContainerAppContainer>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerAppContainer>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ContainerAppContainer>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppContainer>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerAppContainer)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Probes))
            {
                writer.WritePropertyName("probes"u8);
                writer.WriteStartArray();
                foreach (var item in Probes)
                {
                    writer.WriteObjectValue<ContainerAppProbe>(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Image))
            {
                writer.WritePropertyName("image"u8);
                writer.WriteStringValue(Image);
            }
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsCollectionDefined(Command))
            {
                writer.WritePropertyName("command"u8);
                writer.WriteStartArray();
                foreach (var item in Command)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Args))
            {
                writer.WritePropertyName("args"u8);
                writer.WriteStartArray();
                foreach (var item in Args)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Env))
            {
                writer.WritePropertyName("env"u8);
                writer.WriteStartArray();
                foreach (var item in Env)
                {
                    writer.WriteObjectValue<ContainerAppEnvironmentVariable>(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Resources))
            {
                writer.WritePropertyName("resources"u8);
                writer.WriteObjectValue<AppContainerResources>(Resources, options);
            }
            if (Optional.IsCollectionDefined(VolumeMounts))
            {
                writer.WritePropertyName("volumeMounts"u8);
                writer.WriteStartArray();
                foreach (var item in VolumeMounts)
                {
                    writer.WriteObjectValue<ContainerAppVolumeMount>(item, options);
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

        ContainerAppContainer IJsonModel<ContainerAppContainer>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppContainer>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerAppContainer)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerAppContainer(document.RootElement, options);
        }

        internal static ContainerAppContainer DeserializeContainerAppContainer(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<ContainerAppProbe> probes = default;
            string image = default;
            string name = default;
            IList<string> command = default;
            IList<string> args = default;
            IList<ContainerAppEnvironmentVariable> env = default;
            AppContainerResources resources = default;
            IList<ContainerAppVolumeMount> volumeMounts = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("probes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ContainerAppProbe> array = new List<ContainerAppProbe>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContainerAppProbe.DeserializeContainerAppProbe(item, options));
                    }
                    probes = array;
                    continue;
                }
                if (property.NameEquals("image"u8))
                {
                    image = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("command"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    command = array;
                    continue;
                }
                if (property.NameEquals("args"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    args = array;
                    continue;
                }
                if (property.NameEquals("env"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ContainerAppEnvironmentVariable> array = new List<ContainerAppEnvironmentVariable>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContainerAppEnvironmentVariable.DeserializeContainerAppEnvironmentVariable(item, options));
                    }
                    env = array;
                    continue;
                }
                if (property.NameEquals("resources"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resources = AppContainerResources.DeserializeAppContainerResources(property.Value, options);
                    continue;
                }
                if (property.NameEquals("volumeMounts"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ContainerAppVolumeMount> array = new List<ContainerAppVolumeMount>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContainerAppVolumeMount.DeserializeContainerAppVolumeMount(item, options));
                    }
                    volumeMounts = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ContainerAppContainer(
                image,
                name,
                command ?? new ChangeTrackingList<string>(),
                args ?? new ChangeTrackingList<string>(),
                env ?? new ChangeTrackingList<ContainerAppEnvironmentVariable>(),
                resources,
                volumeMounts ?? new ChangeTrackingList<ContainerAppVolumeMount>(),
                serializedAdditionalRawData,
                probes ?? new ChangeTrackingList<ContainerAppProbe>());
        }

        BinaryData IPersistableModel<ContainerAppContainer>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppContainer>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ContainerAppContainer)} does not support writing '{options.Format}' format.");
            }
        }

        ContainerAppContainer IPersistableModel<ContainerAppContainer>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppContainer>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContainerAppContainer(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContainerAppContainer)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerAppContainer>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
