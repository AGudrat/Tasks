﻿#region Task 1 If else

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
#region Task 2 If Else

//Console.WriteLine("Please enter name: ");
//string name = Console.ReadLine();
//Console.WriteLine("Please enter surname: ");
//string surname = Console.ReadLine();

//Console.WriteLine($"{name.ToUpper()} {surname.ToUpper()}");
#endregion
#region Home Task If Else

//Console.Write("Enter door sizes: ");
//int doorFirstSize = Convert.ToInt32(Console.ReadLine());
//int doorSecondSize = Convert.ToInt32(Console.ReadLine());

//Console.Write("Enter closet sizes: ");
//int closetFirstSize = Convert.ToInt32(Console.ReadLine());
//int closetSecondSize = Convert.ToInt32(Console.ReadLine());
//int closetThirdSize = Convert.ToInt32(Console.ReadLine());


//int closetArea = 2 * (closetFirstSize * closetSecondSize + closetSecondSize * closetThirdSize + closetThirdSize * closetSecondSize);
//int doorArea = 2 * doorFirstSize * doorSecondSize;

//Console.WriteLine($"Closest area - {closetArea}");
//Console.WriteLine($"Door area - {doorArea}");
//if(closetArea > doorArea)
//{
//    Console.WriteLine(false);
//}
//else if (closetArea == doorArea) Console.WriteLine(true);
//else
//{
//    Console.WriteLine(true);
//}
#endregion
#region Array and Loops

//Arrays
//string[] bosArray = new string[0];

//Array.Resize(ref bosArray, bosArray.Length + 1);

//Console.WriteLine(bosArray);

//Loops

//for
//for (char i = 'A'; i <= 'Z'; i++)
//{
//    Console.WriteLine(i);
//}

//string number = Console.ReadLine();
//int sum = 0;

//for (int i = 0; i < number.Length; i++)
//{
//    sum = sum + int.Parse(number[i].ToString());
//}
//Console.WriteLine(sum);

/*
 1. Dəmi çaydana qoymaq
 2. Su dəmləmək
 3. Qaynanmış suyu çaydana tökmək
 4. Qaza qoyub dəmləmək
 */


#endregion
#region For & Foreach example

//for (int i = 0; i <= 1000; i+=2)
//{
//        //Console.WriteLine(i);
//}
//int sum1 = 0;
//for (int i = 0; i <= 1000; i++)
//{
//    sum1 += i;
//}
//int number = 1000;
//Console.WriteLine(sum1);
//foreach (var item in Enumerable.Range(1, number))
//{
//    if (item % 2 == 0)
//    {
//        Console.WriteLine(item);
//    }
//}
//int[] number = new i[1...1000];

#endregion
#region Task For & Foreach


//int number = Convert.ToInt32(Console.ReadLine());
//var isSquare = false;
//for (int i = number; i>=2 ;i/=2)
//{
//    if(i > 0 && i%2 == 0)
//    {
//        isSquare= true;
//    } 
//    else
//    {
//        isSquare= false;
//        break;
//    }
//}
//for (int i = 0; CharEnumerator % 2 == -; ++)
//{

//}

//int number = Convert.ToInt32(Console.ReadLine());
//int steps = 0;
//for (int i = number; i>=1 ; i/=10)
//{
//    steps+=1;
//}
//Console.WriteLine(steps);


#endregion
#region Home Task For & ForEach
#region Vurma Cədvəli
//  1*1 = 1 
//  1*2 = 2
//  ...
//  1*10=10
//  -----------
//  2*1=2

/*

for (int i = 1; i <= 10; i++)
{
	for (int j = 1; j <= 10; j++)
	{
		Console.WriteLine($"{i} * {j} = {i*j}");
	}
	Console.WriteLine("-----------------------");
}

*/

///////////////////////////////////////////////

#endregion
#region Kvadrat üçbucaq
/*
 *
 **
 ***
 ****
 *****
 ******
 
 */


