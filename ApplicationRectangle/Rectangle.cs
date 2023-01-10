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

        private double Largeur;
        private double Hauteur;

        #endregion

        #region Get & Set
        public double GetLargeur()
        {
            return Largeur;
        }
        public void SetLargeur(double Largeur)
        {
            if (Largeur < 0)
            {
                Console.WriteLine("La valeur ne peut pas être <0");
            }
            else
            {
                this.Largeur = Largeur;
            }

        }
        public double GetHauteur()
        {
            return Hauteur;
        }
        public void SetHauteur(double Hauteur)
        {
            if (Hauteur < 0)
            {
                Console.WriteLine("La valeur ne peut pas être <0");
            }
            else
            {
                this.Hauteur = Hauteur;
            }

        } 
        #endregion
        #region Method
        public double Surface()
        {
            return Largeur * Hauteur;
        } 
        #endregion
    }
}
