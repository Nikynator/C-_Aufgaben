namespace Aufgabe_19;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Make your calculation (or press Q to quit)");
        string input = Console.ReadLine();
        string repInput = input.Replace(" ", "");
        string [] inputArray = repInput.Split('+','-','*','/');
        int Input1 = int.Parse(inputArray[0]);
        int Input2 = int.Parse(inputArray[1]);
        Console.WriteLine(Input2);
        string OperatorList = "+-*/";
        methodCalc(Input1, Input2, OperatorList, input);

        //Try 1---------------------------------
        //string [] inputSpilt = input.Split(' ');
        //int number1 = int.Parse(inputSpilt[0]);
        //int number2 = int.Parse(inputSpilt[2]);
        //int op = int.Parse(inputSpilt[1]);
        //Console.WriteLine(op);
        //---------------------------------------

    }
    static int methodCalc(int Input1, int Input2,string OperatorList,string input)
    {
        foreach (char Numbers in input)
        {
            if (OperatorList.Contains(Numbers))
            {
                if (Numbers == '+')
                {
                    Console.WriteLine($"{Input1} + {Input2}");
                    Console.WriteLine($"{Input1 + Input2}");
                }
                if (Numbers == '-')
                {
                    Console.WriteLine($"{Input1} - {Input2}");
                    Console.WriteLine($"{Input1 - Input2}");
                }
                if (Numbers == '*')
                {
                    Console.WriteLine($"{Input1} * {Input2}");
                    Console.WriteLine($"{Input1 * Input2}");
                }
                if (Numbers == '/')
                {
                    Console.WriteLine($"{Input1} / {Input2}");
                    Console.WriteLine($"{Input1 / Input2}");
                }
            }
        }
        return 0;
    }
}