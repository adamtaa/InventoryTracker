using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryTracker.Data.Entities
{
    public class InventoryItem
    {
        public string name { get; set; }
        public int quantity { get; set; }
        public DateTime createdOn { get; set; }
    }
}
