using StoreProject.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.Contracts.Service
{
    public interface IEmailSender
    {
        Task<bool> SendEmail(Email email);
    }
}
