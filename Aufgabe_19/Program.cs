namespace Aufgabe_19;

class Program
{
    static bool keypressed = false;
    static void Main(string[] args)
    {
        while (keypressed == false)
        {
            Console.WriteLine("Make your calculation (or press Q to quit)");
            string input = Console.ReadLine();
            if (input == "q")
            {
                keypressed = true;
                Console.WriteLine("You pressed q which stopped the programm");
            }
            else
            {
                string repInput = input.Replace(" ", "");
                string [] inputArray = repInput.Split('+','-','*','/');
                int Input1 = int.Parse(inputArray[0]);
                int Input2 = int.Parse(inputArray[1]);
                string OperatorList = "+-*/";
                methodCalc(Input1, Input2, OperatorList, input);
            }
        }
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