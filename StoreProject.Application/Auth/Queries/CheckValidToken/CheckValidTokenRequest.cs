using MediatR;
using StoreProject.Application.DTOs.CartItem;
using StoreProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.Auth.Queries.CheckValidToken
{
    public class CheckValidTokenRequest : IRequest<int>
    {
        public int OtpToken { get; set; }
        public string Email { get; set; }
    }
}
