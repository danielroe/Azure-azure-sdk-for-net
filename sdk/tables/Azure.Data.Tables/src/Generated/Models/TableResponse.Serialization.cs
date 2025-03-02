// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;

namespace Azure.Data.Tables.Models
{
    internal partial class TableResponse
    {
        internal static TableResponse DeserializeTableResponse(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string odataMetadata = default;
            string tableName = default;
            string odataType = default;
            string odataId = default;
            string odataEditLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("odata.metadata"u8))
                {
                    odataMetadata = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("TableName"u8))
                {
                    tableName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("odata.type"u8))
                {
                    odataType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("odata.id"u8))
                {
                    odataId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("odata.editLink"u8))
                {
                    odataEditLink = property.Value.GetString();
                    continue;
                }
            }
            return new TableResponse(tableName, odataType, odataId, odataEditLink, odataMetadata);
        }
    }
}
