namespace DesignPatterns.Structural.Template
{
	public static class TemplateMethodClient
    {

        public static void TestClient()
        {
            HouseBuilderTemplate houseBuilderTemplate = new ConcreteHouseBuilder();
            houseBuilderTemplate.Build();


            houseBuilderTemplate = new WoodenHouseBuilder();
            houseBuilderTemplate.Build();
        }
    }
}
