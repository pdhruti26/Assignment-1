//:- C# Basic Laboratory Exercise :-

 //1. Write a C# Sharp program to print Hello and your name in a separate line
using System;


class pro1
{
    static void Main()
    {
        Console.WriteLine("Hello_World..... ");
        
    }
}

//2. Write a C# Sharp program to print the sum of two numbers.
using System;
class Example
{
    static void Main()
    {
        int a = 10, b = 20, c;
        c = a + b;
        Console.WriteLine("Sum Of " + c);
    }
}

//3. Write a C# Sharp program to print the result of dividing two numbers.
using System;
class Example
{
    static void Main()
    {
        int b = 20;
         float a = 10, c;
        c = a / b;
        Console.WriteLine("Result " + c);
    }
}


//4. Write a C# Sharp program to print the result of the specified operations.
//Test data: 
//•	-1 + 4 * 6
//•	  ( 35+ 5 ) % 7
//•	  14 + -4 * 6 / 11
//•	2 + 15 / 6 * 1 - 7 % 2
//•	
using System;
class Exercise4
{
     static void Main()
    {
        Console.WriteLine(-1 + 4 * 6);
        //-1 + 24 = 23
       Console.WriteLine((35 + 5) % 7);
        //40 % 7 = 5 (remainder of 40/7)
        Console.WriteLine(14 + -4 * 6 / 11);
        //14 - (24/11)= 14 - 2 = 12
        Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2);
        //2 + (15/6) - remainder of (7/2) = 2 + 2 - 1 = 4 - 1 = 3
    }
}

//5. Write a C# Sharp program to swap two numbers…..

using System;
 class SwapExample
{
     static void Main()
    {
        int a = 5, b = 6;
        Console.WriteLine("Before swap a= " + a + " b= " + b);
        a = a * b; //a=30 (5*6)      
        b = a / b; //b=6 (30/6)      
        a = a / b; //a=6 (30/5)    
        Console.Write("After swap a= " + a + " b= " + b);
    }
}

//6. Write a C# Sharp program to print the output of multiplication of three numbers which will be entered by the user.
using System;
 class Exercise6
{
     static void Main()
    {
        int num1, num2, num3;

        Console.Write("Input the first number to multiply: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Input the second number to multiply: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Input the third number to multiply: ");
        num3 = Convert.ToInt32(Console.ReadLine());

        int result = num1 * num2 * num3;
        Console.WriteLine("Output: {0} x {1} x {2} = {3}",
                            num1, num2, num3, result);
    }
}



//7. Write a C# Sharp program to print on screen the output of adding, subtracting, multiplying and dividing of two numbers which will be entered by the user.

using System;
 class Exercise7
{
     static void Main()
    {
        Console.Write("Enter a number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter another number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("{0} + {1} = {2}", num1, num2, num1 + num2);
        Console.WriteLine("{0} - {1} = {2}", num1, num2, num1 - num2);
        Console.WriteLine("{0} x {1} = {2}", num1, num2, num1 * num2);
        Console.WriteLine("{0} / {1} = {2}", num1, num2, num1 / num2);
        Console.WriteLine("{0} mod {1} = {2}", num1, num2, num1 % num2);
    }
}


//8. Write a C# Sharp program that takes a number as input and print its multiplication table…
 using System;
public class Exercise8
{
 public static void Main()
 {
  int x;
  int result;
 
  Console.WriteLine("Enter a number:");
  x = Convert.ToInt32(Console.ReadLine() );
   
  result = x * 1;
  Console.WriteLine("The table is : {0} x {1} = {2}", x, 1, result);
  result = x * 2;
  Console.WriteLine("             : {0} x {1} = {2}", x, 2, result);
  result = x * 3;
  Console.WriteLine("             : {0} x {1} = {2}", x, 3, result);
  result = x * 4;
  Console.WriteLine("             : {0} x {1} = {2}", x, 4, result);
  result = x * 5;
  Console.WriteLine("             : {0} x {1} = {2}", x, 5, result);
  result = x * 6;
  Console.WriteLine("             : {0} x {1} = {2}", x, 6, result);
  result = x * 7;
  Console.WriteLine("             : {0} x {1} = {2}", x, 7, result);
  result = x * 8;
  Console.WriteLine("             : {0} x {1} = {2}", x, 8, result);
  result = x * 9;
  Console.WriteLine("             : {0} x {1} = {2}", x, 9, result);
  result = x * 10;
  Console.WriteLine("             : {0} x {1} = {2}", x, 10, result);
 }
}

//9. Write a C# Sharp program that takes four numbers as input to calculate and print the average….

using System;
using System.IO;
 class Exercise9
{
     static void Main()
    {
        double number1, number2, number3, number4;

        Console.Write("Enter the First number: ");
        number1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the Second number: ");
        number2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the third number: ");
        number3 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the fourth number: ");
        number4 = Convert.ToDouble(Console.ReadLine());

        double result = (number1 + number2 + number3 + number4) / 4;
        Console.WriteLine("The average of {0}, {1}, {2}, {3} is: {4} ",
     number1, number2, number3, number4, result);
    }
}



//10. Write a C# Sharp program to that takes three numbers(x,y,z) as input and print the output of (x+y).z and x.y + y.z…….

using System;
public class Exercise10
{
    public static void Main()
    {
        int number1, number2, number3;

        Console.Write("Enter first number - ");
        number1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number - ");
        number2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter third number - ");
        number3 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Result of specified numbers {0}, {1} and {2}, (x+y)•z is {3} and x•y + y•z is {4}\n\n",
            number1, number2, number3, ((number1 + number2) * number3), (number1 * number2 + number2 * number3));
    }
}


