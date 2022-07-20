int x1 = 3, x2 = 4, y1 = 6, y2 =3; // delcared and assigned values for x1, x2 and y1, y2
int x3 = 2, x4 = 7, y3 = 3, y4 = 5; // declared and assigned values for x3, x4 and y3, y4
double line1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)); // calculated the length for line1 i.e for points x1, x2 and y1, y2
double line2 = Math.Sqrt(Math.Pow(x4 - x3, 2) + Math.Pow(y4 - y3, 2)); // calculated the length for line2 i.e for points x3, x4 and y3, y4
Console.WriteLine(line1.Equals(line2)); // using Equals method we are checking the equality of two lines and returns true if both length are same or else false