using System;

namespace DesignPatterns.Structural.Strategy
{
	public class RarCompression : ICompression
    {
        public void Compress(string compressedArchiveFileName)
        {
            Console.WriteLine("Compressed " + compressedArchiveFileName + " using rar compression");
        }
    }
}
