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
            Largeur = width;
            Hauteur = height;
        } 
        #endregion
        #region Get & Set Largeur
        /// <summary>
        /// La Largeur du rectangle
        /// </summary>
        public double Largeur { get => _Largeur; set => _Largeur = value; }
        #endregion
        #region Get & Set Hauteur     
        /// <summary>
        /// La Hauteur du Rectangle
        /// </summary>
        public double Hauteur { get => _Hauteur; set => _Hauteur = value; } 
        #endregion
        #region Method
        public double Surface()
        {
            return Largeur * Hauteur;
        }
        #endregion
    }
}
