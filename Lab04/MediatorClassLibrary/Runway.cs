﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorClassLibrary
{
    public class Runway
    {
        public readonly Guid Id = Guid.NewGuid();
        public bool IsAvailable { get; set; }
        public Runway()
        {
            IsAvailable = true;
        }
        public void HighLightRed()
        {
            Console.WriteLine($"Runway {this.Id} is busy!");
        }
        public void HighLightGreen()
        {
            Console.WriteLine($"Runway {this.Id} is free!");
        }
    }
}
