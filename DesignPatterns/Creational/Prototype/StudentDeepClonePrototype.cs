using System;

namespace DesignPatterns.Creational.Prototype
{
	public class StudentDeepClonePrototype : ICloneable, IPrototype
	{
		public string _name;
		public int _id;
		public Address _address;

		public string Name { get { return _name; } set { _name = value; } }
		public int Id { get { return _id; } set { _id = value; } }
		public Address Address { get { return _address; } set { _address = value; } }

		public IPrototype PrototypeClone()
		{
			return (IPrototype)Clone();
		}

		public object Clone()
		{
			// Deep Copy: all objects are duplicated
			return new StudentDeepClonePrototype()
			{
				Name = _name,
				Id = _id,
				Address = new Address()
				{
					Address1 = _address.Address1,
					Address2 = _address.Address2,
					CityDetails = new CityDetails()
					{
						City = _address.CityDetails.City,
						PostalCode = _address.CityDetails.PostalCode,
						State = _address.CityDetails.State
					}
				}
			};
		}
	}	
}
