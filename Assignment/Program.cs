using System;


namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //---------------------- Solve Assignment Day04 ------------------------

            #region Q1
            /*
             Write a program that takes a number from the user then print yes if that 
             number can be divided by 3 and 4 otherwise print no. 
                Example (1) 
                Input: 12  
                Output: Yes 
                Example (2) 
                Input: 9  
                Output: No 
             */

            Console.Write("Please Enter Your Number: ");
            bool isParse01 = int.TryParse(Console.ReadLine(), out int num);
            if (isParse01)
            {
                if (num % 3 == 0 && num % 4 == 0)
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("No");
                }
            }
            else
            {
                Console.WriteLine("Number Not Vaild");
            }
            #endregion

            #region Q2

            /*
             Write a program that allows the user to insert an integer then print 
                negative if it is negative number otherwise print positive. 
            Example (1) 
            Input: -5 
            Output: negative 
            Example (2) 
            Input: 10 
            Output: positive 
             */


            Console.Write("Please Enter Your Number: ");
            bool isParse02 = int.TryParse(Console.ReadLine(), out int num01);

            if (isParse02)
            {
                if (num01 < 0)
                {
                    Console.WriteLine("Negative");
                }
                else if (num01 > 0)
                {
                    Console.WriteLine("Positive");
                }
                else
                {
                    Console.WriteLine("Not Positive And Not Negative");
                }
            }
            else
            {
                Console.WriteLine("Number Not Vaild");
            }


            #endregion

            #region Q3

            /*
             3- Write a program that takes 3 integers from the user then prints the max 
                element and the min element. 
            Example (1) 
            Input:7,8,5 
            Output: 
            max element = 8 
            min element = 5 
            Example (2) 
            Input: 3 6 9 
            Outputs: 
            Max element = 9 
            Min element = 3 
             */

            Console.Write("Enter The First Number# ");
            bool isParse03 = int.TryParse(Console.ReadLine(), out int num02); // 10
            Console.Write("Enter The Second Number# ");
            bool isParse04 = int.TryParse(Console.ReadLine(), out int num03); // 7
            Console.Write("Enter The Third Number# ");
            bool isParse05 = int.TryParse(Console.ReadLine(), out int num04); // 3

            if (isParse03 && isParse04 && isParse05)
            {
                int max = num02;
                if (num03 > max) max = num03;
                if (num04 > max) max = num04;

                int min = num02;
                if (num03 < min) min = num03;
                if (num04 < min) min = num04;

                Console.WriteLine($"The Max Number Is: {max}");
                Console.WriteLine($"The Min Number Is: {min}");


            }

            #endregion

            #region Q4

            /*
             Write a program that allows the user to insert an integer number then 
                check If a number is even or odd. 
             */

            Console.Write("Please, Enter the Number# ");
            bool isParse = int.TryParse(Console.ReadLine(), out int number);
            if (isParse)
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine("Number is Even");
                }
                else
                {
                    Console.WriteLine("Number is  Odd");
                }
            }
            else
            {
                Console.WriteLine("The number Is InValid");
            }

            #endregion


            #region Q5

            /*
             5- Write a program that takes character from the user then if it is a vowel 
                chars (a,e,I,o,u) then print (vowel) otherwise print (consonant). 
                Example (1) 
                Input: O 
                Output: vowel 
                Example (2) 
                Input: b 
                Output: Consonant 
             */

            Console.Write("Please Enter Your Character: ");
            bool isParse06 = char.TryParse(Console.ReadLine(), out char charcater);
            if (isParse06)
            {
                if (charcater == 'a' || charcater == 'e' || charcater == 'i' || charcater == 'o' || charcater == 'u')
                {
                    Console.WriteLine("charcater Is vowel");
                }
                else
                {
                    Console.WriteLine("consonant");
                }

            }
            else
            {
                Console.WriteLine("charcater Is Invaild");
            }


            #endregion


            #region Q6

            /*
             6- Write a program that allows the user to insert an integer then print all 
                numbers between 1 to that number. 
            Example  
            Input: 5 
            Output: 1, 2, 3, 4, 5 
             */
            Console.Write("Please, Enter the Number# ");
            bool isParse07 = int.TryParse(Console.ReadLine(), out int number01);

            for (int i = 1; i <= number01; i++)
            {
                if (i < number01)
                {
                    Console.Write($"{i} , ");
                }
                else if (i == number01)
                {
                    Console.Write($"{i}");
                }
            }

            #endregion

            #region Q7

            /*
             7- Write a program that allows the user to insert an integer then  
                print a multiplication table up to 12. 
                Example 
                Input: 5 
                Outputs: 5 10 15 20 25 30 35 40 45 50 55 60 
             */

            Console.Write("Please, Enter the Number# ");
            bool isParse08 = int.TryParse(Console.ReadLine(), out int number02);

            if (isParse08)
            {
                for (int i = 1; i <= 12; i++)
                {
                    Console.Write($"{i * number02} ");
                }
            }
            else
            {
                Console.WriteLine("Number is not valid");
            }

            #endregion

            #region Q8

            /*
             8- Write a program that allows to user to insert number then print all even 
                numbers between 1 to this number 
                Example: 
                Input: 15 
                Output: 2 4 6 8 10 12 14 
             */
            Console.Write("Please, Enter the Number# ");
            bool isParse09 = int.TryParse(Console.ReadLine(), out int number03);
            if (isParse09)
            {
                Console.WriteLine("------ Even Numbers Is ----------");
                for (int i = 1; i < number03; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write($"{i} ");
                    }

                }

            }

            #endregion


            #region Q9

            /*
               Write a program that takes two integers then prints the power. 
                Example: 
                Input: 4 3 
                Output: 64 
                Hint: how to calculate 4^3 = 4 * 4 * 4 =64 

             */
            Console.Write("Please, Enter the base Number1# ");
            bool isParse10 = int.TryParse(Console.ReadLine(), out int number04);
            Console.Write("Please, Enter the exponent Number2# ");
            bool isParse20 = int.TryParse(Console.ReadLine(), out int number05);
            int result = 1;
            if (isParse10 && isParse20)
            {
                for (int i = 0; i < number05; i++)
                {
                    result *= number04;  // result = 4 * 4 * 4
                }

            }

            Console.WriteLine(result);


            #endregion

            #region Q10

            /*
              Write a program to enter marks of five subjects and calculate total, 
                average and percentage. 
               Example 
                Input: - Enter Marks of five subjects: 95 76 58 90 89 
                Output: Total marks = 408 
                        Average Marks = 81 
                        Percentage = 81 
             */

            Console.Write("Enter The Number Of marks: ");
            bool isParse30 = int.TryParse(Console.ReadLine(), out int number06);
            int result_sum = 0, Avg = 0, Percentage = 0;
            if (isParse08)
            {

                for (int i = 1; i <= number04; i++)
                {
                    Console.Write($"Enter The Number Of mark_{i}: ");
                    bool isParse40 = int.TryParse(Console.ReadLine(), out int number07);
                    if (isParse40 && (number07 >= 0 && number07 <= 100))
                    {
                        result_sum += number05;
                    }
                    else
                    {
                        Console.WriteLine("The Mark is Not Vaild");
                        i--;
                    }
                }

                Avg = (result_sum) / number04;
                Percentage = (result_sum * 100) / (number06 * 100);

                Console.WriteLine($"The Sum Of All Marks Is: {result_sum}");
                Console.WriteLine($"The Average Is: {Avg}");
                Console.WriteLine($"the Percentage Is: {Percentage}");

            }
            #endregion


            #region Q11

            /*
            11- Write a program to input the month number and print the number of days in 
            that month. 
                Example 
                Input: Month Number: 1 
                Output: Days in Month: 31
             */

            Console.Write("Please, Enter The Year ");
            bool isParse50 = int.TryParse(Console.ReadLine(), out int year);
            Console.Write("Please, Enter the number of month ");
            bool isParse60 = int.TryParse(Console.ReadLine(), out int month);


            int days = DateTime.DaysInMonth(year, month);

            Console.WriteLine(days);
            #endregion


            #region Q12

            /*
             * 12- Write a program to create a Simple Calculator. 
             */

            Console.WriteLine("-------------- Calculator -------------------");
            Console.WriteLine("[1] (+) operation");
            Console.WriteLine("[2] (-) operation");
            Console.WriteLine("[3] (*) operation");
            Console.WriteLine("[4] (/) operation");
            Console.WriteLine("[4] (%) operation");
            Console.WriteLine("Enter The number of Operation");
            bool numOp = int.TryParse(Console.ReadLine(), out int numOperation);
            Console.WriteLine("Enter Operad num1: ");
            bool isnum1 = double.TryParse(Console.ReadLine(), out double num1);
            Console.WriteLine("Enter Operad num2: ");
            bool isnum2 = double.TryParse(Console.ReadLine(), out double num2);

            if (numOperation == 1)
            {
                Console.WriteLine($"The sum Of Numbers is: {num1 + num2}");
            }
            else if (numOperation == 2)
            {
                Console.WriteLine($"The subtraction Of Numbers is: {num1 - num2}");

            }
            else if (numOperation == 3)
            {
                Console.WriteLine($"The multiplucation Of Numbers is: {num1 * num2}");

            }
            else if (numOperation == 4)
            {
                Console.WriteLine($"The division Of Numbers is: {num1 / num2}");
            }
            else
            {
                Console.WriteLine($"The modules Of Numbers is: {num1 % num2}");
            }

            #endregion

            #region Q13

            /*
               Write a program to allow the user to enter a string and print the REVERSE 
               of it
            */

            Console.Write("Enter Your String: ");
            string word = Console.ReadLine(); // Ahmed => 5-1 = 4
            bool ContainsDigits = word.Any(char.IsDigit);
            if (!ContainsDigits)
            {
                string result01 = "";
                for (int i = word.Length - 1; i >= 0; i--)
                {
                    result01 += word[i];
                }

                Console.WriteLine(result01);
            }
            else
            {
                Console.WriteLine("The String Must No Contain Numbers");
            }
            #endregion

            #region Q14

            /*
              Write a program to allow the user to enter int and print the REVERSED of 
                it. 
             */
            int result02 = 0, digits;

            Console.WriteLine("Enter Your Number: ");
            bool isConverted = int.TryParse(Console.ReadLine(), out digits);

            if (isConverted)
            {

                while (digits > 0)
                {
                    result02 = digits % 10 + result * 10;
                    /*
                     * 3 + 0 = 3
                     * 2 + 30 = 32 
                     * 9 + 320 = 329
                     */
                    digits /= 10; // 92 -> 9 -> 0
                }

                Console.WriteLine($"Reveresd Number Is: {result02}");
            }
            else
            {
                Console.WriteLine("Enter a Vaild Number");
            }








            #endregion


            #region Q15

            /*
                15- Write a program in C# Sharp to find prime numbers within a range of 
                numbers. 
 
                Test Data : 
                Input starting number of range: 1 
                Input ending number of range : 50 
                Expected Output : 
                The prime number between 1 and 50 are : 
                2 3 5 7 11 13 17 19 23 29 31 37 41 43 47 
             */

            Console.WriteLine("--------- Display The Prime Numbers --------------");
            Console.Write("starting number of range is:");
            bool isCon01 = int.TryParse(Console.ReadLine(), out int startNum);
            Console.Write("Ending number of range is:");
            bool isCon02 = int.TryParse(Console.ReadLine(), out int endNum);

            Console.WriteLine($"Prime numbers between {startNum} and {endNum}:");
            if (isCon01 && isCon02 && startNum >= 2 && endNum >= startNum)
            {
                for (int i = startNum; i <= endNum; i++)
                {
                    bool isPrime = true;
                    for (int j = 2; j <= Math.Sqrt(i); j++)
                    {


                        if (i % j == 0)
                        {
                            isPrime = false;
                            break;
                        }

                    }

                    if (isPrime)
                    {

                        Console.Write($"{i}  ");
                    }

                }
            }
            else
            {
                Console.WriteLine("Invaild Numbers");
            }



            #endregion

            #region Q16

            /*
             * 16- Create a program that asks the user to input three points (x1, y1), (x2,y2), and (x3, y3), and determines whether these points lie on a single 
                straight line.
             */

            // (y2 - y1) / (x2 - x1) == (y3 - y2) / (x3 - x2)


            Console.Write("Enter The Poin One X1: ");
            bool isCon03 = int.TryParse(Console.ReadLine(), out int x1);
            Console.Write("Enter The Poin One Y1: ");
            bool isCon04 = int.TryParse(Console.ReadLine(), out int y1);
            Console.WriteLine("-----------------------------------------");
            Console.Write("Enter The Poin One X2: ");
            bool isCon05 = int.TryParse(Console.ReadLine(), out int x2);
            Console.Write("Enter The Poin One Y2: ");
            bool isCon06 = int.TryParse(Console.ReadLine(), out int y2);
            Console.WriteLine("-----------------------------------------");
            Console.Write("Enter The Poin One X3: ");
            bool isCon07 = int.TryParse(Console.ReadLine(), out int x3);
            Console.Write("Enter The Poin One Y3: ");
            bool isCon08 = int.TryParse(Console.ReadLine(), out int y3);
            Console.WriteLine("-----------------------------------------");



            if (isCon03 && isCon04 && isCon05 && isCon06 && isCon07 && isCon08)
            {
                // Check for division by zero first
                if ((x2 - x1) == 0 || (x3 - x2) == 0)
                {
                    if ((x2 - x1) == 0 && (x3 - x2) == 0)
                    {
                        Console.WriteLine("Points lie on a vertical straight line");
                    }
                    else
                    {
                        Console.WriteLine("Points are NOT on the same straight line");
                    }
                }
                else
                {
                    double slope1 = (double)(y2 - y1) / (x2 - x1);
                    double slope2 = (double)(y3 - y2) / (x3 - x2);

                    if (slope1 == slope2)
                    {
                        Console.WriteLine("Points lie on a single straight line");
                    }
                    else
                    {
                        Console.WriteLine("Points are NOT on the same straight line");
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter valid integers.");
            }
            #endregion

            #region Q17

            /*
             17- Within a company, the efficiency of workers is evaluated based on the 
                duration required to complete a specific task. A worker's efficiency level is 
                determined as follows:  - If the worker completes the job within 2 to 3 hours, they are considered 
                highly efficient.  - If the worker takes 3 to 4 hours, they are instructed to increase their 
                speed.  - If the worker takes 4 to 5 hours, they are provided with training to 
                enhance their speed.  - If the worker takes more than 5 hours, they are required to leave the 
                company.  
                To calculate the efficiency of a worker, the time taken for the task is 
                obtained via user input from the keyboard. 
             */


            Console.WriteLine("---------------- the efficiency of workers -----------------");
            Console.Write("Please enter the number of hours taken to complete the task: ");
            bool isNumHour = int.TryParse(Console.ReadLine(), out int numberOfhours);

            if (isNumHour)
            {
                if(numberOfhours >= 2 && numberOfhours < 3)
                {
                    Console.WriteLine("Highly Efficient");
                }else if (numberOfhours >= 3 && numberOfhours < 4)
                {
                    Console.WriteLine("You need to increase your speed.");
                }else if (numberOfhours >= 4 && numberOfhours < 5)
                {
                    Console.WriteLine("Provide training");
                }
                else
                {
                    Console.WriteLine("Leave the company");
                }

            }else
            {
                Console.WriteLine("The Number is InVaild");
            }

            #endregion

        }
    }
}