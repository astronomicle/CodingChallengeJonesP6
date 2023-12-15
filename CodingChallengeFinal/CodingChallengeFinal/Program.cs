using System;
using System.Data;
using System.Globalization;
using System.Runtime.CompilerServices;

class CodingChallengeJones
{
    static void Main()
    {
        /*Console.WriteLine("Hello, My Name is Travis Jones and I have a variety of functions for you to choose from");
        Console.WriteLine("Please write the name of the function you wish to do from this selcetion:\n1 - Sum\n2 - convert\n3 - AddOne\n4 - Power\n5 - Age\n6 - Triangle\n7 - LessThanOrEqualToZero\n8 - LessThan100\n9 - EqualTo\n10 - GiveMeSomething\n11 - Reverse\n12 - howManySeconds\n13 - sumPolygon\n14 - nameString\n15 - And\n16 - points\n17 - findPerimeter\n18 - helloName\n19 - animals\n20 - footballPoints\n21 - monthName\n22 - findMinMax\n23 - getAbsSum\n24 - calculateExponent\n25 - MultiplyByLength\n26 - HammingDistance");
        Console.ReadLine();*/
        Console.WriteLine(CallFunction(1));

        /*Console.WriteLine("The sum of 4 and 12 is " + Sum(4, 12));
        Console.WriteLine("5 minutes is also " + convert(5) + " seconds");
        Console.WriteLine("7 plus one is " + AddOne(7));
        Console.WriteLine("When the voltage is 320 and the current is 50, then the power is " + Power(320, 50));
        Console.WriteLine("15 years old is the same as " + Age(15) + " days old");
        Console.WriteLine("When the base of the base is 4 and the height is 6, then the area is " + Triangle(4, 6));
        Console.WriteLine("7 is less than or equal to 0, this statement is " + LessThanOrEqualToZero(7));
        Console.WriteLine("77 plus 33 is less than 100, this statement is " + LessThan100(77, 33));
        Console.WriteLine("5478239 is equal to 5478239, this statement is " + EqualTo(5478239, 5478239));
        Console.WriteLine(GiveMeSomething("is wrong..."));
        Console.WriteLine("False is " + Reverse(false));
        Console.WriteLine("24 hours is also " + howManySeconds(24) + " seconds");
        Console.WriteLine("A polygon with 12 sides has " + sumPolygon(12) + " degree internal angle");
        Console.WriteLine("The name is " + nameString("John"));
        Console.WriteLine(And(true, false));
        Console.WriteLine("There were " + points(3, 13) + " points scored during the game");
        Console.WriteLine("With a width of 12 and a length of 23 then the perimeter is " + findPerimeter(12, 23));
        Console.WriteLine(helloName("Johnny"));
        Console.WriteLine("If there are 5 chickens, 12 cows, and 9 pigs, then there are " + animals(5, 12, 9) + " total legs");
        Console.WriteLine("The football team had 11 wins, 2 draws, and 3 losses, so the team has " + footballPoints(11, 2, 3) + " points");
        Console.WriteLine("This month is " + monthName(11));
        int[] minMax = { 12, -77, 555, 89 };
        Console.WriteLine("The max for the array 12, -77, 555, 89 is " + findMinMax(minMax));
        int[] numbers = { 2, 34, -22, 7, -1 };
        Console.WriteLine("The sum of the absolute values of 2, 34, -22, 7, -1 is " + getAbsSum(numbers));
        Console.WriteLine("The base number 6 multiplied by the exponent 4 has a product of " + calculateExponent(6, 4));
        int[] lengths = { 0, 11, -9, 12, 5 };
        Console.WriteLine("The array 0, 11, -9, 12, 5 multiplied by the length gives the new array " + MultiplyByLength(lengths));
        Console.WriteLine("The hamming distance for the line abcdefgg and abcbefgh is " + HammingDistance("abcdefgg", "abcbefgh"));*/
    }