//11. Write a C# Sharp program that takes an age (for example 20) as input and prints something as "You look older than 20"

using System;
 class Dp
{
    static void Main()
    {
        int age;
        Console.Write("Enter your age ");
        age = Convert.ToInt32(Console.ReadLine());
        Console.Write("You look older than {0} ", age);
    }
}


//12. Write a C# program to that takes a number as input and display it four times in a row (separated by blank spaces), and then four times in the next row, with no separation. You should do it two times: Use Console. Write and then use {0}.

using System;
class pro12
{
     static void Main()
    {
        int num;

        Console.WriteLine("Enter a Number: ");
        num = Convert.ToInt32(Console.ReadLine());

        // Part A: "num num num num" using Write
        Console.Write(num);
        Console.Write(" ");
        Console.Write(num);
        Console.Write(" ");
        Console.Write(num);
        Console.Write(" ");
        Console.Write(num);
        Console.WriteLine();

        // Part B: "numnumnumnum" using Write
        Console.Write(num);
        Console.Write(num);
        Console.Write(num);
        Console.WriteLine(num);
        Console.WriteLine();

        // Part C: "num num num num" using {0}
        Console.WriteLine("{0} {0} {0} {0}", num);

        // Part D: "numnumnumnum" using {0}
        Console.WriteLine("{0}{0}{0}{0}", num);
    }
}


//13. Write a C# program that takes a number as input and then displays a rectangle of 3 columns wide and 5 rows tall using that digit.

using System;
 class pro13
{
     static void Main()
    {
        int x;

        Console.Write("Enter a number: ");
        x = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("{0}{0}{0}", x);
        Console.WriteLine("{0} {0}", x);
        Console.WriteLine("{0} {0}", x);
        Console.WriteLine("{0} {0}", x);
        Console.WriteLine("{0}{0}{0}", x);
    }
}
//14. Write a C# program to convert from celsius degrees to Kelvin and Fahrenheit.

using System;
public class pro14
{
    public static void Main()
    {
        Console.Write("Enter the amount of Celsius: ");
        int celsius = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Kelvin = {0}", celsius + 273);
        Console.WriteLine("Fahrenheit = {0}", celsius * 18 / 10 + 32);
    }
}



//15. Write a C# program remove specified a character from a non-empty string using index of a character

using System;


 class pro15
{
    static void Main()
    {
        Console.WriteLine(remove_char("Atmiya University", 1));
        Console.WriteLine(remove_char("Atmiya University", 9));
        Console.WriteLine(remove_char("Atmiya University", 0));
    }
    public static string remove_char(string str, int n)
    {
        return str.Remove(n, 1);
    }
}


//16. Write a C# program to create a new string from a given string (length 1 or more) with the first character added at the front and back

using System;


