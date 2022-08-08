using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryTracking.business.Models
{
    public class InventoryItemModel
    {
        public string name { get; set; }
        public int quantity { get; set; }
        public DateTime createdOn { get; set; }
    }
}
