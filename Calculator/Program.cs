// The integer variable stores the first number


// The integer variable stores the second number


//Mote that the integer type is used for "result" variable


Console.WriteLine("Type in the first number followed by the Enter key");
int firstNumber = Convert.ToInt32(Console.ReadLine());

//Ask the user to type the seconde number.
Console.WriteLine("Type the second number , and then press enter");
int secondNumber =Convert.ToInt32(Console.ReadLine());

//perform the caculation
int result = firstNumber + secondNumber;

//output the answer to the console
Console.WriteLine("Adding {0} and {1} give the answer {2}", firstNumber, secondNumber, result);

