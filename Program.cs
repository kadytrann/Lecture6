using System.Runtime.InteropServices;

namespace Lecture6
    /* 
     Kady Tran
     4.22.24 */
{
    internal class Program
    {
        static void Main(string[] args)
        {


        } // main

        // While Example
        public static void WhileLoopExample()
        {
            int count = 0;


            // while (condition)
            while (count <= 10)
            {
                Console.WriteLine(count);
                count++; // Incrementer

            } // while example
        }

        // Validating Numbers 

        public static void ValidateUserInput()
        {
            // Declare variables to store user input and a boolean flag for valid input
            string input;
            int number = 0;
            bool isValid = false;

            // The while loop will execute until a valid input is provided
            while (!isValid)
            {
                // Prompt the user to enter a number
                Console.Write("Enter a number: ");
                // Get the user input and store it in the input variable
                input = Console.ReadLine();

                // Try to parse the input string to an integer
                // Try parse type.TryParse(string, out expected output variable)
                if (int.TryParse(input, out number))
                {
                    // If the parsing is successful, set the isValid flag to true
                    isValid = true;
                }
                else
                {
                    // If the parsing fails, display an error message
                    Console.WriteLine("Invalid input. Please try again.");
                }
            }

            // After a valid input is provided, display the entered number
            Console.WriteLine($"You entered: {number}");
        } // Validate user input


        // Try Parse

        public static void TryParse()
        {
            Console.Write("Please enter a whole number: ");
            int number = 0;
            bool isValid = false;

            while (!isValid)
            {
                string userResponse = Console.ReadLine();

                // If the user enters in a valid number
                // int.TryParse will return true
                // Inside of our if statement, we will switch is valid to true
                if (int.TryParse(userResponse, out number))
                {
                    isValid = true;
                }
                else
                {
                    // This is if the user did not enter a valid number, this will prompt the message
                    Console.WriteLine("Please enter a valid whole number: ");
                };

            }

            // If a variable is not initialized by the time it is used, C# compiler will throw an error
            // To fight the error, give the variable a value
            Console.WriteLine($"Your number was {number}");
        }// End of try parse example

        // Do While

        public static void DoWhileExample()
        {
            int count = 11;

            // do while
            // It does something once before it evaluates the condition, HUGE difference between a while and a do. It depends if you need your code to run at least once, or are you fine with it checking first before it runs

            do
            {
                Console.WriteLine(count);
            } while (count <= 10);


            Console.WriteLine("This is after our while loop");
        } // End of do while example


        // Do While Example
        // Password Checker

        public static void PasswordValidation()
        {
            string password;
            bool isValidPassword;

            string userPassword = "Cram";


            // The do while is more efficient and has less "unnecessary" code
            do
            {
                Console.Write("Enter your password: ");
                password = Console.ReadLine();
                // Checking to see if password is valid
                isValidPassword = password == userPassword;

            } while (!isValidPassword);

            Console.WriteLine("You have logged in");


            // This is the more inefficient way

            /*// putting a ! to run if the condition is false
            // If password is INVALID, continue to ask user for their password
            while(!isValidPassword)
            {
                Console.WriteLine("Invalid Password.");
                Console.Write("Enter your password: ");
                password = Console.ReadLine();
                isValidPassword = password == userPassword;
            }*/




            /* // Declare variables to store the password and a boolean flag for valid password
             string password;
             bool isValidPassword;

             // Set the correct password as "Cram"
             string myPassword = "Cram";

             // The do-while loop will execute at least once
             do
             {
                 // Prompt the user to enter a password
                 Console.Write("Enter a password (minimum 8 characters, at least one uppercase letter and one number): ");
                 // Get the user input and store it in the password variable
                 password = Console.ReadLine();

                 // Check if the entered password matches the correct password
                 isValidPassword = myPassword == password;
                 if (!isValidPassword)
                 {
                     // If the password is incorrect, display an error message
                     Console.WriteLine("Invalid password. Please try again.");
                 }
             } while (!isValidPassword); // The loop will continue executing until a valid password is entered */

        } // PasswordValidation

        // For Loop
        // For Loop Example

        public static void ForLoopExample()
        {
            // For Loop

            /*// Declared our variable outside of our loop
            int count = 0;

            // Checked our condition (if true, it ran)
            while(count < 10)
            {
                // Code to run
                Console.WriteLine($"Count : {count}");

                // Incremented our variable 
                count++;
            } */

            /*// keyword for
            for (int i = 0;  // Declare our variable
                i < 10; // Condition
                i++ // Increment
                )
                
            {
                Console.WriteLine(i);

            } // for */

            // Start at 450
            // End at -25
            // Change by - 4

            // Since i++ increases by 1, you can do i += 5, which will increase by 5
            // You can decrease by using -= 
            for (int i = 450; i > -25; i -= 4)
            {
                Console.WriteLine(i);
            }// End of for loop example

        }

        // Sum and Average Numbers
        public static void SumAndAverageNumbers()
        {
            // For Loop

            // typing out "for" and tabbing out twice will give you the shorthand (helpful for for loops)

            // Declaring sum out here can be accessed inside while we cant access anything declared inside of the for loop scope
            int sum = 0;
            int count = 0;


            // To get the average: sum of of numbers / count of numbers

            for (int i = 0; i < 300; i += 5)
            {
                //int sum = 0; // When you declare things inside of here, it's going to keep resetting it over and over again. It's basically killing it off and then reinitializing it, be careful about this

                // Adding i to the sum variable

                sum += i;
                // Count is keeping track of how many times we loop
                count++;

            }

            // Put this outside the loop to display the result of the sum
            Console.WriteLine($"Sum: {sum} - Count: {count}");

            double avg = (double)sum / count;

            Console.WriteLine($"Average: {avg}");
        } // end of SumAndAverageNumbers()



        public static void MathClassExample()
        {
            // Math Library
            // Area = pi * r^2



            double radius = 2.5;
            int radiusInt = (int)radius;

            double areaDouble = Math.PI * (Math.Pow(radius, 2));
            double areaInt = Math.PI * (Math.Pow(radiusInt, 2));

            Console.WriteLine("Area with Double: " + areaDouble);
            Console.WriteLine("Area with Int " + areaInt);
        } // MathClassExample

        /* EXTRA
        // Iterative Loops
        // While
        // Do While
        // For

        // Foreach

        // --------------------------
        // Method
         */

        public static void ArrayExample()
        {
            string student1Name = "Coby";
            string student2Name = "Hoang";
            string student3Name = "Vicky";

            // [] is an array
            string[] students = new string[7];
            students[0] = "Coby";
            students[1] = "Brian";
            students[2] = "Vitalli";
            students[3] = "Vicky";
            students[4] = "Carla";
            students[5] = "Hoang";
            students[6] = "Will";

            // index

            for (int i = 0; i < students.Length; i += 2)
            {
                int index = i;
                string currentStudent = students[index];
                Console.WriteLine($"{index} : {currentStudent}");
            }
        }



    }// class
}// name space
