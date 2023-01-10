using ApplicationRectangle;

#region Create recutangle
Rectangle Rect1 = new Rectangle();
Rect1.SetLargeur(12.5);
Rect1.SetHauteur(5.5);

Rectangle Rect2 = new Rectangle();
Rect2.SetLargeur(4);
Rect2.SetHauteur(17.3);
#endregion


#region Use Get Set
Console.WriteLine($"Hauteur du rectangle 1 {Rect1.GetHauteur()}");
Console.WriteLine(Rect2.GetHauteur()); 
#endregion
#region Use method
Console.WriteLine($"Surface du rectangle {Rect1.Surface()}");
Console.WriteLine($"Surface du rectangle {Rect2.Surface()}"); 
#endregion


