// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.StoragePool.Models
{
    public partial class DiskPoolIscsiTargetPatch : IUtf8JsonSerializable, IJsonModel<DiskPoolIscsiTargetPatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DiskPoolIscsiTargetPatch>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DiskPoolIscsiTargetPatch>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DiskPoolIscsiTargetPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DiskPoolIscsiTargetPatch)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ManagedBy))
            {
                writer.WritePropertyName("managedBy"u8);
                writer.WriteStringValue(ManagedBy);
            }
            if (Optional.IsCollectionDefined(ManagedByExtended))
            {
                writer.WritePropertyName("managedByExtended"u8);
                writer.WriteStartArray();
                foreach (var item in ManagedByExtended)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(StaticAcls))
            {
                writer.WritePropertyName("staticAcls"u8);
                writer.WriteStartArray();
                foreach (var item in StaticAcls)
                {
                    writer.WriteObjectValue<DiskPoolIscsiTargetPortalGroupAcl>(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Luns))
            {
                writer.WritePropertyName("luns"u8);
                writer.WriteStartArray();
                foreach (var item in Luns)
                {
                    writer.WriteObjectValue<ManagedDiskIscsiLun>(item, options);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
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

        DiskPoolIscsiTargetPatch IJsonModel<DiskPoolIscsiTargetPatch>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DiskPoolIscsiTargetPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DiskPoolIscsiTargetPatch)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDiskPoolIscsiTargetPatch(document.RootElement, options);
        }

        internal static DiskPoolIscsiTargetPatch DeserializeDiskPoolIscsiTargetPatch(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string managedBy = default;
            IList<string> managedByExtended = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            IList<DiskPoolIscsiTargetPortalGroupAcl> staticAcls = default;
            IList<ManagedDiskIscsiLun> luns = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("managedBy"u8))
                {
                    managedBy = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("managedByExtended"u8))
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
                    managedByExtended = array;
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("staticAcls"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<DiskPoolIscsiTargetPortalGroupAcl> array = new List<DiskPoolIscsiTargetPortalGroupAcl>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DiskPoolIscsiTargetPortalGroupAcl.DeserializeDiskPoolIscsiTargetPortalGroupAcl(item, options));
                            }
                            staticAcls = array;
                            continue;
                        }
                        if (property0.NameEquals("luns"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ManagedDiskIscsiLun> array = new List<ManagedDiskIscsiLun>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ManagedDiskIscsiLun.DeserializeManagedDiskIscsiLun(item, options));
                            }
                            luns = array;
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DiskPoolIscsiTargetPatch(
                id,
                name,
                type,
                systemData,
                managedBy,
                managedByExtended ?? new ChangeTrackingList<string>(),
                staticAcls ?? new ChangeTrackingList<DiskPoolIscsiTargetPortalGroupAcl>(),
                luns ?? new ChangeTrackingList<ManagedDiskIscsiLun>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DiskPoolIscsiTargetPatch>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DiskPoolIscsiTargetPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DiskPoolIscsiTargetPatch)} does not support writing '{options.Format}' format.");
            }
        }

        DiskPoolIscsiTargetPatch IPersistableModel<DiskPoolIscsiTargetPatch>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DiskPoolIscsiTargetPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDiskPoolIscsiTargetPatch(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DiskPoolIscsiTargetPatch)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DiskPoolIscsiTargetPatch>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
