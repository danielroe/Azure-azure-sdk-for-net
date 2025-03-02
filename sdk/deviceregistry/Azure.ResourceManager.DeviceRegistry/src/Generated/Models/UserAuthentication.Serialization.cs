// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DeviceRegistry.Models
{
    public partial class UserAuthentication : IUtf8JsonSerializable, IJsonModel<UserAuthentication>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<UserAuthentication>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<UserAuthentication>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UserAuthentication>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(UserAuthentication)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("mode"u8);
            writer.WriteStringValue(Mode.ToString());
            if (Optional.IsDefined(UsernamePasswordCredentials))
            {
                writer.WritePropertyName("usernamePasswordCredentials"u8);
                writer.WriteObjectValue<UsernamePasswordCredentials>(UsernamePasswordCredentials, options);
            }
            if (Optional.IsDefined(X509Credentials))
            {
                writer.WritePropertyName("x509Credentials"u8);
                writer.WriteObjectValue<X509Credentials>(X509Credentials, options);
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

        UserAuthentication IJsonModel<UserAuthentication>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UserAuthentication>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(UserAuthentication)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeUserAuthentication(document.RootElement, options);
        }

        internal static UserAuthentication DeserializeUserAuthentication(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            UserAuthenticationMode mode = default;
            UsernamePasswordCredentials usernamePasswordCredentials = default;
            X509Credentials x509Credentials = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("mode"u8))
                {
                    mode = new UserAuthenticationMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("usernamePasswordCredentials"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    usernamePasswordCredentials = UsernamePasswordCredentials.DeserializeUsernamePasswordCredentials(property.Value, options);
                    continue;
                }
                if (property.NameEquals("x509Credentials"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    x509Credentials = X509Credentials.DeserializeX509Credentials(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new UserAuthentication(mode, usernamePasswordCredentials, x509Credentials, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<UserAuthentication>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UserAuthentication>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(UserAuthentication)} does not support writing '{options.Format}' format.");
            }
        }

        UserAuthentication IPersistableModel<UserAuthentication>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UserAuthentication>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeUserAuthentication(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(UserAuthentication)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<UserAuthentication>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
