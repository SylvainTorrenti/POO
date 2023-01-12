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
        private double _width;
        private double _height;
        #endregion
        #region Constructor
        /// <summary>
        /// Base constructor
        /// </summary>
        public Rectangle()
        {
        }
        /// <summary>
        /// Advanced constructor with width and height
        /// </summary>
        /// <param name="width">Largeur</param>
        /// <param name="height">Hauteur</param>
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }
        #endregion
        #region Get & Set Largeur
        /// <summary>
        /// Width recutangle
        /// </summary>
        public double Width { get => _width; set => _width = value; }
        #endregion
        #region Get & Set Hauteur     
        /// <summary>
        /// Height of Recutangle
        /// </summary>
        public double Height { get => _height; set => _height = value; }
        #endregion
        #region Method
        public double Surface()
        {
            return Largeur * Hauteur;
        }
        #endregion
    }
}
