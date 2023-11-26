using StoreProject.Application.DTOs.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.Models.Identity
{
    public class AuthResponse
    {
        public string AccessToken { get; set; }
		public string RefreshToken { get; set; }
        public UserDto User { get; set; }
        public DateTime Expiration {  get; set; }

	}
}