/////////////////////////////////
/*

for (int i = 0; i <= 6; i++)
{
	for (int j = 0; j <= i; j++)
	{
		Console.Write("*");
	}
	Console.WriteLine();
}
*/
#endregion
#region Dolu kvadrat
/*
**************
**************  
**************
**************
**************
*/
/*
for (int i = 0; i < 6; i++)
{
	for (int j = 0; j < 6; j++)
	{
		Console.Write(" *");
	}
	Console.WriteLine();
}
*/
#endregion

// Boş kvadrat

#region Boş kvadrat
/*
 * * * * * * * * * * *
 *                   *
 *                   *
 *                   *
 *                   *
 * * * * * * * * * * *                   
 */

/*

for (int i = 0; i < 6; i++)
{
	for (int j = 0; j < 5; j++)
	{
		if(j==0) Console.Write("* ");

		else if (i == 0) Console.Write("* ");
		else if (i == 5) Console.Write("* ");
        else Console.Write("  ");

    }
	Console.Write("* ");
	Console.WriteLine();
}
*/

#endregion
#endregion
#region For & do while
//int[] arr = new int[] { 5, 9, 8, 12, 3, 4, 9 };

//for (int i = 0; i < arr.Length-1; i++)
//{
//	Console.WriteLine(arr[i]);
//}




//int column = Convert.ToInt32(Console.ReadLine());
//int[] ints = new int[6];

//Random random = new();

//for (int i = 0; i < column; i++)
//{
//	for (int j = 0; j < 6; j++)
//	{
//		int value = random.Next(1, 49);
//		if (!ints.Contains(value)) ints[j] = value;
//		else
//		{
//			j--;
//			continue;
//		};
//		Console.Write($"{ints[j]} ");
//	}
//	Console.WriteLine(ints[i]);
//	Console.WriteLine();
//}



//string exactName = "Qudrat";
//string exactPassword = "qudret";

//do
//{
//    Console.Write("Name: ");
//    string name = Console.ReadLine();
//    Console.Write("Surname: ");
//    string password = Console.ReadLine();
//    if (name == exactName && password == exactPassword)
//    {
//        Console.WriteLine("You are welcome!"); break;
//    }
//    else
//    {
//        Console.WriteLine("Name or password is incorrect!");
//    };
//} while (true);

#endregion
#region Try catch 

//int arrLenght = 0;
//int[] nums = Array.Empty<int>();


//try
//{
//    do
//    {
//        int num = Convert.ToInt32(Console.ReadLine());
//        Array.Resize(ref nums, arrLenght += 1);
//        nums.SetValue(num, arrLenght - 1);
//        Console.Write("Do you want to continue? (Y/N): ");
//        string isContinue = Console.ReadLine();
//        if (isContinue.ToUpper() == "Y") continue;
//        else break;
//    } while (true);
//	Array.Sort(nums);
//}
//catch(FormatException ex)
//{
//	Console.WriteLine("Daxil etdiyiniz format düzgün deyil");
//}
//catch (OverflowException ex)
//{
//    Console.WriteLine("Daxil etdiyiniz reqem çox uzundur");
//}
//catch(Exception ex) {
//	Console.WriteLine("Xəta baş verdi.");
//}

#endregion
#region Home Task 

/*
//Write arr numbers withoute loops

int[] arr = new int[] { 1, 2, 3, 4, 5 };
Console.WriteLine(String.Join(", ", arr));
*/

/*

//Is Contain

try
{
    int number = Convert.ToInt32(Console.ReadLine());
    int[] arr = new int[] { 1, 2, 3, 4, 5 };

	//1
    if (arr.Contains(number)) Console.WriteLine(true);
    else Console.WriteLine(false);

	//2
	if (Array.Exists(arr, element => element == number)) Console.WriteLine(true);
	else Console.WriteLine(false);

}
catch (FormatException ex)
{
	Console.WriteLine("Input format is not true.");
}
catch (OverflowException ex)
{
    Console.WriteLine("Input is to long.");
}
catch (ArgumentNullException ex)
{
	Console.WriteLine("İnput can not be empty");
}
catch (Exception ex)
{
	Console.WriteLine(ex.Message);
}

*/
#endregion
