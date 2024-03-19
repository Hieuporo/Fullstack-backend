﻿using MediatR;
using StoreProject.Application.Contracts.IReposiotry;
using StoreProject.Application.Exceptions;
using StoreProject.Application.Orders.Requests.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.Orders.Handlers.Commands
{
    public class CompleteOrderCommandHandler : IRequestHandler<CompleteOrderCommand, Unit>
    {
        private readonly IUnitOfWork _unitOfWork;
        public CompleteOrderCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<Unit> Handle(CompleteOrderCommand request, CancellationToken cancellationToken)
        {
            //var order = _unitOfWork.OrderRepository.AdminGetOrderWithDetail(request.Id);
            //if (order == null)
            //{
            //    throw new BadRequestException("Order is not exist");
            //}
            //if (order.Status != OrderStatus.Status_Approved)
            //{
            //    throw new BadRequestException("Order has not been paid yet");
            //}

            //foreach (var orderItem in order.OrderItems)
            //{
            //    if (orderItem.Quantity > orderItem.ProductItem.QuantityInStock)
            //    {
            //        throw new BadRequestException("Quantity of " + orderItem.ProductItem.Name + " is not enough");
            //    }

            //    orderItem.ProductItem.QuantityInStock = orderItem.ProductItem.QuantityInStock - orderItem.Quantity;
            //}

            //order.Status = OrderStatus.Status_Completed;

            //await _unitOfWork.Save();

            return Unit.Value;
        }
    }
}
