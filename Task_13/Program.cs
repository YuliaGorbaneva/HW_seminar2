Console.Write("Введите число от 100 до 999: ");
int number = int.Parse(Console.ReadLine());

int last = number % 10;
if (number < 100){
    Console.WriteLine($"no third number");
}
else{
    Console.WriteLine($"{last}");
}
