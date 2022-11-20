namespace DesignPatterns.Structural.Strategy
{
	public class CompressionStrategy
    {
        private ICompression _compressionStrategy;

        public CompressionStrategy(ICompression compressionStrategy)
        {
            _compressionStrategy = compressionStrategy;
        }

        public void SetCompressionStrategy(ICompression compressionStrategy)
        {
            _compressionStrategy = compressionStrategy;
        }

        public void Compress(string compressionFileName)
        {
            _compressionStrategy.Compress(compressionFileName);
        }

    }
}
