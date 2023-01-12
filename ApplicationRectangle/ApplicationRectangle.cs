using ApplicationRectangle;

#region Create Recutangle
Rectangle Rect1 = new Rectangle();
Rectangle Rect2 = new Rectangle();
#endregion
#region Use Set
Rect1.Largeur = 12.5;
Rect1.Hauteur = 5.5;
Rect2.Largeur = 4;
Rect2.Hauteur = 17.3; 
#endregion
#region Use Get
Console.WriteLine(Rect1.Hauteur);
Console.WriteLine(Rect1.Largeur); 
#endregion
#region Use method
Console.WriteLine($"Surface du rectangle {Rect1.Surface()}");
Console.WriteLine($"Surface du rectangle {Rect2.Surface()}"); 
#endregion