
public class NumberConverter
{ 
public static string NumberToWords(int number)
    {
        if (number == 0)
            return "Zero";

        if (number < 0)
            return HandleNegative(number);

        string words = "";

        if ((number / 1000) > 0)
        {
            words += ConvertThousands(number / 1000);
            number %= 1000;
        }

        if ((number / 100) > 0)
        {
            words += ConvertHundreds(number / 100);
            number %= 100;
        }

        if (number > 0)
        {
            words += ConvertTensAndUnits(number);
        }

        return words.Trim();
    }
       private static string HandleNegative(int number)
    {
        return "Minus " + NumberToWords(Math.Abs(number));
    }

    private static string ConvertThousands(int number)
    {
        return NumberToWords(number) + " Thousand ";
    }

    private static string ConvertHundreds(int number)
    {
        return NumberToWords(number) + " Hundred ";
    }

    private static string ConvertTensAndUnits(int number)
    {
        string[] unitsMap = { "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten",
                              "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen",
                              "Seventeen", "Eighteen", "Nineteen" };

        string[] tensMap = { "", "", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

        string result = "";

        if (number < 20)
            result += unitsMap[number];
        else
        {
            result += tensMap[number / 10];
            if ((number % 10) > 0)
                result += " " + unitsMap[number % 10];
        }

        return result + " ";
    }
}