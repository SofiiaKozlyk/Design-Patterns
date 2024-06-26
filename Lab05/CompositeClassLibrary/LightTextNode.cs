﻿using CompositeClassLibrary.VisitorClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeClassLibrary
{
    public class LightTextNode : LightNode
    {
        private string _text;
        public string Text { get { return _text; } set { _text = value; } }

        public LightTextNode(string text)
        {
            _text = text;
            this.OnCreated();
        }
        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
        public override string Display(int depth)
        {
            return new string(' ', depth) + _text + "\n";
        }
        public override string OuterHTML => _text;

        public override string InnerHTML => _text;

        public override void OnCreated()
        {
            Console.WriteLine($"LightTextNode created.");
        }
        public override void OnInserted()
        {
            Console.WriteLine($"This LightTextNode was inserted into the LightHTML element.");
        }
    }
}
