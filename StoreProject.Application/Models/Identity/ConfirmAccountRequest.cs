﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.Models.Identity
{
	public class ConfirmAccountRequest
	{
		public string UserId { get; set; }
		public string Token { get; set; }
	}
}
