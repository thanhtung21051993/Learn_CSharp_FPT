﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_DotNET.Lab.Lab_4
{
    abstract class GeometricObject
    {
        protected string color;
        protected double weight;
        protected GeometricObject()
        {
            color = "white";
            weight = 1.0;
        }
        protected GeometricObject(string color,double weight)
        {
            this.color = color;
            this.weight = weight;
        }
        public string PColor
        {
            get { return color; }
            set { color = value; }
        }
        public double PWeight
        {
            get { return weight; }
            set { weight = value; }
        }
        public abstract double findArea();
        public abstract double findPerimeter();
    }
}
