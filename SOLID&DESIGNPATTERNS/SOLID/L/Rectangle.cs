﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_DESIGNPATTERNS.SOLID.L
{
    public class Rectangle : Shape
    {
        public virtual double Width { get; set; }
        public virtual double Height { get; set; }

        public override double Area => Width * Height; 
    }
}
