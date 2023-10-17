using AutoMapper;
using Azure.Core;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StoreProject.Application.Constants;
using StoreProject.Application.Contracts.Infrastructure.IReposiotry;
using StoreProject.Application.DTOs.Brand;
using StoreProject.Domain.Entities;
using StoreProject.Infrastructure.Repositories;
using System.Security.Claims;

namespace StoreProject.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CartController : ControllerBase
    {
        private readonly IMediator _mediator;
  

        public CartController(IMediator mediator, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult> Post()
        {
            string userId = User.FindFirst(CustomClaimTypes.Uid)?.Value;

           

            return Ok();
        }
    }
}
