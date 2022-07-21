using LineComparisonComputation;

CalculateLength line1 = new CalculateLength(); //object is created 
CalculateLength line2 = new CalculateLength(); //object is created 
double length1 = line1.Length(); // calling the function and storing the returned value 
double length2 = line2.Length(); //calling the function again with different object and storing the returned value 
Console.WriteLine("The Equals method ans is : "+length1.Equals(length2)); // using Equals method we are checking the equality of two lines and returns true if both length are same or else false
Console.WriteLine("The CompareTo method ans is : "+length1.CompareTo(length2)); // using CompareTo method we are comparing 2 lines
                                           // if line 1 is less than line 2 then -1 value is printed
                                           // if line 1 is greater than line 2 then 1 value is printed
                                           // if line 1 is equals to line 2 then 0 value is printed