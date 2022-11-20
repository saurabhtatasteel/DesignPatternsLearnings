using System;

namespace DesignPatterns.Creational.Prototype
{
	public static class PrototypeClient
	{
		public static IPrototype GetShallowPrototype()
		{
			var prototype = new StudentShallowClonePrototype();
			prototype.Id = 1;
			prototype.Name = "TestName";
			prototype.Address = new Address()
			{
				Address1 = "Add1",
				Address2 = "Add2",

				CityDetails = new CityDetails()
				{
					City = "city",
					PostalCode = "34323",
					State = "MH"
				}
			};
			Console.WriteLine(string.Format("Shallow clone test : Original prototype city : {0}", prototype.Address.CityDetails.City));
			IPrototype newProtoType = prototype.PrototypeClone();
			var newProto = newProtoType as StudentShallowClonePrototype;
			newProto.Id = 4;
			newProto.Address.CityDetails.City = "New city";
			Console.WriteLine(string.Format("Shallow clone test : New prototype city : {0}", newProto.Address.CityDetails.City));
			Console.WriteLine(string.Format("Shallow clone test : Original prototype after changing city : {0}", prototype.Address.CityDetails.City));
			return newProtoType;
		}

		public static IPrototype GetDeepPrototype()
		{
			var prototype = new StudentDeepClonePrototype();
			prototype.Id = 1;
			prototype.Name = "TestName";
			prototype.Address = new Address()
			{
				Address1 = "Add1",
				Address2 = "Add2",

				CityDetails = new CityDetails()
				{
					City = "city",
					PostalCode = "34323",
					State = "MH"
				}
			};
			Console.WriteLine(string.Format("Deep clone test : Original prototype city : {0}", prototype.Address.CityDetails.City));

			IPrototype newProtoType = prototype.PrototypeClone();
			var newProto = newProtoType as StudentDeepClonePrototype;
			(newProtoType as StudentDeepClonePrototype).Address.CityDetails.City = "New City";
			Console.WriteLine(string.Format("Deep clone test : New prototype city : {0}", newProto.Address.CityDetails.City));
			Console.WriteLine(string.Format("Deep clone test : Original prototype after changing city : {0}", prototype.Address.CityDetails.City));

			return newProtoType as IPrototype;
		}
	}
}
