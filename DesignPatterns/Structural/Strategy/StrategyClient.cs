using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Strategy
{
    public class StrategyClient
    {
        public void Test()
        {
            CompressionStrategy compressionStrategy = new CompressionStrategy(new ZipCompression());
            compressionStrategy.Compress("zipfile");
            compressionStrategy.SetCompressionStrategy(new RarCompression());
            compressionStrategy.Compress("rarfile");
        }
    }
}
