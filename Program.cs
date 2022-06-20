using Line_comparasion;
Console.WriteLine("Welcome to Line Comparison Computation Program on Master Branch");
Console.WriteLine("Enter x1");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter y1");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter x2");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter y2");
double y2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("length of this line is " +Line.length(x1,y1,x2,y2));
