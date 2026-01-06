// See https://aka.ms/new-console-template for more information
using System;
using System.Linq;

 System.Console.WriteLine("Resultat: " + Multiply(-2));

//multiply each number by 5 raised to the number of digits of each numbers
//Console result
// void MultiplyConsoleResult(int number)
// {
    
//     string stringPuissance = number.ToString();
//     int puissance = stringPuissance.Length;
//     double resultPuissance5 = Math.Pow(5,3);
//     System.Console.WriteLine("resultat:" + number*resultPuissance5);

// }

//multiply each number by 5 raised to the number of digits of each numbers
int Multiply(int number)
{
    
    string numberAsString = number.ToString();
    string digits = new string(numberAsString.Where(char.IsDigit).ToArray());
    int getNumberDigitsinNumber = digits.Length;
    double resultPuissance5 = Math.Pow(5,getNumberDigitsinNumber);
    return Convert.ToInt32(resultPuissance5*number);

}
