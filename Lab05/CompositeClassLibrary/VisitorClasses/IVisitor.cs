﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeClassLibrary.VisitorClasses
{
    public interface IVisitor
    {
        public void Visit(LightTextNode lightTextNode);
        public void Visit(LightElementNode lightElementNode);
    }
}
