using System;
using System.Data;
using System.Globalization;
using System.Runtime.CompilerServices;

class CodingChallengeJones
{
    static void Main()
    {
        Console.WriteLine("Hello, My Name is Travis Jones and I have a variety of functions for you to choose from");
        Console.WriteLine("Please write the name of the function you wish to do from this selcetion:\n1 - Sum\n2 - convert\n3 - AddOne\n4 - Power\n5 - Age\n6 - Triangle\n7 - LessThanOrEqualToZero\n8 - LessThan100\n9 - EqualTo\n10 - GiveMeSomething\n11 - Reverse\n12 - howManySeconds\n13 - sumPolygon\n14 - nameString\n15 - And\n16 - points\n17 - findPerimeter\n18 - helloName\n19 - animals\n20 - footballPoints\n21 - monthName\n22 - findMinMax\n23 - getAbsSum\n24 - calculateExponent\n25 - MultiplyByLength\n26 - HammingDistance");
        int f = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(CallFunction(f));
        Repeat();
    }

    static void Repeat()
    {
        for (int i = 1; i < 100; i++)
        {
            Console.WriteLine("Hello, My Name is Travis Jones and I have a variety of functions for you to choose from");
            Console.WriteLine("Please write the name of the function you wish to do from this selcetion:\n1 - Sum\n2 - convert\n3 - AddOne\n4 - Power\n5 - Age\n6 - Triangle\n7 - LessThanOrEqualToZero\n8 - LessThan100\n9 - EqualTo\n10 - GiveMeSomething\n11 - Reverse\n12 - howManySeconds\n13 - sumPolygon\n14 - nameString\n15 - And\n16 - points\n17 - findPerimeter\n18 - helloName\n19 - animals\n20 - footballPoints\n21 - monthName\n22 - findMinMax\n23 - getAbsSum\n24 - calculateExponent\n25 - MultiplyByLength\n26 - HammingDistance");
            int f = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(CallFunction(f));
        }
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
            Console.WriteLine("The power is " + AddOne(x));
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
        if(f == 5)
        {
            Console.WriteLine("You chose Age");
            Console.WriteLine("Please enter an age in years");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The age in days is " + Age(y));
        }
        if (f == 6)
        {
            Console.WriteLine("You chose Triangle");
            Console.WriteLine("Please enter a base");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a height");
            int h = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The triangle's area is " + Triangle(b, h));
        }
        if (f == 7)
        {
            Console.WriteLine("You chose LessThanOrEqualToZero");
            Console.WriteLine("Please enter a number");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The number is " + LessThanOrEqualToZero(n));
        }
        if (f == 8)
        {
            Console.WriteLine("You chose lessThan100");
            Console.WriteLine("Please enter a number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter another number");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The sum is " + LessThan100(a, b));
        }
        if (f == 9)
        {
            Console.WriteLine("You chose EqualTo");
            Console.WriteLine("Please enter a number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter another number");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The numbers is " + EqualTo(a, b));
        }
        if (f == 10)
        {
            Console.WriteLine("You chose GiveMeSomething");
            Console.WriteLine("Please enter a word");
            string s = Convert.ToString(Console.ReadLine());
            Console.WriteLine(GiveMeSomething(s));
        }
        if (f == 11)
        {
            Console.WriteLine("You chose Reverse");
            Console.WriteLine("Please enter true or false");
            bool b = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("The reverse is " + Reverse(b));
        }
        if (f == 12)
        {
            Console.WriteLine("You chose howManySeconds");
            Console.WriteLine("Please enter a time in minutes");
            int s = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The seconds is " + howManySeconds(s));
        }
        if (f == 13)
        {
            Console.WriteLine("You chose sumPolygon");
            Console.WriteLine("Please enter a number of sides");
            int p = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The sum of internal angles is " + howManySeconds(p));
        }
        if (f == 14)
        {
            Console.WriteLine("You chose nameString");
            Console.WriteLine("Please enter a name");
            string first = Convert.ToString(Console.ReadLine());
            Console.WriteLine(nameString(first));
        }
        if (f == 15)
        {
            Console.WriteLine("You chose And");
            Console.WriteLine("Please enter true or false");
            bool a = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Please enter true or false");
            bool b = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("The bools is " + And(a, b));
        }
        if (f == 16)
        {
            Console.WriteLine("You chose points");
            Console.WriteLine("Please enter an amount of two pointers");
            int o = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter an amount of three pointers");
            int t = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The points scored is " + points(o, t));
        }
        if (f == 17)
        {
            Console.WriteLine("You chose findPerimeter");
            Console.WriteLine("Please enter a width");
            int w = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a length");
            int l = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The perimeter is " + findPerimeter(w, l));
        }
        if (f == 18)
        {
            Console.WriteLine("You chose helloName");
            Console.WriteLine("Please enter a name");
            string name = Convert.ToString(Console.ReadLine());
            Console.WriteLine(helloName(name));
        }
        if (f == 19)
        {
            Console.WriteLine("You chose animals");
            Console.WriteLine("Please enter an amount of chickens");
            int ch = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter an amount of cows");
            int cow = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter an amount of pigs");
            int p = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The numbers of totals legs are is " + animals(ch, cow, p));
        }
        if (f == 20)
        {
            Console.WriteLine("You chose footballPoints");
            Console.WriteLine("Please enter an amount of wins");
            int w = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter an amount of draws");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter an amount of losses");
            int l = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The points based on wins, draws, and losses is " + footballPoints(w, d, l));
        }
        if (f == 21)
        {
            Console.WriteLine("You chose monthName");
            Console.WriteLine("Please enter a number of a month");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The month is " + monthName(m));

        }
        if (f == 22)
        {
            Console.WriteLine("You chose findMinMax");

        }
        if (f == 23)
        {
            Console.WriteLine("You chose getAbsSum");
        }
        if (f == 24)
        {
            Console.WriteLine("You chose calculateExponent");
            Console.WriteLine("Please enter a base number");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter an exponent");
            int e = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The product is " + calculateExponent(b, e));
        }
        if (f == 25)
        {
            Console.WriteLine("You chose MultiplyByLength");
        }
        if (f == 26)
        {
            Console.WriteLine("You chose HammingDistance");
            Console.WriteLine("Please enter a word");
            string first = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Please enter another word");
            string second = Convert.ToString(Console.ReadLine());
            Console.WriteLine("The hamming distance is " + HammingDistance(first, second));
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