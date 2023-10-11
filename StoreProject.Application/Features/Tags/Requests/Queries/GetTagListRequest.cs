using MediatR;
using StoreProject.Application.DTOs.Tag;
using StoreProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.Features.Tags.Requests.Queries
{
    public class GetTagListRequest : IRequest<List<TagDto>>
    {
    }
}
