namespace DesignPatterns.Creational.Prototype
{
	public interface IPrototype
	{
		IPrototype PrototypeClone();
		
	}
	

	public class Address
	{
		public string Address1 { get; set; }
		public string Address2 { get; set; }
		public CityDetails CityDetails { get; set; }
	}

	public class CityDetails
	{
		public string City { get; set; }
		public string State { get; set; }	
		public string PostalCode { get; set; }	

	}


}
