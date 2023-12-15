namespace IterationStatement3
{
    class Program
    {
        static void Main(string[] args)
        {
            // variables
            int Num1;           
            int Choice;
            // do while loop to continue the program until user is ready to leave
            do
            {

                Console.WriteLine("Make a selection: \n 0:Give a number between -10 and 10 \n 1:Print Number between 1000 and -1000\n 2:Multiple of 3 \n 3:Even, Odds, Positive or negative? \n 4:Can you Vote? \n 5:EXIT");
                if (int.TryParse(Console.ReadLine(), out Choice))
                {
                    switch (Choice)
                    {
                        // Case 0 is both warming up section. 
                        case 0:
                            // Does a loop until a number is enter in that is between 10 and -10 
                            do
                            {
                                Console.Clear();
                                Console.WriteLine("Give a number between -10 and 10.");
                                if (int.TryParse(Console.ReadLine(), out Num1))
                                {
                                    if (Num1 >= -10 && Num1 <= 10)
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Number is not in the range");
                                    }

                                }
                                else
                                {
                                    Console.WriteLine("Invaild input. Please Enter a valid number");
                                }
                            } while (true);
                            // Calling the method MultiTable to multiple the giving number and to check if the numbers is positive or megivite 
                            MultiTable(Num1);
                            CheckIntegar(Num1);
                            Console.ReadKey();
                            Console.Clear();
                            break;
                       // case 1 is printing the numbers between 1000 and -1000 
                        case 1:
                            Console.Clear ();   
                            Console.WriteLine("Printing numbers....Please wait....");
                            for (int i = -1000; i <= 1000; i++)
                            {
                                Console.WriteLine($"{i}");

                            }





                            Console.ReadKey ();
                            Console.Clear();    
                            break;
                       //case 2 is multiple of 3 to 999
                        case 2:
                            Console.Clear ();
                            int k = 1;
                            Console.WriteLine("\nMultiple of 3");
                            for (int i = 3; i<= 999; i+= 3)
                            {
                                
                                Console.WriteLine($"{i} Is the Multiple of {k} ");
                                k++;
                            }
                            Console.ReadKey ();
                            Console.Clear();
                        break;
                        // case 3 is the two number are equal to each other are they positive or negative, and if they are even or odd
                        case 3:
                            Console.Clear ();
                            Console.WriteLine("Enter a number");
                            if(int.TryParse(Console.ReadLine(), out Num1))
                            {
                                Console.WriteLine("Enter a second number");
                                if (int.TryParse(Console.ReadLine(), out int Num2))
                                {
                                    Console.WriteLine($"{Num1} is {EvenOdd(Num1)} and is {PosNeg(Num1)}!");
                                    Console.WriteLine($"{Num2} is {EvenOdd(Num2)} and is {PosNeg(Num2)}!");
                                    if(AreEqual(Num1, Num2))
                                    {
                                        Console.WriteLine($"{Num1} and {Num2} are Equal");
                                    }
                                    else
                                    {
                                        Console.WriteLine($"{Num1} and {Num2} are NOT Equal");
                                    }
                                    
                                }
                                else
                                {
                                    Console.WriteLine("INVALID INPUT FOR THE SECOND NUMBER.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("INVALID INPUT FOR THE FIRST NUMBER");
                            }
                            Console.ReadKey();
                            Console.Clear();
                        break;
                        // case 4 is are you old enough to vote
                        case 4:
                            Console.Clear ();
                            Console.WriteLine("Enter your Age");
                            if (int.TryParse(Console.ReadLine(), out Num1))
                            {
                                if (Num1 >= 18)
                                {
                                    Console.WriteLine($"Your  age  is {Num1}. You can vote!!");
                                }
                                else
                                {
                                    Console.WriteLine($"Your age is {Num1}. You can not vote!! Please wait {18 - Num1}");
                                }
                            }
                            else
                            {
                                Console.WriteLine("INVALID INPUT!!");
                            }
                            Console.ReadKey();
                            Console.Clear();
                         break;
                        //case 5 exit the program and end the do while loop
                        case 5:
                            Console.Clear ();
                            Console.WriteLine("Exiting the Program. Please wait......");
                            break;
                        // keep the switch for having an invalid input 
                        default:
                            Console.WriteLine("Invalid Choice. Please select the given option!");
                            Console.ReadKey();
                            Console.Clear();   
                            break;
                    }




                }
                else { Console.WriteLine("Invalid input try again! "); Console.ReadKey(); Console.Clear(); }

            } while (Choice != 5);
            



            // end of MAIN
        }       
           
           


        private static void MultiTable(int Num1)
        {
            bool TurnOFF = false;  
            //loops to print multiple of numbers
            while (TurnOFF != true)
            {
                // for loop to print the multiplcation 
                for (int i = 1; i < 13; i++)
                {
                    int Holder;
                    Holder = Num1* i;
                    Console.WriteLine($"Here is {Holder} Multiple by {i} \n");
                }
                TurnOFF = true;
            }
        }

        private static void CheckIntegar(int Num)
        {
            if (Num > -10 && Num < 0)
            {
                Console.WriteLine($"{Num} is an Negitive number");
            }
            else 
            {
                Console.WriteLine($"{Num} is an positive number");
            }
        }
         static string EvenOdd(int Num)
        {
            return (Num % 2 == 0) ? "Even" : "Odd";
        }

        static string PosNeg(int Num)
        {
            return (Num >= 0) ? "Positive" : "Negative";
        }

        static bool AreEqual(int Num1, int Num2)
        {
            return Num1 == Num2;   
        }



    }
}