class pro16
{
    static void Main()
    {
        string str;
       
        Console.Write("Input a string : ");
        str = Console.ReadLine();
        if (str.Length >= 1)
        {
            var s = str.Substring(0, 1);
            Console.WriteLine(s + str + s);
        }
    }
}



//17. . Write a C# program to check two given integers and return true if one is negative and one is positive.

using System;


 class pro17
{
    static void Main()
    {
        Console.WriteLine("\nInput first integer:");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input second integer:");
        int y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Check if one is negative and one is positive:");
        Console.WriteLine((x < 0 && y > 0) || (x > 0 && y < 0));
    }
}

//18. Write a C# program to compute the sum of two given integers, if two values are equal then return the triple of their sum.
using System;


public class pro18
{
    static void Main()
    {
        Console.WriteLine(SumTriple(2, 2));
        Console.WriteLine(SumTriple(12, 10));
        Console.WriteLine(SumTriple(-5, 2));
    }
    public static int SumTriple(int a, int b)
    {
        return a == b ? (a + b) * 3 : a + b;
    }
}

//19. Write a C# program to get the absolute value of the difference between two given numbers. Return double the absolute value of the difference if the first number is greater than second number…
using System;


 class pro19
{
    static void Main()
    {
        Console.WriteLine(result(13, 40));
        Console.WriteLine(result(50, 21));
        Console.WriteLine(result(0, 23));
    }

    public static int result(int a, int b)
    {
        if (a > b)
        {
            return (a - b) * 2;
        }
        return b - a;
    }
}

//20. . Write a C# program to check the sum of the two given integers and return true if one of the integer is 20 or if their sum is 20.

using System;


 class pro20
{
    static void Main()
    {
        int x, y;
        int result;

        Console.WriteLine("\nInput an integer:");
        x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input another integer:");
        y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(x == 20 || y == 20 || (x + y == 20));
    }
}

//21. Write a C# program to check if an given integer is within 20 of 100 or 200….

using System;

 class pro21
{
    static void Main()
    {
        Console.WriteLine("\nInput an integer:");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(result(x));
    }

    public static bool result(int n)
    {
        if (Math.Abs(n - 100) <= 20 || Math.Abs(n - 200) <= 20)
            return true;
        return false;
    }
}

//22. write a c# sharp program to display the following pattern using the alphabet.

using System;
 class pro22
{
     static void Main()
    {
        string line = "Write a C# Sharp Program to display the following pattern using the Alphabet.";

        Console.WriteLine(line.ToLower());

    }
}


//23. Write a C# program to print the odd numbers from 1 to 99. Prints one number per line.

using System;

 class Pro23
{
     static void Main()
    {
        Console.WriteLine("Odd numbers from 1 to 99. Prints one number per line.");
        for (int n = 1; n < (99 + 1); n++)
        {
            if (n % 2 != 0)
            {
                Console.WriteLine(n.ToString());
            }
        }
    }
}

//24.. Write a C# program to compute the sum of the first 500 prime numbers.

using System;
 class pro244
{
     static void Main()
    {
        Console.WriteLine("\nSum of the first 500 prime numbers: ");
        long sum = 0;
        int ctr = 0;
        int n = 2;
        while (ctr < 500)
        {
            if (isPrime(n))
            {
                sum += n;
                ctr++;
            }
            n++;
        }

        Console.WriteLine(sum.ToString());

    }
    public static bool isPrime(int n)
    {
        int x = (int)Math.Floor(Math.Sqrt(n));

        if (n == 1) return false;
        if (n == 2) return true;

        for (int i = 2; i <= x; ++i)
        {
            if (n % i == 0) return false;
        }

        return true;
    }
}

//25. Write a C# program and compute the sum of the digits of an integer.

using System;
 class pro25
{
     static void Main()
    {
        Console.Write("Input  a number(integer): ");
        int n = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        while (n != 0)
        {
            sum += n % 10;
            n /= 10;
        }
        Console.WriteLine("Sum of the digits of the said integer: " + sum);
    }
}


//26.  Write a C# program to reverse the words of a sentence.

using System;
using System.Linq;

class Pro26
{
    static void Main()
    {
        string text = "My GirlFriend name is Natasha Patel";

        Console.WriteLine(string.Join(" ", text.Split(' ').Reverse()));
    }
}


//27. Write a C# program to find the size of a specified file in bytes.



//28. Write a C# program to convert a hexadecimal number to decimal number….

