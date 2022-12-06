#region Task 1

//Console.WriteLine("Enter first number:");
//int numberOne = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Enter second number:");
//int numberTwo = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("What you want?\n 1.Is numbers even? \n 2. Is numbers odd \n 3. Number negative or positive\n");
//Console.WriteLine("Enter your choise:");
//int choose = Convert.ToInt32(Console.ReadLine());
//switch (choose)
//{
//    case 1:
//        if (numberOne == numberTwo)
//        {
//            Console.WriteLine("The numbers you entered are equal");
//        }
//        else
//        {
//            Console.WriteLine("Numbers is not equal");
//        }
//        break;
//    case 2:
//        var isNumberOneOdd = false;
//        var isNumberTwoOdd = false;
//        if (numberOne % 2 == 0) isNumberOneOdd = false;
//        else isNumberOneOdd = true;
//        if (numberTwo % 2 == 0) isNumberTwoOdd = false;
//        else isNumberTwoOdd = true;
//        Console.WriteLine("Is first number odd: " + isNumberOneOdd);
//        Console.WriteLine("Is first number odd: " + isNumberOneOdd);
//        break;
//    case 3:

//        if (numberOne < 0)
//        {
//            Console.WriteLine("First number is negative");
//        }
//        else
//        {
//            Console.WriteLine("First number is positive");
//        }
//        if (numberTwo < 0)
//        {
//            Console.WriteLine("Second number in negative");
//        }
//        else
//        {
//            Console.WriteLine("Second number is positive");
//        }
//        break;
//    default:
//        Console.WriteLine("Your choice is wrong!");
//        break;
//}


#endregion

#region Task 2

//Console.WriteLine("Please enter name: ");
//string name = Console.ReadLine();
//Console.WriteLine("Please enter surname: ");
//string surname = Console.ReadLine();

//Console.WriteLine($"{name.ToUpper()} {surname.ToUpper()}");
#endregion

#region Home Task

Console.Write("Enter door sizes: ");
int doorFirstSize = Convert.ToInt32(Console.ReadLine());
int doorSecondSize = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter closet sizes: ");
int closetFirstSize = Convert.ToInt32(Console.ReadLine());
int closetSecondSize = Convert.ToInt32(Console.ReadLine());
int closetThirdSize = Convert.ToInt32(Console.ReadLine());


int closetArea = 2 * (closetFirstSize * closetSecondSize + closetSecondSize * closetThirdSize + closetThirdSize * closetSecondSize);
int doorArea = 2 * doorFirstSize * doorSecondSize;

Console.WriteLine($"Closest area - {closetArea}");
Console.WriteLine($"Door area - {doorArea}");
if(closetArea > doorArea)
{
    Console.WriteLine(false);
}
else if (closetArea == doorArea) Console.WriteLine(true);
else
{
    Console.WriteLine(true);
}
#endregion