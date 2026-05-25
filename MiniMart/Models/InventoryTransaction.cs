using MiniMart.Models.Base;
using MiniMart.Models.Enums;

namespace MiniMart.Models
{
    public class InventoryTransaction : BaseEntity
    {
        public int InventoryTransactionId { get; set; }

        public InventoryTransactionType TransactionType { get; set; }

        public int Quantity { get; set; }

        public int PreviousStock { get; set; }

        public int CurrentStock { get; set; }

        public string? ReferenceType { get; set; }

        public int? ReferenceId { get; set; }

        public string? Note { get; set; }

        public int ProductId { get; set; }

        public Product Product { get; set; }

        public int? BatchId { get; set; }

        public Batch? Batch { get; set; }

        public int EmployeeId { get; set; }

        public Employee Employee { get; set; }
    }
}