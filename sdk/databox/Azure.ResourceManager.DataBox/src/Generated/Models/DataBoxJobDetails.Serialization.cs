// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    public partial class DataBoxJobDetails : IUtf8JsonSerializable, IJsonModel<DataBoxJobDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataBoxJobDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DataBoxJobDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxJobDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataBoxJobDetails)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsCollectionDefined(CopyProgress))
            {
                writer.WritePropertyName("copyProgress"u8);
                writer.WriteStartArray();
                foreach (var item in CopyProgress)
                {
                    writer.WriteObjectValue<DataBoxCopyProgress>(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(DevicePassword))
            {
                writer.WritePropertyName("devicePassword"u8);
                writer.WriteStringValue(DevicePassword);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(JobStages))
            {
                writer.WritePropertyName("jobStages"u8);
                writer.WriteStartArray();
                foreach (var item in JobStages)
                {
                    writer.WriteObjectValue<DataBoxJobStage>(item, options);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("contactDetails"u8);
            writer.WriteObjectValue<DataBoxContactDetails>(ContactDetails, options);
            if (Optional.IsDefined(ShippingAddress))
            {
                writer.WritePropertyName("shippingAddress"u8);
                writer.WriteObjectValue<DataBoxShippingAddress>(ShippingAddress, options);
            }
            if (options.Format != "W" && Optional.IsDefined(DeliveryPackage))
            {
                writer.WritePropertyName("deliveryPackage"u8);
                writer.WriteObjectValue<PackageShippingDetails>(DeliveryPackage, options);
            }
            if (options.Format != "W" && Optional.IsDefined(ReturnPackage))
            {
                writer.WritePropertyName("returnPackage"u8);
                writer.WriteObjectValue<PackageShippingDetails>(ReturnPackage, options);
            }
            if (Optional.IsCollectionDefined(DataImportDetails))
            {
                writer.WritePropertyName("dataImportDetails"u8);
                writer.WriteStartArray();
                foreach (var item in DataImportDetails)
                {
                    writer.WriteObjectValue<DataImportDetails>(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(DataExportDetails))
            {
                writer.WritePropertyName("dataExportDetails"u8);
                writer.WriteStartArray();
                foreach (var item in DataExportDetails)
                {
                    writer.WriteObjectValue<DataExportDetails>(item, options);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("jobDetailsType"u8);
            writer.WriteStringValue(JobDetailsType.ToSerialString());
            if (Optional.IsDefined(Preferences))
            {
                writer.WritePropertyName("preferences"u8);
                writer.WriteObjectValue<DataBoxOrderPreferences>(Preferences, options);
            }
            if (Optional.IsDefined(ReverseShippingDetails))
            {
                writer.WritePropertyName("reverseShippingDetails"u8);
                writer.WriteObjectValue<ReverseShippingDetails>(ReverseShippingDetails, options);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(CopyLogDetails))
            {
                writer.WritePropertyName("copyLogDetails"u8);
                writer.WriteStartArray();
                foreach (var item in CopyLogDetails)
                {
                    writer.WriteObjectValue<CopyLogDetails>(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(ReverseShipmentLabelSasKey))
            {
                writer.WritePropertyName("reverseShipmentLabelSasKey"u8);
                writer.WriteStringValue(ReverseShipmentLabelSasKey);
            }
            if (options.Format != "W" && Optional.IsDefined(ChainOfCustodySasKey))
            {
                writer.WritePropertyName("chainOfCustodySasKey"u8);
                writer.WriteStringValue(ChainOfCustodySasKey);
            }
            if (options.Format != "W" && Optional.IsDefined(DeviceErasureDetails))
            {
                writer.WritePropertyName("deviceErasureDetails"u8);
                writer.WriteObjectValue<DeviceErasureDetails>(DeviceErasureDetails, options);
            }
            if (Optional.IsDefined(KeyEncryptionKey))
            {
                writer.WritePropertyName("keyEncryptionKey"u8);
                writer.WriteObjectValue<DataBoxKeyEncryptionKey>(KeyEncryptionKey, options);
            }
            if (Optional.IsDefined(ExpectedDataSizeInTerabytes))
            {
                writer.WritePropertyName("expectedDataSizeInTeraBytes"u8);
                writer.WriteNumberValue(ExpectedDataSizeInTerabytes.Value);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(Actions))
            {
                writer.WritePropertyName("actions"u8);
                writer.WriteStartArray();
                foreach (var item in Actions)
                {
                    writer.WriteStringValue(item.ToSerialString());
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(LastMitigationActionOnJob))
            {
                writer.WritePropertyName("lastMitigationActionOnJob"u8);
                writer.WriteObjectValue<LastMitigationActionOnJob>(LastMitigationActionOnJob, options);
            }
            if (options.Format != "W" && Optional.IsDefined(DataCenterAddress))
            {
                writer.WritePropertyName("datacenterAddress"u8);
                writer.WriteObjectValue<DataCenterAddressResult>(DataCenterAddress, options);
            }
            if (options.Format != "W" && Optional.IsDefined(DataCenterCode))
            {
                writer.WritePropertyName("dataCenterCode"u8);
                writer.WriteStringValue(DataCenterCode.Value.ToString());
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

        DataBoxJobDetails IJsonModel<DataBoxJobDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxJobDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataBoxJobDetails)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataBoxJobDetails(document.RootElement, options);
        }

        internal static DataBoxJobDetails DeserializeDataBoxJobDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<DataBoxCopyProgress> copyProgress = default;
            string devicePassword = default;
            IReadOnlyList<DataBoxJobStage> jobStages = default;
            DataBoxContactDetails contactDetails = default;
            DataBoxShippingAddress shippingAddress = default;
            PackageShippingDetails deliveryPackage = default;
            PackageShippingDetails returnPackage = default;
            IList<DataImportDetails> dataImportDetails = default;
            IList<DataExportDetails> dataExportDetails = default;
            DataBoxOrderType jobDetailsType = default;
            DataBoxOrderPreferences preferences = default;
            ReverseShippingDetails reverseShippingDetails = default;
            IReadOnlyList<CopyLogDetails> copyLogDetails = default;
            string reverseShipmentLabelSasKey = default;
            string chainOfCustodySasKey = default;
            DeviceErasureDetails deviceErasureDetails = default;
            DataBoxKeyEncryptionKey keyEncryptionKey = default;
            int? expectedDataSizeInTerabytes = default;
            IReadOnlyList<CustomerResolutionCode> actions = default;
            LastMitigationActionOnJob lastMitigationActionOnJob = default;
            DataCenterAddressResult dataCenterAddress = default;
            DataCenterCode? dataCenterCode = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("copyProgress"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataBoxCopyProgress> array = new List<DataBoxCopyProgress>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataBoxCopyProgress.DeserializeDataBoxCopyProgress(item, options));
                    }
                    copyProgress = array;
                    continue;
                }
                if (property.NameEquals("devicePassword"u8))
                {
                    devicePassword = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("jobStages"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataBoxJobStage> array = new List<DataBoxJobStage>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataBoxJobStage.DeserializeDataBoxJobStage(item, options));
                    }
                    jobStages = array;
                    continue;
                }
                if (property.NameEquals("contactDetails"u8))
                {
                    contactDetails = DataBoxContactDetails.DeserializeDataBoxContactDetails(property.Value, options);
                    continue;
                }
                if (property.NameEquals("shippingAddress"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    shippingAddress = DataBoxShippingAddress.DeserializeDataBoxShippingAddress(property.Value, options);
                    continue;
                }
                if (property.NameEquals("deliveryPackage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    deliveryPackage = PackageShippingDetails.DeserializePackageShippingDetails(property.Value, options);
                    continue;
                }
                if (property.NameEquals("returnPackage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    returnPackage = PackageShippingDetails.DeserializePackageShippingDetails(property.Value, options);
                    continue;
                }
                if (property.NameEquals("dataImportDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataImportDetails> array = new List<DataImportDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Models.DataImportDetails.DeserializeDataImportDetails(item, options));
                    }
                    dataImportDetails = array;
                    continue;
                }
                if (property.NameEquals("dataExportDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataExportDetails> array = new List<DataExportDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Models.DataExportDetails.DeserializeDataExportDetails(item, options));
                    }
                    dataExportDetails = array;
                    continue;
                }
                if (property.NameEquals("jobDetailsType"u8))
                {
                    jobDetailsType = property.Value.GetString().ToDataBoxOrderType();
                    continue;
                }
                if (property.NameEquals("preferences"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    preferences = DataBoxOrderPreferences.DeserializeDataBoxOrderPreferences(property.Value, options);
                    continue;
                }
                if (property.NameEquals("reverseShippingDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    reverseShippingDetails = ReverseShippingDetails.DeserializeReverseShippingDetails(property.Value, options);
                    continue;
                }
                if (property.NameEquals("copyLogDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<CopyLogDetails> array = new List<CopyLogDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Models.CopyLogDetails.DeserializeCopyLogDetails(item, options));
                    }
                    copyLogDetails = array;
                    continue;
                }
                if (property.NameEquals("reverseShipmentLabelSasKey"u8))
                {
                    reverseShipmentLabelSasKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("chainOfCustodySasKey"u8))
                {
                    chainOfCustodySasKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("deviceErasureDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    deviceErasureDetails = DeviceErasureDetails.DeserializeDeviceErasureDetails(property.Value, options);
                    continue;
                }
                if (property.NameEquals("keyEncryptionKey"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    keyEncryptionKey = DataBoxKeyEncryptionKey.DeserializeDataBoxKeyEncryptionKey(property.Value, options);
                    continue;
                }
                if (property.NameEquals("expectedDataSizeInTeraBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expectedDataSizeInTerabytes = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("actions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<CustomerResolutionCode> array = new List<CustomerResolutionCode>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString().ToCustomerResolutionCode());
                    }
                    actions = array;
                    continue;
                }
                if (property.NameEquals("lastMitigationActionOnJob"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastMitigationActionOnJob = LastMitigationActionOnJob.DeserializeLastMitigationActionOnJob(property.Value, options);
                    continue;
                }
                if (property.NameEquals("datacenterAddress"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataCenterAddress = DataCenterAddressResult.DeserializeDataCenterAddressResult(property.Value, options);
                    continue;
                }
                if (property.NameEquals("dataCenterCode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataCenterCode = new DataCenterCode(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DataBoxJobDetails(
                jobStages ?? new ChangeTrackingList<DataBoxJobStage>(),
                contactDetails,
                shippingAddress,
                deliveryPackage,
                returnPackage,
                dataImportDetails ?? new ChangeTrackingList<DataImportDetails>(),
                dataExportDetails ?? new ChangeTrackingList<DataExportDetails>(),
                jobDetailsType,
                preferences,
                reverseShippingDetails,
                copyLogDetails ?? new ChangeTrackingList<CopyLogDetails>(),
                reverseShipmentLabelSasKey,
                chainOfCustodySasKey,
                deviceErasureDetails,
                keyEncryptionKey,
                expectedDataSizeInTerabytes,
                actions ?? new ChangeTrackingList<CustomerResolutionCode>(),
                lastMitigationActionOnJob,
                dataCenterAddress,
                dataCenterCode,
                serializedAdditionalRawData,
                copyProgress ?? new ChangeTrackingList<DataBoxCopyProgress>(),
                devicePassword);
        }

        BinaryData IPersistableModel<DataBoxJobDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxJobDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataBoxJobDetails)} does not support writing '{options.Format}' format.");
            }
        }

        DataBoxJobDetails IPersistableModel<DataBoxJobDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxJobDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataBoxJobDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataBoxJobDetails)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataBoxJobDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
