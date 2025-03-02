// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class IaasVmProtectedItemExtendedInfo : IUtf8JsonSerializable, IJsonModel<IaasVmProtectedItemExtendedInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<IaasVmProtectedItemExtendedInfo>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<IaasVmProtectedItemExtendedInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IaasVmProtectedItemExtendedInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IaasVmProtectedItemExtendedInfo)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(OldestRecoverOn))
            {
                writer.WritePropertyName("oldestRecoveryPoint"u8);
                writer.WriteStringValue(OldestRecoverOn.Value, "O");
            }
            if (Optional.IsDefined(OldestRecoveryPointInVault))
            {
                writer.WritePropertyName("oldestRecoveryPointInVault"u8);
                writer.WriteStringValue(OldestRecoveryPointInVault.Value, "O");
            }
            if (Optional.IsDefined(OldestRecoveryPointInArchive))
            {
                writer.WritePropertyName("oldestRecoveryPointInArchive"u8);
                writer.WriteStringValue(OldestRecoveryPointInArchive.Value, "O");
            }
            if (Optional.IsDefined(NewestRecoveryPointInArchive))
            {
                writer.WritePropertyName("newestRecoveryPointInArchive"u8);
                writer.WriteStringValue(NewestRecoveryPointInArchive.Value, "O");
            }
            if (Optional.IsDefined(RecoveryPointCount))
            {
                writer.WritePropertyName("recoveryPointCount"u8);
                writer.WriteNumberValue(RecoveryPointCount.Value);
            }
            if (Optional.IsDefined(IsPolicyInconsistent))
            {
                writer.WritePropertyName("policyInconsistent"u8);
                writer.WriteBooleanValue(IsPolicyInconsistent.Value);
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

        IaasVmProtectedItemExtendedInfo IJsonModel<IaasVmProtectedItemExtendedInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IaasVmProtectedItemExtendedInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IaasVmProtectedItemExtendedInfo)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeIaasVmProtectedItemExtendedInfo(document.RootElement, options);
        }

        internal static IaasVmProtectedItemExtendedInfo DeserializeIaasVmProtectedItemExtendedInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DateTimeOffset? oldestRecoveryPoint = default;
            DateTimeOffset? oldestRecoveryPointInVault = default;
            DateTimeOffset? oldestRecoveryPointInArchive = default;
            DateTimeOffset? newestRecoveryPointInArchive = default;
            int? recoveryPointCount = default;
            bool? policyInconsistent = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("oldestRecoveryPoint"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    oldestRecoveryPoint = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("oldestRecoveryPointInVault"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    oldestRecoveryPointInVault = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("oldestRecoveryPointInArchive"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    oldestRecoveryPointInArchive = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("newestRecoveryPointInArchive"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    newestRecoveryPointInArchive = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("recoveryPointCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryPointCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("policyInconsistent"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    policyInconsistent = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new IaasVmProtectedItemExtendedInfo(
                oldestRecoveryPoint,
                oldestRecoveryPointInVault,
                oldestRecoveryPointInArchive,
                newestRecoveryPointInArchive,
                recoveryPointCount,
                policyInconsistent,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<IaasVmProtectedItemExtendedInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IaasVmProtectedItemExtendedInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(IaasVmProtectedItemExtendedInfo)} does not support writing '{options.Format}' format.");
            }
        }

        IaasVmProtectedItemExtendedInfo IPersistableModel<IaasVmProtectedItemExtendedInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IaasVmProtectedItemExtendedInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeIaasVmProtectedItemExtendedInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(IaasVmProtectedItemExtendedInfo)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<IaasVmProtectedItemExtendedInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
