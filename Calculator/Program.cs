// The integer variable stores the first number


// The integer variable stores the second number


//Mote that the integer type is used for "result" variable

        CalculatorApp();

        void CalculatorApp()
        {
            // Declare variables and initialize to 0
            int firstNumber = 0;
            int secondNumber = 0;
            int result = 0;
            int choice = 0;

            // Ask for the first number
            Console.WriteLine("Type in the first number:");
            firstNumber = Convert.ToInt32(Console.ReadLine());

            // Ask for the second number
            Console.WriteLine("Type the second number:");
            secondNumber = Convert.ToInt32(Console.ReadLine());

            // Display the menu
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1 - Add");
            Console.WriteLine("2 - Subtract");
            Console.WriteLine("3 - Divide");
            Console.WriteLine("4 - Multiply");

            // Get user's choice
            choice = Convert.ToInt32(Console.ReadLine());

            // Perform the calculation
            if (choice == 1)
            {
                result = firstNumber + secondNumber;
                Console.WriteLine($"Adding {firstNumber} and {secondNumber} equals {result}");
            }
            else if (choice == 2)
            {
                result = firstNumber - secondNumber;
                Console.WriteLine($"Subtracting {secondNumber} from {firstNumber} equals {result}");
            }
            else if (choice == 3)
            {
                result = firstNumber / secondNumber;
                Console.WriteLine($"Dividing {firstNumber} by {secondNumber} equals {result}");
            }
            else if (choice == 4)
            {
                result = firstNumber * secondNumber;
                Console.WriteLine($"Multiplying {firstNumber} and {secondNumber} equals {result}");
            }
            else
            {
                Console.WriteLine("You did not select a valid number between 1-4");
            }
        }