int num1  = 0;
int num2 = 0;

Console.WriteLine("Let's divide two numbers now!");
num1 = Convert.ToInt32(Console.ReadLine());
num2  = Convert.ToInt32(Console.ReadLine());

int quotient = num1 / num2;
int mod = num1 % num2;

Console.WriteLine("The quotient is: " + quotient);
Console.WriteLine("The remainder is: " + mod);

