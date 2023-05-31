Console.Write("Enter a quantity of nums: ");
int num_length = Convert.ToInt32(Console.ReadLine());
int result = new int();
for (int i=0; i < num_length; i++){
    Console.Write($"You entered {i} numbers of {num_length}, now enter {i+1} number: ");
    int user_number = Convert.ToInt32(Console.ReadLine());
    if (user_number > 0)
    {
        result++;
    }
}
Console.WriteLine();
Console.WriteLine($"Amount of numbers over 0: {result}");
