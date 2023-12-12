**IterationStatement README**

This simple C# program demonstrates the use of iteration statements to generate a multiplication table for a user-inputted number. Below is a brief explanation of the code:
Program Functionality:

    **User Input:**
        The program prompts the user to "Give a number."
        The entered number is stored in the variable Intake after attempting to parse the user's input as an integer.

    **Multiplication Table:**
        The program uses a while loop with a for loop inside to generate a multiplication table.
        The multiplication table is calculated for the entered number (Intake) up to 15.
        The results are printed to the console, showing each multiplier and the corresponding result.

    **Loop Termination:**
        The program uses a boolean variable TurnOFF to control the loop.
        The loop continues until TurnOFF is set to true.

**How to Use:**

    Run the program.
    Enter a number when prompted.
    The program will display the multiplication table for the entered number up to 15.
    The loop will continue to run until the program is terminated.

**Additional Information:**

    The program includes basic error handling for invalid input. If the user enters a non-integer value, the program will default to 0.
    This code is intended for educational purposes and can be a starting point for more complex programs involving loops and user input.



**IterationStatement2 README**

This C# program explores iteration statements, specifically using loops and conditionals. The program performs the following tasks:
Program Overview:

    **User Input:**
        Requests the user to input a number.
        Determines whether the entered number is even or odd.

    **Number Generation:**
        Uses a do-while loop to populate a list (numbers) with sequential integers starting from 1 up to 100.
        Continues adding numbers to the list in a while loop until the count reaches 200.

    **Display Results:**
        Prints the list of numbers in ascending order using a foreach loop.

    **Reverse Display:**
        Prints the list of numbers in descending order using a for loop.

**How to Use:**

    Run the program.
    Enter a number when prompted.
    The program will inform you if the entered number is even or odd.
    It generates a list of numbers from 1 to 200, inclusive.
    Displays the list in increasing order using a foreach loop.
    Displays the list in decreasing order using a for loop.

**Additional Information:**

    The program employs a combination of do-while, while, foreach, and for loops to showcase different iteration techniques.
    The code includes basic error handling for non-integer user input when using int.TryParse.
    This code is intended for educational purposes and can be modified or expanded for more complex scenarios.





**IterationStatement3 README**

This C# program demonstrates the use of iteration statements, specifically focusing on loops and decision-making based on user input. The program provides a menu-driven interface with various options:

    **Give a number between -10 and 10:**
        Prompts the user to enter a number between -10 and 10.
        Calls methods to display the multiplication table of the entered number and determine whether it's positive or negative.

    **Print Numbers between 1000 and -1000:**
        Prints numbers between -1000 and 1000 using a for loop.

    Multiples of 3:
        Prints multiples of 3 up to 999.

    **Even, Odds, Positive or Negative:**
        Prompts the user to enter two numbers.
        Determines if each number is even or odd, positive or negative, and checks if they are equal.

    **Can you Vote?:**
        Prompts the user to enter their age.
        Determines if the user is old enough to vote (age 18 or older).

    **EXIT:**
        Exits the program.

**How to Use:**

    Run the program.
    Choose an option from the menu by entering the corresponding number.
    Follow the prompts for each selected option.
    The program will continue to run until the user chooses to exit.

**Additional Information:**

    The program utilizes do-while loops for repeated user interactions.
    Methods are used to modularize code for specific functionalities.
    The program includes error handling for invalid user inputs.