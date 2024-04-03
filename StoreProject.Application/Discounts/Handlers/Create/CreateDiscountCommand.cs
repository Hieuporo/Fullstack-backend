using MediatR;
using System.ComponentModel.DataAnnotations.Schema;


namespace StoreProject.Application.Discounts.Handlers.Create
{
    public class CreateDiscountCommand : IRequest<int>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal DiscountValue { get; set; }
        public int MinOrderValue { get; set; }
        public string DiscountCode { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int MaxUses { get; set; }
    }
}
