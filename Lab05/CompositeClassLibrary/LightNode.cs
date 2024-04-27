﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeClassLibrary
{
    public abstract class LightNode
    {
        public abstract string OuterHTML { get; }

        public abstract string InnerHTML { get; }
        public abstract string Display(int depth);
    }
}
