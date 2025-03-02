// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    public partial class DataProtectionBackupVaultPatchProperties : IUtf8JsonSerializable, IJsonModel<DataProtectionBackupVaultPatchProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataProtectionBackupVaultPatchProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DataProtectionBackupVaultPatchProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataProtectionBackupVaultPatchProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataProtectionBackupVaultPatchProperties)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(MonitoringSettings))
            {
                writer.WritePropertyName("monitoringSettings"u8);
                writer.WriteObjectValue<MonitoringSettings>(MonitoringSettings, options);
            }
            if (Optional.IsDefined(SecuritySettings))
            {
                writer.WritePropertyName("securitySettings"u8);
                writer.WriteObjectValue<BackupVaultSecuritySettings>(SecuritySettings, options);
            }
            if (Optional.IsDefined(FeatureSettings))
            {
                writer.WritePropertyName("featureSettings"u8);
                writer.WriteObjectValue<BackupVaultFeatureSettings>(FeatureSettings, options);
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

        DataProtectionBackupVaultPatchProperties IJsonModel<DataProtectionBackupVaultPatchProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataProtectionBackupVaultPatchProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataProtectionBackupVaultPatchProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataProtectionBackupVaultPatchProperties(document.RootElement, options);
        }

        internal static DataProtectionBackupVaultPatchProperties DeserializeDataProtectionBackupVaultPatchProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            MonitoringSettings monitoringSettings = default;
            BackupVaultSecuritySettings securitySettings = default;
            BackupVaultFeatureSettings featureSettings = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("monitoringSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    monitoringSettings = MonitoringSettings.DeserializeMonitoringSettings(property.Value, options);
                    continue;
                }
                if (property.NameEquals("securitySettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    securitySettings = BackupVaultSecuritySettings.DeserializeBackupVaultSecuritySettings(property.Value, options);
                    continue;
                }
                if (property.NameEquals("featureSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    featureSettings = BackupVaultFeatureSettings.DeserializeBackupVaultFeatureSettings(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DataProtectionBackupVaultPatchProperties(monitoringSettings, securitySettings, featureSettings, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DataProtectionBackupVaultPatchProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataProtectionBackupVaultPatchProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataProtectionBackupVaultPatchProperties)} does not support writing '{options.Format}' format.");
            }
        }

        DataProtectionBackupVaultPatchProperties IPersistableModel<DataProtectionBackupVaultPatchProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataProtectionBackupVaultPatchProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataProtectionBackupVaultPatchProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataProtectionBackupVaultPatchProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataProtectionBackupVaultPatchProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
