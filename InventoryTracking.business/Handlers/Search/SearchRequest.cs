using InventoryTracking.business.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace InventoryTracking.business.Handlers.Search
{
    public class SearchRequest : IRequest<List<InventoryItemModel>>
    {
        public Expression<Func<InventoryItemModel>> filter { get; set; }
    }
}
