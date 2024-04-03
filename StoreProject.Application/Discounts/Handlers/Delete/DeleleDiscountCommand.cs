using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.Discounts.Handlers.Delete
{
    public class DeleleDiscountCommand : IRequest<Unit>
    {
        public int Id { get; set; }
    }
}
