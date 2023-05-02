using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Models
{
    internal class Purchase
    {
        public int Id { get; set; }
        public string ProviderId { get; set; }
        public string PurchaseProductId { get; set; }
        public string PurchasePayMode { get; set; }
        public int TotalPurchase { get; set; }
        public string Observation { get; set; }
    }
}
