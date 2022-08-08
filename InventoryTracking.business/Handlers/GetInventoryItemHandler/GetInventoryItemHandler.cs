using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InventoryTracking.business.Handlers.GetInventoryItemHandler
{
    public class GetInventoryItemHandler : IRequestHandler<GetInventoryItemRequest, GetInventoryItemResponse>
    {
        Task<GetInventoryItemResponse> IRequestHandler<GetInventoryItemRequest, GetInventoryItemResponse>.Handle(GetInventoryItemRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
