// Решение, которое наиболее эффективно и при этом способно пройти любой кейс (полностью сам сделал)
void Task(int index, string? number){
    if (!(Int32.TryParse(number, out int n))||(Convert.ToInt32(number) >= 0 && number!.Length < index)||(Convert.ToInt32(number) < 0 && number!.Length<index+1)){Console.WriteLine($"нет {index} числа или не верный ввод");}
    else{
        if(number.Contains("-"))Console.WriteLine(number[index]);
        else Console.WriteLine(number[index-1]);
    }
}
//First Task
string? number = Console.ReadLine();
Task(2,number);
//Second Task
string? number0 = Console.ReadLine();
Task(3,number0);
//The third digit from the right
string? number1 = Console.ReadLine();
Task(number1!.Length-2,number1);
//Third Task
string[]workDays={"1","2","3","4","5"};
string[]weekEndDays={"6","7"};
string? day_num = Console.ReadLine();
if(workDays.Contains(day_num)){
    Console.WriteLine("НЕТ");
}else if(weekEndDays.Contains(day_num)){
    Console.WriteLine("ДА");
}else{
    Console.WriteLine("Не верный ввод");
}
// Решение которое ожидается:
// //First Task
// int number = Convert.ToInt32(Console.ReadLine());
// if(number<1000 && number>99){
//     Console.WriteLine((number%100)/10);
// }else{
//     Console.WriteLine("Число не является трёхзначным");
// }
// //Second Task
// int number0 = Convert.ToInt32(Console.ReadLine());
// if (number0<10000000 && number0 > 999999){
//     Console.WriteLine((number0/10000)%10);
// }else{
//     Console.WriteLine("третьей цифры нет");
// }
// //The third digit from the right
// int number1 = Convert.ToInt32(Console.ReadLine());
// if(number1<10000000 && number1 > 999999){
//     Console.WriteLine((number1/100)%10);
// }else{
//     Console.WriteLine("третьей цифры с конца нет");
// }
// //Third Task
// int number2 = Convert.ToInt32(Console.ReadLine());
// if (number2 == 6 || number2 == 7){
//     Console.WriteLine("ДА");
// }else if(number2 > 0 && number2 < 6){
//     Console.WriteLine("НЕТ");
// }else{
//     Console.WriteLine("Нет такого дня недели");
// }