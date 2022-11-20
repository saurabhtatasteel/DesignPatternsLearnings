namespace DesignPatterns.Structural.Strategy
{
	public static class StrategyClient
    {
        public static void TestClient()
        {
            CompressionStrategy compressionStrategy = new CompressionStrategy(new ZipCompression());
            compressionStrategy.Compress("zipfile");
            compressionStrategy.SetCompressionStrategy(new RarCompression());
            compressionStrategy.Compress("rarfile");
        }
    }
}
