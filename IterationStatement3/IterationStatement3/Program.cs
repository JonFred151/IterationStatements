
// this is the heating up sections of exercise three promtp: Write a method to display the multiplication table (from 1 to 12) of a given integer
namespace IterationStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            // variables
            int Intake;
            bool TurnOFF = false;
            //asked for a number
            Console.WriteLine("Give a number.");
            //intakes number
            int.TryParse(Console.ReadLine(), out Intake);

            //loops to print multiple of numbers
            while (TurnOFF != true)
            {
                // for loop to print the multiplcation 
                for (int i = 1; i < 13; i++)
                {
                    int Holder;

                    Holder = Intake * i;                    
                    Console.WriteLine( Holder);


                }


                TurnOFF = true;




            }





        }
    }
}