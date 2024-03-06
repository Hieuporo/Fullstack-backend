using Microsoft.AspNetCore.Identity;
using StoreProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Domain.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public string Address { get; set; }
        public string? FirstName { get; set; }
		public string? LastName { get; set; }
		public string? AvatarUrl { get; set; }
        
        // refreshtoken
        public string? RefreshToken {  get; set; }
        public DateTime RefreshTokenExpiry {  get; set; }

		public DateTime? LastLogin { get; set; }
		public ICollection<Cart> Carts { get; set; }

    }
}
