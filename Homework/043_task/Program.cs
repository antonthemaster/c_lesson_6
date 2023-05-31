Console.Write("Enter a value of k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter a value of b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter a value of k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter a value of b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

double x = -(k1 - k2)/(b1-b2);
double y = b1 * x + k1;


Console.WriteLine($"({x},{y})");



