using System;

namespace MyGiftCardManagerShared
{
	public class PendingOrderModel
	{
		public String OrderNumber { get; set; }
		public String OrderDate { get; set; }
		public String Purchaser { get; set; }
		public String Recipient { get; set; }
		public Double Total { get; set; }
		public String Status { get; set; }
		public String Actions { get; set; }
		public String SalonName { get; set; }
	}

	public class ProcessedOrders : PendingOrders
	{
		public String[] ItemsOrderedList { get; set; }
		public Double ShippingAndHandling { get; set; }
		public Double Tip { get; set; }
	}
	public class RedeemeddOrders : ProcessedOrders
	{
		public String DateRedeemed { get; set; }
	}
	public class CreditCardInfo
	{
		public String CardType { get; set; }
		public String CardNumber { get; set; }
		public String ExpirationDate { get; set; }
		public String CardCode { get; set; }
	}
	public class OrderDetail : RedeemeddOrders
	{
		public String Message { get; set; }
		public String DeliverBy { get; set; }
		public String BillingInfo { get; set; }
		public String Email { get; set; }
		public CreditCardInfo CardInfo { get; set; }
		public String ProcessedOn { get; set; }
		public String AuthenticationCode { get; set; }
	}

}

