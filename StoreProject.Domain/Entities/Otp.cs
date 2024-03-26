using StoreProject.Domain.Common;
using StoreProject.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Domain.Entities
{
    public class Otp : BaseDomainEntity
    {
        public long OtpToken { get; set; }
        public string OtpEmail { get; set; }
        public OtpStatus OtpStatus { get; set; }
        public DateTime ExpireAt { get; set; }
    }
}
