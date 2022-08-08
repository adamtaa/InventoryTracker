using InventoryTracking.business.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace InventoryTracking.business.Handlers.Search
{
    [DataContract]
    public class SearchResponse : List<InventoryItemModel>
    {

    }
}
