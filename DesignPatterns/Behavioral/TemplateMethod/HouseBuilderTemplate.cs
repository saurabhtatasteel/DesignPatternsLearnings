namespace DesignPatterns.Structural.Template
{
	public abstract class HouseBuilderTemplate
    {

        public void Build()
        {
            MakeFoundation();
            MakePillars();
            MakeWalls();
        }

        public abstract void MakeFoundation();
        public abstract void MakePillars();
        public abstract void MakeWalls();

    }
}