    public static string CallFunction(int f)
    {
        
        if (f == 1)
        {
            Console.WriteLine("You chose Sum");
            Console.WriteLine("Please enter a number");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter another number");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The sum is " + Sum(x, y));
        }
        if (f == 2)
        {
            Console.WriteLine("You chose convert");
            Console.WriteLine("Please enter a minute");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The sum is " + convert(min));
        }
        if (f == 3)
        {
            Console.WriteLine("You chose AddOne");
            Console.WriteLine("Please enter a number");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The sum is " + AddOne(x));
        }
        if (f == 4)
        {
            Console.WriteLine("You chose Power");
            Console.WriteLine("Please enter a voltage");
            int v = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a current");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The sum is " + Power(v, c));
        }
        return null;
    }

    public static int HammingDistance(string first, string second)
    {
        int count = 0;

        if (first.Length > second.Length || first.Length < second.Length) { throw new ArgumentException(); }
        else if (first.Length == 0 || second.Length == 0) { count = 0; }
        else if (first == second) { count = 0; }
        else
        {
            for (int i = 0; i < first.Length; i++)
            {
                if (first[i] != second[i])
                {
                    count++;
                }
            }
        }
        return count;
    }

    public static int MultiplyByLength(int[] l)
    {
        int a = l[0] * l.Length;
        int b = l[1] * l.Length;
        int c = l[2] * l.Length;
        int d = l[3] * l.Length;
        int e = l[4] * l.Length;
        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);
        Console.WriteLine(d);
        return e;
    }

    public static int calculateExponent(int b, int e)
    {
        return (int)Math.Pow(b, e);
    }

    public static int getAbsSum(int[] absNumbers)
    {
        int a = Math.Abs(absNumbers[0]);
        int b = Math.Abs(absNumbers[1]);
        int c = Math.Abs(absNumbers[2]);
        int d = Math.Abs(absNumbers[3]);
        int e = Math.Abs(absNumbers[4]);
        return a + b + c + d + e;
    }

    public static int findMinMax(int[] a)
    {
        int b = a.Min();
        int c = a.Max();
        Console.WriteLine("The min is " + b);
        return c;
    }

    public static string monthName(int m)
    {
        return CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(m);
    }

    public static int footballPoints(int w, int d, int l)
    {
        return (w * 3) + d + (l * 0);
    }

    public static int animals(int chicken, int cow, int pig)
    {
        return (chicken * 2) + (cow * 4) + (pig * 4);
    }


    public static string helloName(string name)
    {
        return "Hello " + name + "!";
    }


    public static int findPerimeter(int w, int l)
    {
        int p = (2 * w) + (2 * l);
        return p;
    }

    public static int points(int o, int t)
    {
        o = o * 2; t = t * 3;
        return o + t;
    }

    public static bool And(bool a, bool b)
    {
        if (a && b == true) return true;
        else return false;
    }

    public static string nameString(string first)
    {
        string last = (" Edabit");
        return first + last;
    }

    public static int sumPolygon(int p)
    {
        return (p - 2) * 180;
    }

    public static int howManySeconds(int s)
    {
        return s * 3600;
    }

    public static bool Reverse(bool b)
    {
        return !b;
    }

    public static string GiveMeSomething(string s)
    {
        string something = ("Something ");
        s = (something + s);
        return s;
    }

    public static bool EqualTo(int a, int b)
    {
        if (a == b)
        {
            return true;
        }
        return false;
    }

    public static bool LessThan100(int a, int b)
    {
        int c = a + b;
        if (c < 100)
        {
            return true;
        }
        return false;
    }

    public static bool LessThanOrEqualToZero(int n)
    {
        if (n > 0)
        {
            return false;
        }
        return true;
    }

    public static int Triangle(int b, int h)
    {
        int a = (b * h) / 2;
        return a;
    }

    public static int Age(int years)
    {
        int days;
        days = years * 365;
        return days;
    }

    public static int Power(int voltage, int current)
    {
        int power;
        power = voltage * current;
        return power;
    }

    public static int AddOne(int a)
    {
        int b = a + 1;
        return b;
    }

    public static int convert(int min)
    {
        int sec = min * 60;
        return sec;
    }

    public static int Sum(int a, int b)
    {
        int c = a + b;
        return c;
    }
}