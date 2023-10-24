using AutoMapper;
using MediatR;
using StoreProject.Application.Contracts.Infrastructure.IReposiotry;
using StoreProject.Application.DTOs.Tag;
using StoreProject.Application.DTOs.Coupon;
using StoreProject.Application.Features.Tags.Requests.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.Features.Tags.Handlers.Queries
{
    public class GetTagRequestHandler : IRequestHandler<GetTagRequest, TagDto>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetTagRequestHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<TagDto> Handle(GetTagRequest request, CancellationToken cancellationToken)
        {
            var tag = await _unitOfWork.TagRepository.Get(request.Id);
            return _mapper.Map<TagDto>(tag);
        }
    }
}
