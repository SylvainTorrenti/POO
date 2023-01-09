using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationRectangle
{
    internal class Rectangle
    {
        public double Largeur;
        public double Hauteur;

        public double Surface()
        {
            return Largeur * Hauteur;
        }
    }
}
