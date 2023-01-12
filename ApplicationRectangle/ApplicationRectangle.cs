using ApplicationRectangle;

#region Create Recutangle
Rectangle Rect1 = new Rectangle(15,6);
Rectangle Rect2 = new Rectangle();
#endregion
#region Use Set
Rect2.Width = 4;
Rect2.Height = 17.3; 
#endregion
#region Use Get
Console.WriteLine($"La Largeur est de {Rect1.Width}");
Console.WriteLine($"La Largeur est de {Rect1.Height}");
#endregion
#region Use method
Console.WriteLine($"Surface du rectangle {Rect1.Surface()}");
Console.WriteLine($"Surface du rectangle {Rect2.Surface()}");
Console.WriteLine($"Il y a {Rectangle.RecutangleNb} rectangles créés");
#endregion