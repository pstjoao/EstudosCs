using System;
using ExMetodosAbstratos.Entities.Enums;

namespace ExMetodosAbstratos.Entities {
    internal class Circle : Shape {

        public double Radius { get; set; }

        public Circle(Color color, double radius) : base(color) {
            Radius = radius;
        }

        public override double Area() {
            return Radius * Radius * Math.PI;
        }
    }
}
