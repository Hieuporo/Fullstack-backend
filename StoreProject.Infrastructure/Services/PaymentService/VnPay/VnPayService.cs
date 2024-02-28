using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using StoreProject.Application.Contracts.Infrastructure.Payment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Infrastructure.Services.PaymentService.VnPay
{
	public class VnPayService : IVnPayService
	{
		private readonly VnpayConfig vnpayConfig;
		private readonly IHttpContextAccessor _httpContextAccessor;
		public VnPayService(IOptions<VnpayConfig> vnpayConfigOptions, IHttpContextAccessor httpContextAccessor)
        {
			this.vnpayConfig = vnpayConfigOptions.Value;
			_httpContextAccessor = httpContextAccessor;

		}
		public string CreatePayment()
		{
		
			VnPayLibrary vnpay = new VnPayLibrary();

			vnpay.AddRequestData("vnp_Version", VnPayLibrary.VERSION);
			vnpay.AddRequestData("vnp_Command", "pay");
			vnpay.AddRequestData("vnp_TmnCode", vnpayConfig.TmnCode);
			vnpay.AddRequestData("vnp_Amount", (10000000 * 100).ToString()); //Số tiền thanh toán. Số tiền không mang các ký tự phân tách thập phân, phần nghìn, ký tự tiền tệ. Để gửi số tiền thanh toán là 100,000 VND (một trăm nghìn VNĐ) thì merchant cần nhân thêm 100 lần (khử phần thập phân), sau đó gửi sang VNPAY là: 10000000
			//vnpay.AddRequestData("vnp_BankCode", "INTCARD");

			vnpay.AddRequestData("vnp_CreateDate", DateTime.Now.ToString("yyyyMMddHHmmss"));
			vnpay.AddRequestData("vnp_CurrCode", "VND");
			var util = new Utils(_httpContextAccessor);
			vnpay.AddRequestData("vnp_IpAddr", util.GetIpAddress());
			vnpay.AddRequestData("vnp_Locale", "vn");
			vnpay.AddRequestData("vnp_OrderInfo", "Thanh toan don hang:" + 3);
			vnpay.AddRequestData("vnp_OrderType", "other"); //default value: other
			vnpay.AddRequestData("vnp_ReturnUrl", "facebook.com");
			vnpay.AddRequestData("vnp_TxnRef", "1111123"); // Mã tham chiếu của giao dịch tại hệ thống của merchant. Mã này là duy nhất dùng để phân biệt các đơn hàng gửi sang VNPAY. Không được trùng lặp trong ngày

			//Add Params of 2.1.0 Version
			//Billing

			string paymentUrl = vnpay.CreateRequestUrl(vnpayConfig.PaymentUrl, vnpayConfig.HashSecret);
			return paymentUrl;
		}
	}
}
