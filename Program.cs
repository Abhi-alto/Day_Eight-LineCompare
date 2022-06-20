using Line_comparasion;
Console.WriteLine("Welcome to Line Comparison Computation Program on Master Branch");
double l1 = Line.length(1);
double l2 = Line.length(2);
if (l1 == l2)
    Console.WriteLine("Equal Lines");
else if(l1>l2)
    Console.WriteLine("Line 1 is greater in length than Line 2");
else
    Console.WriteLine("Line 2 is greater in length than Line 1");
