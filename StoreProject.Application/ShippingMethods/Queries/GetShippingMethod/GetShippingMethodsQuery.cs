using MediatR;
using StoreProject.Application.DTOs.ShippingMethod;

namespace StoreProject.Application.ShippingMethods.Queries.GetShippingMethod
{
    public class GetShippingMethodsQuery :IRequest<List<ShippingMethodDto>>
    {
    }
}
