﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeClassLibrary
{
    public interface IVirusPrototype
    {
        public IVirusPrototype Clone();
    }
}
