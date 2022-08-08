using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InventoryTracking.business.Handlers.DeleteInventoryItem
{
    public class DeleteInventoryItemHandler : IRequestHandler<DeleteInventoryItemRequest, string>
    {
        Task<string> IRequestHandler<DeleteInventoryItemRequest, string>.Handle(DeleteInventoryItemRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
