

namespace IterationStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            int Intake;
            bool TurnOFF = false;
            Console.WriteLine("Give a number.");
                 int.TryParse(Console.ReadLine(), out Intake);

            while(TurnOFF != true)
            {
                            
                    for (int i = 1; i < 16; i++)
                    {
                        int Holder;
                       
                        Holder = Intake * i;
                       // Console.WriteLine(Holder );
                        Console.WriteLine(i + " " + Holder );
                        
                          
                    }
                    
                
                TurnOFF = true;




            }



           
            
        }
    }
}