using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.Models.Identity
{
	public class ResetPasswordRequest
	{
		public string UserId { get; set; }
		public string Token { get; set; }
		public string NewPassword { get; set; }
		public string ConfirmNewPassword { get; set; }
		public bool IsSuccess { get; set; }
	}
}
