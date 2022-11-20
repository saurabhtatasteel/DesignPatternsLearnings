using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
