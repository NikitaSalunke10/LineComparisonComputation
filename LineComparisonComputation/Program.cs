double x1 = 3, x2 = 4, y1 = 4, y2 =3;
double x3 = 3, x4 = 4, y3 = 4, y4 = 3;
double line1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
double line2 = Math.Sqrt(Math.Pow(x4 - x3, 2) + Math.Pow(y4 - y3, 2));
Console.WriteLine(line1.CompareTo(line2));