using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
