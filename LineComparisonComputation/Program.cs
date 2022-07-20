using LineComparisonComputation;

CalculateLength line1 = new CalculateLength();
CalculateLength line2 = new CalculateLength();
Console.WriteLine(line1.Equals(line2));
//int ans = line1.CompareTo(line2);
//Console.WriteLine(line1.CompareTo(line2)); // using CompareTo method we are comparing 2 lines
                                           // if line 1 is less than line 2 then -1 value is printed
                                           // if line 1 is greater than line 2 then 1 value is printed
                                           // if line 1 is equals to line 2 then 0 value is printed