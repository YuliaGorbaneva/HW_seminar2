Console.Write("Введите число от 1 до 7: ");

string s = Console.ReadLine();
int i = int.Parse(s);

if (i == 1){
    Console.WriteLine($"Monday, work");
}
else if (i == 2){
    Console.WriteLine($"Tuesday, work");
}
else if (i == 3){
    Console.WriteLine($"Wednesday, work");
}
else if (i == 4){
    Console.WriteLine($"Thursday, work");
}
else if (i == 5){
    Console.WriteLine($"Friday, work");
}
else if (i == 6){
    Console.WriteLine($"Saturday, day off");
}
else if (i == 7){
    Console.WriteLine($"Sunday, day off");
}
else{
    Console.WriteLine($"not a day of the week");
}