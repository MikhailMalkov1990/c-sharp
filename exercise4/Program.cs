Console.WriteLine("Add first number: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("add second number: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("add third number: ");
int thirdNumber = Convert.ToInt32(Console.ReadLine());

if(firstNumber > secondNumber)
{
    if(firstNumber > thirdNumber)
    {
        Console.WriteLine("max number: " + firstNumber);
    }
    else
    {
        Console.WriteLine("max number: " + thirdNumber);
    }
}
else if (secondNumber > thirdNumber)
{
    Console.WriteLine("max number: " + secondNumber);
}
else 
    {
        Console.WriteLine("max number: " + thirdNumber);
    }
