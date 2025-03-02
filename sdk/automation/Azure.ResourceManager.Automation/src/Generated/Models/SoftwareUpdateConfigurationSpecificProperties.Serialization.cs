// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Automation.Models
{
    public partial class SoftwareUpdateConfigurationSpecificProperties : IUtf8JsonSerializable, IJsonModel<SoftwareUpdateConfigurationSpecificProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SoftwareUpdateConfigurationSpecificProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SoftwareUpdateConfigurationSpecificProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SoftwareUpdateConfigurationSpecificProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SoftwareUpdateConfigurationSpecificProperties)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("operatingSystem"u8);
            writer.WriteStringValue(OperatingSystem.ToSerialString());
            if (Optional.IsDefined(Windows))
            {
                writer.WritePropertyName("windows"u8);
                writer.WriteObjectValue<WindowsUpdateConfigurationProperties>(Windows, options);
            }
            if (Optional.IsDefined(Linux))
            {
                writer.WritePropertyName("linux"u8);
                writer.WriteObjectValue<LinuxUpdateConfigurationProperties>(Linux, options);
            }
            if (Optional.IsDefined(Duration))
            {
                writer.WritePropertyName("duration"u8);
                writer.WriteStringValue(Duration.Value, "P");
            }
            if (Optional.IsCollectionDefined(AzureVirtualMachines))
            {
                writer.WritePropertyName("azureVirtualMachines"u8);
                writer.WriteStartArray();
                foreach (var item in AzureVirtualMachines)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(NonAzureComputerNames))
            {
                writer.WritePropertyName("nonAzureComputerNames"u8);
                writer.WriteStartArray();
                foreach (var item in NonAzureComputerNames)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Targets))
            {
                writer.WritePropertyName("targets"u8);
                writer.WriteObjectValue<SoftwareUpdateConfigurationTargetProperties>(Targets, options);
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

        SoftwareUpdateConfigurationSpecificProperties IJsonModel<SoftwareUpdateConfigurationSpecificProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SoftwareUpdateConfigurationSpecificProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SoftwareUpdateConfigurationSpecificProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSoftwareUpdateConfigurationSpecificProperties(document.RootElement, options);
        }

        internal static SoftwareUpdateConfigurationSpecificProperties DeserializeSoftwareUpdateConfigurationSpecificProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            SoftwareUpdateConfigurationOperatingSystemType operatingSystem = default;
            WindowsUpdateConfigurationProperties windows = default;
            LinuxUpdateConfigurationProperties linux = default;
            TimeSpan? duration = default;
            IList<string> azureVirtualMachines = default;
            IList<string> nonAzureComputerNames = default;
            SoftwareUpdateConfigurationTargetProperties targets = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("operatingSystem"u8))
                {
                    operatingSystem = property.Value.GetString().ToSoftwareUpdateConfigurationOperatingSystemType();
                    continue;
                }
                if (property.NameEquals("windows"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    windows = WindowsUpdateConfigurationProperties.DeserializeWindowsUpdateConfigurationProperties(property.Value, options);
                    continue;
                }
                if (property.NameEquals("linux"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    linux = LinuxUpdateConfigurationProperties.DeserializeLinuxUpdateConfigurationProperties(property.Value, options);
                    continue;
                }
                if (property.NameEquals("duration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    duration = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("azureVirtualMachines"u8))
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
                    azureVirtualMachines = array;
                    continue;
                }
                if (property.NameEquals("nonAzureComputerNames"u8))
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
                    nonAzureComputerNames = array;
                    continue;
                }
                if (property.NameEquals("targets"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targets = SoftwareUpdateConfigurationTargetProperties.DeserializeSoftwareUpdateConfigurationTargetProperties(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SoftwareUpdateConfigurationSpecificProperties(
                operatingSystem,
                windows,
                linux,
                duration,
                azureVirtualMachines ?? new ChangeTrackingList<string>(),
                nonAzureComputerNames ?? new ChangeTrackingList<string>(),
                targets,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SoftwareUpdateConfigurationSpecificProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SoftwareUpdateConfigurationSpecificProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SoftwareUpdateConfigurationSpecificProperties)} does not support writing '{options.Format}' format.");
            }
        }

        SoftwareUpdateConfigurationSpecificProperties IPersistableModel<SoftwareUpdateConfigurationSpecificProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SoftwareUpdateConfigurationSpecificProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSoftwareUpdateConfigurationSpecificProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SoftwareUpdateConfigurationSpecificProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SoftwareUpdateConfigurationSpecificProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
