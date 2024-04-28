﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeClassLibrary.StateClasses
{
    public class ClickedState : INodeState
    {
        private LightElementNode _lightNode { get; set; }
        public void SetLightNode(LightElementNode lightNode)
        {
            this._lightNode = lightNode;
        }
        public string Handle()
        {
            return $"\x1b[32m{_lightNode.Display(0)}\x1b[0m";
        }
    }
}
