namespace AOC2015Day1
{
    class Program
    {
        static string PartOne(string data)
        {
            int floor = 0;
            foreach (char c in data)
            {
                if (c == '(')
                {
                    floor++;
                }
                else if (c == ')')
                {
                    floor--;
                }
            }
            return Convert.ToString(floor);
        }
        static string PartTwo(string data)
        {
            int floor = 0;
            int instructions = 0;
            foreach (char c in data)
            {
                instructions++;
                if (c == '(')
                {
                    floor++;
                }
                else if (c == ')')
                {
                    floor--;
                }
                if (floor < 0)
                {
                    break;
                }
            }
            return Convert.ToString(instructions);
        }
        static void Main()
        {
            string file = File.ReadAllText(@"../../../input.txt");
            Console.WriteLine(PartOne(file));
            Console.WriteLine(PartTwo(file));
        }
    }
}