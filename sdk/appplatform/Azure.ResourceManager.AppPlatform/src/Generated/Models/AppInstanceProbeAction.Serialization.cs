// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    [PersistableModelProxy(typeof(UnknownProbeAction))]
    public partial class AppInstanceProbeAction : IUtf8JsonSerializable, IJsonModel<AppInstanceProbeAction>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AppInstanceProbeAction>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AppInstanceProbeAction>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppInstanceProbeAction>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppInstanceProbeAction)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(ProbeActionType.ToString());
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

        AppInstanceProbeAction IJsonModel<AppInstanceProbeAction>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppInstanceProbeAction>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppInstanceProbeAction)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAppInstanceProbeAction(document.RootElement, options);
        }

        internal static AppInstanceProbeAction DeserializeAppInstanceProbeAction(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "ExecAction": return AppInstanceExecAction.DeserializeAppInstanceExecAction(element, options);
                    case "HTTPGetAction": return AppInstanceHttpGetAction.DeserializeAppInstanceHttpGetAction(element, options);
                    case "TCPSocketAction": return AppInstanceTcpSocketAction.DeserializeAppInstanceTcpSocketAction(element, options);
                }
            }
            return UnknownProbeAction.DeserializeUnknownProbeAction(element, options);
        }

        BinaryData IPersistableModel<AppInstanceProbeAction>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppInstanceProbeAction>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AppInstanceProbeAction)} does not support writing '{options.Format}' format.");
            }
        }

        AppInstanceProbeAction IPersistableModel<AppInstanceProbeAction>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppInstanceProbeAction>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAppInstanceProbeAction(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AppInstanceProbeAction)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AppInstanceProbeAction>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
