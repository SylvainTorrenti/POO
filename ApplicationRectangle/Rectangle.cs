using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationRectangle
{
    internal class Rectangle
    {
        #region Attribute
        private static int _RecutangleNb = 0;
        private double _width;
        private double _height;
        #endregion
        #region Constructor
        /// <summary>
        /// Base constructor
        /// </summary>
        public Rectangle()
        {
            RecutangleNb++;
        }
        /// <summary>
        /// Advanced constructor with width and height
        /// </summary>
        /// <param name="width">Largeur</param>
        /// <param name="height">Hauteur</param>
        public Rectangle(double width, double height)
        {
            RecutangleNb++;
            Width = width;
            Height = height;
        }
        #endregion
        #region Get & Set RecutangleNb
        public static int RecutangleNb { get => _RecutangleNb; set => _RecutangleNb = value; } 
        #endregion
        #region Get & Set Width
        /// <summary>
        /// Width recutangle
        /// </summary>
        public double Width { get => _width; set => _width = value; }
        #endregion
        #region Get & Set Height     
        /// <summary>
        /// Height of Recutangle
        /// </summary>
        public double Height { get => _height; set => _height = value; }
        #endregion
        #region Method
        public double Surface()
        {
            return Width * Height;
        }
        #endregion
    }
}
