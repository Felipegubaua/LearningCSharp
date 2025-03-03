using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trainning.Programs_Developed {
    class Triangle {

        
        private double x;
        private double y;
        private double z;

        public Triangle(double x, double y, double z) {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public double area() {
            double p = (x + y + z) / 2;
            double area = Math.Sqrt(p * (p - x) * (p - y) * (p - z));
            return area;
        }
    }
}