using System;

 class pro28
{
     static void Main()
    {

        string hexval = "4B0";
        Console.WriteLine("Hexadecimal number: " + hexval);
        int decValue = int.Parse(hexval, System.Globalization.NumberStyles.HexNumber);
        Console.WriteLine("Convert to-");
        Console.WriteLine("Decimal number: " + decValue);
    }
}

//29.Write a C# program to multiply corresponding elements of two arrays of integers.

using System;

 class Pro29
{
     static void Main()
    {
        int[] first_array = { 1, 3, -5, 4 };
        int[] second_array = { 1, 4, -5, -2 };

        Console.WriteLine("\nArray1: [{0}]", string.Join(", ", first_array));
        Console.WriteLine("Array2: [{0}]", string.Join(", ", second_array));

        Console.WriteLine("\nMultiply corresponding elements of two arrays: ");

        for (int i = 0; i < first_array.Length; i++)
        {

            Console.Write(first_array[i] * second_array[i] + " ");
        }
        Console.WriteLine("\n");
    }
}


//30. Write a C# program to create a new string of four copies, taking last four characters from a given string. If the length of the given string is less than 4 return the original one…

using System;
using System.Linq;

 class Pro30
 {
  static void Main()
        {
           string str; 
           int l= 0;
           Console.Write("Input a string : ");
           str = Console.ReadLine();
           if (str.Length>4)
           {
              Console.WriteLine(str.Length < 4 ? str + str + str : str.Substring(str.Length - 4)+ str.Substring(str.Length - 4) + str.Substring(str.Length - 4) + str.Substring(str.Length - 4));
           }
        }
}

//31. Write a C# program to check if a given positive number is a multiple of 3 or a multiple of 7.

using System;
using System.Linq;

class Pro31
{
    static void Main()
    {
        Console.WriteLine("\nInput first integer:");
        int x = Convert.ToInt32(Console.ReadLine());
        if (x > 0)
        {
            Console.WriteLine(x % 3 == 0 || x % 7 == 0);
        }
    }
}


//32. Write a C# program to check if a string starts with a specified word.

using System;
using System.Linq;


 class pro32
{
    static void Main()
    {
        string str;
        Console.Write("Input a string : ");
        str = Console.ReadLine();
        Console.WriteLine((str.Length < 6 && str.Equals("Hello")) || (str.StartsWith("Hello") && str[5] == ' '));
    }
}


//33. Write a C# program to check two given numbers where one is less than 100 and other is greater than 200.

using System;
using System.Linq;

public class Pro33
{
    static void Main()
    {
        Console.Write("Input a first number(<100): ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input a second number(>200): ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine((m < 100 && n > 200));
    }
}


//34. Write a C# program to check if an integer (from the two given integers) is in the range -10 to 10.

using System;
using System.Linq;


 class Pro34
{
    static void Main()
    {
        Console.Write("Input a first number: ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input a second number: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(((m >= -10 && m <= 10)) || ((n >= -10 && n <= 10)));
    }

}

//35. Write a C# program to check if "HP" appears at second position in a string and returns the string without "HP".

using System;

using System.Linq;

class Pro35
{
    static void Main()
    {
        string str = "PHP Tutorial";
        Console.WriteLine((str.Substring(1, 2).Equals("HP") ? str.Remove(1, 2) : str));
    }
}


//36. Write a C# program to find the largest and lowest values from three integer values.

using System;
using System.Linq;

 class pro36
{
    static void Main()
    {
        Console.WriteLine("\nInput first integer:");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input second integer:");
        int y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input third integer:");
        int z = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Largest of three: " + Math.Max(x, Math.Max(y, z)));
        Console.WriteLine("Lowest of three: " + Math.Min(x, Math.Min(y, z)));
    }
}


//37. Write a C# program to check the nearest value of 20 of two given integers and return 0 if two numbers are same.

using System;
using System.Linq;

class pro37
{
static void Main()
    {
        Console.WriteLine("\nInput first integer:");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input second integer:");
        int y = Convert.ToInt32(Console.ReadLine());
        int n = 20;
        var val1 = Math.Abs(x - n);
        var val2 = Math.Abs(y - n);
        Console.WriteLine(val1 == val2 ? 0 : (val1 < val2 ? x : y));
    }
}

//38. Write a C# program to count a specified number in a given array of integers.

using System;
using System.Linq;

