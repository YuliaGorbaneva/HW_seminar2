Console.Write("Введите число от 1 до 7: ");

string s = Console.ReadLine();
int i = int.Parse(s);

if (i <= 5){
    Console.WriteLine("work day");
}
else if (i == 6){
    Console.WriteLine("day off");
}
else if (i == 7){
    Console.WriteLine("day off");
}
else{
    Console.WriteLine("not a day of the week");
}