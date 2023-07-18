using System.Threading.Channels;
while (true)
{
    Console.WriteLine(" 1.Monday \n 2.Tuesday \n 3.Wednesday \n 4.Thursday \n 5.Friday \n 6.Saturday \n 7.Sunday");
    Console.WriteLine("Select a day to assign Task or any key to exit");


    string insertTask = Console.ReadLine();
    switch (insertTask)
    {
        case "Monday":
            AddToDo("Monday");
            break;

        case "Tuesday":
            AddToDo("Tuesday");
            break;
        case "Wednesday":
            Console.WriteLine("Assessment Day");
            break;
        case "Thursday":
            AddToDo("Thursday");
            break;
        case "Friday":
            AddToDo("Friday");
            break;
        case "Saturday":
            Console.WriteLine("Invaild day");
            break;
        case "Sunday":
            Console.WriteLine("Invalid day");
            break;
        default
            : Console.WriteLine("Exiting...");
            return;
    }
}
void AddToDo(string day)
{
    Console.WriteLine("Enter a task");
    string task = Console.ReadLine();
    Console.WriteLine("Timing update");
    bool convertable = TimeOnly.TryParse(Console.ReadLine(),out TimeOnly time);
    if (!convertable)
    {
        Console.WriteLine("Wrong input");
        return;
    }
    Console.WriteLine("You have successfully added your Task");
    Console.WriteLine($"{task} by {time}");
}










//    Console.WriteLine(" 1. Monday \n2. Tuesday \n3.Wednesday \n4.Thursday \n5. Friday \n6. Saturday \n7. Sunday");
//Console.WriteLine("Select an assign day for Task");

//string To_Do = Console.ReadLine();

//switch (To_Do)
//{
//    case "Monday":
//        AddToDo("Monday");
//        break;
//    case "Tuesday":
//        AddToDo
//        break;
//    case " Wednesday":
//        break;
//    case "Thursday":
//        break;
//    case"Friday":
//        break;
//    case"Saturday":
//        break;
//    case "Sunday":
//        break;


//}

//void AddToDo(string v)
//{
//    throw new NotImplementedException();
//}