namespace OperatorsDemoCSharp_51;

class Program
{
    static void Main(string[] args)
    {
        //Operators
        
        //Assignment operator =

        //int x = 5;
        
        //Arithmetic operators

        int addition = 5 + 5;
        int subtraction = 5 - 5;
        int multiplication = 5 * 5;
        int division = 5 / 5;
        int modulus = 6 % 5; //remainder after division

        //bool isEven = 10 % 2 == 0;

        //Console.WriteLine(isEven);
        
        //Unary operators

        int x = 3;
        int y = ++x; //pre increment

        Console.WriteLine(x);
        Console.WriteLine(y);

        int a = 3;
        int b = a++; //post increment

        Console.WriteLine(a);
        Console.WriteLine(b);

        int c = 5;
        Console.WriteLine(--c); //pre decrement

        int d = 5;
        Console.WriteLine(d--); //post decrement
        Console.WriteLine(d);
        
        //Relational operators

        bool isEqual = 5 == 5;
        bool isNotEqual = 5 != 5;
        bool greaterThan = 5 > 5;
        bool lessThan = 5 < 10;
        bool greaterThanOrEqualTo = 5 >= 5;
        bool lessThenOrEqualTo = 5 <= 5;
        
        //Logical operators

        bool resultOne = 5 == 5 && 7 == 7;
        bool resultTwo = 5 == 5 || 7 == 6;
        
        //Null coalescing operator

        int? possiblyNullValue = 1000;
        int notNullNumber = possiblyNullValue ?? 500;
        Console.WriteLine(notNullNumber);
    }
}
