using MediatR;
using StoreProject.Application.CartItems.Requests.Queries;
using StoreProject.Application.Contracts.IReposiotry;
using StoreProject.Application.Contracts.Service;
using StoreProject.Application.DTOs.CartItem;
using StoreProject.Application.Exceptions;
using StoreProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.Auth.Queries.CheckValidToken
{
    public class CheckValidTokenRequestHandler : IRequestHandler<CheckValidTokenRequest, int>
    {
        private readonly IOtpRepository _otpRepository;
        public CheckValidTokenRequestHandler(IOtpRepository otpRepository)
        {
            _otpRepository = otpRepository;
        }
        public async Task<int> Handle(CheckValidTokenRequest request, CancellationToken cancellationToken)
        {
           var otp = _otpRepository.FindPendingOtpByCodeAndEmail(request.OtpToken, request.Email) ?? throw new BadRequestException("Otp is incorrect or expired");
           return otp.Id;
        }
    }
}
