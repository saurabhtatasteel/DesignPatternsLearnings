﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Strategy
{
    public interface ICompression
    {
        void Compress(string compressedArchiveFileName);
    }
}
