using System;

namespace DesignPatterns.Structural.Strategy
{
	public class ZipCompression : ICompression
    {
        public void Compress(string compressedArchiveFileName)
        {
            Console.WriteLine("Compressed " + compressedArchiveFileName + " using zip compression");
        }
    }
}
