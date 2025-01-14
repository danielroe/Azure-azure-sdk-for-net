// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.ArcScVmm
{
    internal class ScVmmVirtualNetworkOperationSource : IOperationSource<ScVmmVirtualNetworkResource>
    {
        private readonly ArmClient _client;

        internal ScVmmVirtualNetworkOperationSource(ArmClient client)
        {
            _client = client;
        }

        ScVmmVirtualNetworkResource IOperationSource<ScVmmVirtualNetworkResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = ScVmmVirtualNetworkData.DeserializeScVmmVirtualNetworkData(document.RootElement);
            return new ScVmmVirtualNetworkResource(_client, data);
        }

        async ValueTask<ScVmmVirtualNetworkResource> IOperationSource<ScVmmVirtualNetworkResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = ScVmmVirtualNetworkData.DeserializeScVmmVirtualNetworkData(document.RootElement);
            return new ScVmmVirtualNetworkResource(_client, data);
        }
    }
}
