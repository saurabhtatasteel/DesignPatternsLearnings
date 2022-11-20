namespace DesignPatterns.Creational.Prototype
{
	public class StudentShallowClonePrototype : IPrototype
	{
		public string Name { get; set; }
		public int Id { get; set; }
		public Address Address { get; set; }

		public IPrototype PrototypeClone()
		{
			// Shallow Copy: only top-level objects are duplicated
			return (IPrototype)MemberwiseClone();
		}

		
	}
}
