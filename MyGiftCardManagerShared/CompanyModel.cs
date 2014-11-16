using System;

namespace MyGiftCardManagerShared
{
	public class CompanyModel
	{
			public String SalonName { set; get; }
			public Address SalonAddress { set; get; }
			public ContactInfo SalonContactInfo { set; get; }
			public Boolean VisaAccepted { get; set; }
			public Boolean MasterCardAccepted { get; set; }
			public Boolean AmericanExpressAccepted { get; set; }
			public Boolean DiscoverAccepted { get; set; }
			public String PayPalID { get; set; }
			public String AuthorizeDotNetAPILoginID { get; set; }
			public String AuthorizeDotNetPassword { get; set; }
			public Boolean AuthorizeDotNetLive { get; set; }
			public Boolean? AllowMailOption { get; set; }
			public Boolean? AllowGratuity { get; set; }
			public Double? ShippingCost { get; set; }
			public Int16? ExpireAfterDays { get; set; }
			public String FinePrint { get; set; }

			[System.Runtime.Serialization.OnDeserialized]
			void OnDeserialized(System.Runtime.Serialization.StreamingContext c)
			{
				AllowGratuity = (AllowGratuity == null ? false : AllowGratuity);
				AllowMailOption = (AllowMailOption == null ? false : AllowMailOption);
				ExpireAfterDays = (ExpireAfterDays == null ? 0 : ExpireAfterDays);
			}
	}
	public partial class ContactInfo
	{
		public String FirstName { set; get; }
		public String LastName { set; get; }
		public String Phone { set; get; }
		public String Fax { set; get; }
		public String Email { set; get; }
		public String Wedsite { set; get; }
	}
	public partial class Address
	{
		public String AddressOne { set; get; }
		public String AddressTwo { set; get; }
		public String City { set; get; }
		public String State { set; get; }
		public String Zip { set; get; }
		public String County { set; get; }
	}
	public partial class CurrentSalonDisplaySettings
	{
		public String SalonName { get; set; }
		public String CurrentThemeName { set; get; }
		public Boolean? LogoUploaded { set; get; }
		[System.Runtime.Serialization.OnDeserialized]
		void OnDeserialized(System.Runtime.Serialization.StreamingContext c)
		{
			LogoUploaded = (LogoUploaded == null ? false : LogoUploaded);
		}
	}

	public class UploadedFile
	{
		public string FilePath { get; set; }

		public string FileLength { get; set; }

		public string FileName { get; set; }

		public int Height { get; set; }

		public int Width { get; set; }
	}  
}

