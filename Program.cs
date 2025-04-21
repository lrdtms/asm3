// See https://aka.ms/new-console-template for more information

class Program
{
    static void Main()
    {
        Console.Write("Input number here : ");
        string inputString = Console.ReadLine();
        int inputNumber = int.Parse(inputString);
        
        string words = NumberConverter.NumberToWords(inputNumber);
        Console.WriteLine($"The output is : {words}");
    }

    
}
