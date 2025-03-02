// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.Maps.Common;

namespace Azure.Maps.Search.Models
{
    internal partial class SearchAlongRouteRequest : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Common.Optional.IsDefined(Route))
            {
                writer.WritePropertyName("route"u8);
                writer.WriteObjectValue<GeoJsonLineString>(Route);
            }
            writer.WriteEndObject();
        }
    }
}
