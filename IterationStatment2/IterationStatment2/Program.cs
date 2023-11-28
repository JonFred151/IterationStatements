namespace IterationStatment2
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            var numbers = new List<int>();
            int Num = 0;

            int Num2;

            Console.WriteLine("Give a number");
            int.TryParse(Console.ReadLine(), out Num2);
            if (Num2%2 == 0) 
            {
                Console.WriteLine("Number is even \n");
            }
            else
            { 
                Console.WriteLine("Number is odd. \n");
            }

            do
            {
                Num++;
                numbers.Add(Num);
                
            }
            while (Num < 100);

            while (Num < 200)
            {
                Num++;
                numbers.Add(Num);
            }


            Console.WriteLine("Increase:");


            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("");
            Console.WriteLine("Decrease:");

            for(int i = 199; i <= numbers.Count && i >= 0; i--)
            {
                Console.Write(numbers[i]+"\n");
            }
        }
    }
}








