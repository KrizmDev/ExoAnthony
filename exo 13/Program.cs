using exo_13.Class;

Carre c = new Carre(10, new Point(0, 0));
c.Deplacer(5, 5);
Console.WriteLine(c);


Triangle T = new (10 , 5, new Point(0, 0));
T.Deplacer(9, 2);
Console.WriteLine(T);


Rectangle R = new (25,10, new Point(0, 0));
R.Deplacer(52, 5);
Console.WriteLine(R);