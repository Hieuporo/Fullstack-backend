using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.Auth.Commands.CreatePassword
{
    public class CreatePasswordCommand : IRequest<int>
    {
        public string Email { get; set; }
        public int Token { get; set; }
        public string Password { get; set; }
    }
}
