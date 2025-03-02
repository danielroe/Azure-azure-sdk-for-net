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
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network
{
    public partial class NetworkVirtualApplianceData : IUtf8JsonSerializable, IJsonModel<NetworkVirtualApplianceData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NetworkVirtualApplianceData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<NetworkVirtualApplianceData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkVirtualApplianceData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkVirtualApplianceData)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity"u8);
                JsonSerializer.Serialize(writer, Identity);
            }
            if (options.Format != "W" && Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W" && Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W" && Optional.IsDefined(ResourceType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType.Value);
            }
            if (Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(Location.Value);
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(NvaSku))
            {
                writer.WritePropertyName("nvaSku"u8);
                writer.WriteObjectValue<VirtualApplianceSkuProperties>(NvaSku, options);
            }
            if (options.Format != "W" && Optional.IsDefined(AddressPrefix))
            {
                writer.WritePropertyName("addressPrefix"u8);
                writer.WriteStringValue(AddressPrefix);
            }
            if (Optional.IsCollectionDefined(BootStrapConfigurationBlobs))
            {
                writer.WritePropertyName("bootStrapConfigurationBlobs"u8);
                writer.WriteStartArray();
                foreach (var item in BootStrapConfigurationBlobs)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(VirtualHub))
            {
                writer.WritePropertyName("virtualHub"u8);
                JsonSerializer.Serialize(writer, VirtualHub);
            }
            if (Optional.IsCollectionDefined(CloudInitConfigurationBlobs))
            {
                writer.WritePropertyName("cloudInitConfigurationBlobs"u8);
                writer.WriteStartArray();
                foreach (var item in CloudInitConfigurationBlobs)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(CloudInitConfiguration))
            {
                writer.WritePropertyName("cloudInitConfiguration"u8);
                writer.WriteStringValue(CloudInitConfiguration);
            }
            if (Optional.IsDefined(VirtualApplianceAsn))
            {
                writer.WritePropertyName("virtualApplianceAsn"u8);
                writer.WriteNumberValue(VirtualApplianceAsn.Value);
            }
            if (Optional.IsDefined(SshPublicKey))
            {
                writer.WritePropertyName("sshPublicKey"u8);
                writer.WriteStringValue(SshPublicKey);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(VirtualApplianceNics))
            {
                writer.WritePropertyName("virtualApplianceNics"u8);
                writer.WriteStartArray();
                foreach (var item in VirtualApplianceNics)
                {
                    writer.WriteObjectValue<VirtualApplianceNicProperties>(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(AdditionalNics))
            {
                writer.WritePropertyName("additionalNics"u8);
                writer.WriteStartArray();
                foreach (var item in AdditionalNics)
                {
                    writer.WriteObjectValue<VirtualApplianceAdditionalNicProperties>(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(InternetIngressPublicIPs))
            {
                writer.WritePropertyName("internetIngressPublicIps"u8);
                writer.WriteStartArray();
                foreach (var item in InternetIngressPublicIPs)
                {
                    JsonSerializer.Serialize(writer, item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(VirtualApplianceSites))
            {
                writer.WritePropertyName("virtualApplianceSites"u8);
                writer.WriteStartArray();
                foreach (var item in VirtualApplianceSites)
                {
                    JsonSerializer.Serialize(writer, item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(VirtualApplianceConnections))
            {
                writer.WritePropertyName("virtualApplianceConnections"u8);
                writer.WriteStartArray();
                foreach (var item in VirtualApplianceConnections)
                {
                    JsonSerializer.Serialize(writer, item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(InboundSecurityRules))
            {
                writer.WritePropertyName("inboundSecurityRules"u8);
                writer.WriteStartArray();
                foreach (var item in InboundSecurityRules)
                {
                    JsonSerializer.Serialize(writer, item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(DeploymentType))
            {
                writer.WritePropertyName("deploymentType"u8);
                writer.WriteStringValue(DeploymentType);
            }
            if (Optional.IsDefined(Delegation))
            {
                writer.WritePropertyName("delegation"u8);
                writer.WriteObjectValue<VirtualApplianceDelegationProperties>(Delegation, options);
            }
            if (Optional.IsDefined(PartnerManagedResource))
            {
                writer.WritePropertyName("partnerManagedResource"u8);
                writer.WriteObjectValue<PartnerManagedResourceProperties>(PartnerManagedResource, options);
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

        NetworkVirtualApplianceData IJsonModel<NetworkVirtualApplianceData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkVirtualApplianceData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkVirtualApplianceData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNetworkVirtualApplianceData(document.RootElement, options);
        }

        internal static NetworkVirtualApplianceData DeserializeNetworkVirtualApplianceData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ManagedServiceIdentity identity = default;
            ETag? etag = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType? type = default;
            AzureLocation? location = default;
            IDictionary<string, string> tags = default;
            VirtualApplianceSkuProperties nvaSku = default;
            string addressPrefix = default;
            IList<string> bootStrapConfigurationBlobs = default;
            WritableSubResource virtualHub = default;
            IList<string> cloudInitConfigurationBlobs = default;
            string cloudInitConfiguration = default;
            long? virtualApplianceAsn = default;
            string sshPublicKey = default;
            IReadOnlyList<VirtualApplianceNicProperties> virtualApplianceNics = default;
            IList<VirtualApplianceAdditionalNicProperties> additionalNics = default;
            IList<WritableSubResource> internetIngressPublicIPs = default;
            IReadOnlyList<WritableSubResource> virtualApplianceSites = default;
            IReadOnlyList<WritableSubResource> virtualApplianceConnections = default;
            IReadOnlyList<WritableSubResource> inboundSecurityRules = default;
            NetworkProvisioningState? provisioningState = default;
            string deploymentType = default;
            VirtualApplianceDelegationProperties delegation = default;
            PartnerManagedResourceProperties partnerManagedResource = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    identity = JsonSerializer.Deserialize<ManagedServiceIdentity>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
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
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
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
                        if (property0.NameEquals("nvaSku"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            nvaSku = VirtualApplianceSkuProperties.DeserializeVirtualApplianceSkuProperties(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("addressPrefix"u8))
                        {
                            addressPrefix = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("bootStrapConfigurationBlobs"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            bootStrapConfigurationBlobs = array;
                            continue;
                        }
                        if (property0.NameEquals("virtualHub"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            virtualHub = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("cloudInitConfigurationBlobs"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            cloudInitConfigurationBlobs = array;
                            continue;
                        }
                        if (property0.NameEquals("cloudInitConfiguration"u8))
                        {
                            cloudInitConfiguration = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("virtualApplianceAsn"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            virtualApplianceAsn = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("sshPublicKey"u8))
                        {
                            sshPublicKey = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("virtualApplianceNics"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<VirtualApplianceNicProperties> array = new List<VirtualApplianceNicProperties>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(VirtualApplianceNicProperties.DeserializeVirtualApplianceNicProperties(item, options));
                            }
                            virtualApplianceNics = array;
                            continue;
                        }
                        if (property0.NameEquals("additionalNics"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<VirtualApplianceAdditionalNicProperties> array = new List<VirtualApplianceAdditionalNicProperties>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(VirtualApplianceAdditionalNicProperties.DeserializeVirtualApplianceAdditionalNicProperties(item, options));
                            }
                            additionalNics = array;
                            continue;
                        }
                        if (property0.NameEquals("internetIngressPublicIps"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<WritableSubResource> array = new List<WritableSubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(JsonSerializer.Deserialize<WritableSubResource>(item.GetRawText()));
                            }
                            internetIngressPublicIPs = array;
                            continue;
                        }
                        if (property0.NameEquals("virtualApplianceSites"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<WritableSubResource> array = new List<WritableSubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(JsonSerializer.Deserialize<WritableSubResource>(item.GetRawText()));
                            }
                            virtualApplianceSites = array;
                            continue;
                        }
                        if (property0.NameEquals("virtualApplianceConnections"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<WritableSubResource> array = new List<WritableSubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(JsonSerializer.Deserialize<WritableSubResource>(item.GetRawText()));
                            }
                            virtualApplianceConnections = array;
                            continue;
                        }
                        if (property0.NameEquals("inboundSecurityRules"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<WritableSubResource> array = new List<WritableSubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(JsonSerializer.Deserialize<WritableSubResource>(item.GetRawText()));
                            }
                            inboundSecurityRules = array;
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new NetworkProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("deploymentType"u8))
                        {
                            deploymentType = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("delegation"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            delegation = VirtualApplianceDelegationProperties.DeserializeVirtualApplianceDelegationProperties(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("partnerManagedResource"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            partnerManagedResource = PartnerManagedResourceProperties.DeserializePartnerManagedResourceProperties(property0.Value, options);
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
            return new NetworkVirtualApplianceData(
                id,
                name,
                type,
                location,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                serializedAdditionalRawData,
                identity,
                etag,
                nvaSku,
                addressPrefix,
                bootStrapConfigurationBlobs ?? new ChangeTrackingList<string>(),
                virtualHub,
                cloudInitConfigurationBlobs ?? new ChangeTrackingList<string>(),
                cloudInitConfiguration,
                virtualApplianceAsn,
                sshPublicKey,
                virtualApplianceNics ?? new ChangeTrackingList<VirtualApplianceNicProperties>(),
                additionalNics ?? new ChangeTrackingList<VirtualApplianceAdditionalNicProperties>(),
                internetIngressPublicIPs ?? new ChangeTrackingList<WritableSubResource>(),
                virtualApplianceSites ?? new ChangeTrackingList<WritableSubResource>(),
                virtualApplianceConnections ?? new ChangeTrackingList<WritableSubResource>(),
                inboundSecurityRules ?? new ChangeTrackingList<WritableSubResource>(),
                provisioningState,
                deploymentType,
                delegation,
                partnerManagedResource);
        }

        BinaryData IPersistableModel<NetworkVirtualApplianceData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkVirtualApplianceData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NetworkVirtualApplianceData)} does not support writing '{options.Format}' format.");
            }
        }

        NetworkVirtualApplianceData IPersistableModel<NetworkVirtualApplianceData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkVirtualApplianceData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNetworkVirtualApplianceData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NetworkVirtualApplianceData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<NetworkVirtualApplianceData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
