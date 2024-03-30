using Amazon.Runtime.Internal;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.Auth.Commands.RevokeToken
{
    public class RevokeTokenCommand : IRequest<Unit>
    {
    }
}