 class pro38
{
    static void Main()
    {
        Console.WriteLine("\nInput an integer:");
        int x = Convert.ToInt32(Console.ReadLine());
        int[] nums = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 9 };
        Console.WriteLine("Number of " + x + " present in the said array:");
        Console.WriteLine(nums.Count(n => n == x));
    }
}

//39. Write a C# program to check if a number appears as either the first or last element of an array of integers and the length is 1 or more.

using System;
using System.Linq;


 class pro39
{
    static void Main()
    {
        Console.WriteLine("\nInput an integer:");
        int x = Convert.ToInt32(Console.ReadLine());
        int[] nums = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 9 };
        Console.WriteLine((nums[0] == x) || (nums[nums.Length - 1] == x));
    }
}


//40. Write a C# program to compute the sum of all the elements of an array of integers.

using System;
using System.Linq;

class pro40
{
     static void Main()
    {
        int[] nums = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };
        Console.WriteLine("\nArray1: [{0}]", string.Join(", ", nums));
        var sum = 0;
        for (var i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
        }
        Console.WriteLine("Sum: " + sum);
    }
}

//41. Write a C# program to check if the first element or the last element of the two arrays ( length 1 or more) are equal.

using System;

using System.Linq;

 class pro41
{
     static void Main()
    {
        int[] nums1 = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };
        Console.WriteLine("\nArray1: [{0}]", string.Join(", ", nums1));
        int[] nums2 = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 5 };
        Console.WriteLine("\nArray2: [{0}]", string.Join(", ", nums2));

        Console.WriteLine("\nCheck if the first element or the last element of the two arrays ( length 1 or more) are equal.");
        Console.WriteLine((nums1[0].Equals(nums2[0])) || (nums1[nums1.Length - 1].Equals(nums2[nums2.Length - 1])));
    }
}


//42. Write a C# program to rotate an array (length 3) of integers in left direction.

using System;
using System.Linq;


 class pro42
{
     static void Main()
    {
        int[] nums = { 1, 2, 8 };
        Console.WriteLine("\nArray1: [{0}]", string.Join(", ", nums));
        var temp = nums[0];
        for (var i = 0; i < nums.Length - 1; i++)
        {
            nums[i] = nums[i + 1];
        }
        nums[nums.Length - 1] = temp;
        Console.WriteLine("\nAfter rotating array becomes: [{0}]", string.Join(", ", nums));

    }
}


//43. Write a C# program to get the larger value between first and last element of an array (length 3) of integers.

using System;
using System.Linq;

 class pro43
{
     static void Main()
    {
        int[] nums = { 1, 2, 5, 7, 8 };
        Console.WriteLine("\nArray1: [{0}]", string.Join(", ", nums));
        var h_val = nums[0];
        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] > nums[0])
                h_val = nums[i];
        }
        Console.WriteLine("\nHighest value between first and last values of the said array: {0}", h_val);

    }
}

//44. Write a C# program to create a new array of length containing the middle elements of three arrays (each length 3) of integers.

using System;

using System.Linq;


class pro44
{
     static void Main()
    {
        int[] array1 = { 1, 2, 5 };
        Console.WriteLine("\nArray1: [{0}]", string.Join(", ", array1));
        int[] array2 = { 0, 3, 8 };
        Console.WriteLine("\nArray2: [{0}]", string.Join(", ", array2));
        int[] array3 = { -1, 0, 2 };
        Console.WriteLine("\nArray3: [{0}]", string.Join(", ", array3));
        int[] new_array = { array1[1], array2[1], array3[1] };
        Console.WriteLine("\nNew array: [{0}]", string.Join(", ", new_array));

    }
}


//45. Write a C# program to check if an array contains an odd number.


using System;
using System.Linq;
 class pro45
{
     static void Main()
    {
        int[] nums = { 2, 4, 7, 8, 6 };
        Console.WriteLine("\nOriginal array: [{0}]", string.Join(", ", nums));
        Console.WriteLine("Check if an array contains an odd number? " + even_odd(nums));
    }

    public static bool even_odd(int[] nums)
    {
        foreach (var n in nums)
        {
            if (n % 2 != 0)
                return true;
        }
        return false;

    }
}



