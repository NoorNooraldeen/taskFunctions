// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


//1
#region
using System.ComponentModel.DataAnnotations;

string FullName( string name) 
{
    return name;


}
#endregion


//2
#region 
double vol (double Length, double width,double height)
{
    return Length * width * height;
}

#endregion

//3
#region
int Result (int num )
{
    if (num % 2 == 0) // cheack if the number is even
    {
        return num * num; // double the number if it is even


    }
    else return num * 2; // square the number if it is even 
}
#endregion


//4
#region
double temp(double cel)
{
    return (cel * 9 / 5) + 32;  
}
#endregion


//5
#region
string letters (char letter)
{
    //letter = letter.ToLower(letter);
    if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
    {
        return "vowel";

    }
    else if (letter == 'A' || letter == 'E' || letter == 'I' || letter == 'O' || letter == 'U')
    {
        return "VOWEL";

    }
    else if (!Char.IsLetter(letter)) // how to check if a char is not a letter?
    {
        return "Not a letter.";


    }


    else
    {
        return "constant";
    }
}


#endregion


//6
double Currency (double originalAmount, double conversionRate)
{
    return originalAmount * conversionRate;
}







#region CallingFunction
//1
Console.WriteLine("Enter Your Name: ");
string name = Console.ReadLine();
Console.WriteLine("Hello " + FullName(name)); // display message 

//2
Console.WriteLine("enter the width, height, and length of the box: ");
double Length = Convert.ToDouble(Console.ReadLine ());
double width = Convert.ToDouble(Console.ReadLine());
double height = Convert.ToDouble(Console.ReadLine());
//double volume = vol(Length, width, height);
Console.WriteLine(" the volume of the box :" + vol (width, height,Length));
Console.WriteLine(" the vol of the box (overloaded):" + vol(5, 5, 5));
//3
Console.WriteLine("enter a number");
int num = Convert.ToInt32(Console.ReadLine());
int res = Result(num);
Console.WriteLine("result is " + res);



//4
Console.WriteLine("enter the temp in celsius");
double celsius = Convert.ToDouble(Console.ReadLine()); //30
double F = temp(celsius);
Console.WriteLine("result is " + F);


//5
Console.WriteLine(" please enter a letter:");
char letter = Convert.ToChar(Console.ReadLine());
//string result = letters(letter);
Console.WriteLine(letters(letter));
//Console.WriteLine(" the letter is b " + result);
//Console.WriteLine(letters('a'));
//Console.WriteLine(letters('C'));
//Console.WriteLine(letters('I'));



//6
Console.WriteLine("enter the amount of the conversion :");
double originalAmount = (Convert.ToDouble(Console.ReadLine()));
Console.WriteLine(" amount after convertion:");
double converionRate = (Convert.ToDouble(Console.ReadLine()));
Console.WriteLine(Currency(originalAmount, converionRate));

#endregion
