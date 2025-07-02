using System.Text;
namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Evalution of switch in c#

            #region c#.1 -> c#.6
            /* 
             * the switch statement was a quite basic and Worked only With integeral types such as int , char , byte , long
             * It Could only handle primitive types or enums
             * Only constant expressions are allowed in case labels
             */
            #endregion

            #region c#.7 Pattern Matching And Case Guard

            // Pattern Matching on Type
            object obj = 10.588; // Boxing in heap

            switch (obj)
            {
                case int value: // unboxing Stored in Stack
                    Console.WriteLine("Integer");
                    break;
                case double value:
                    Console.WriteLine("Double");
                    break;
                case decimal value:
                    Console.WriteLine("Decimal");
                    break;
                default:
                    Console.WriteLine("No Match");
                    break;

            }

            // Case Guard (when) -> No Jump Table Will Be Created
            switch (obj)
            {
                case int value when value < 10:
                    Console.WriteLine("Integer is less than 10");
                    break;
                case int value when value > 10:
                    Console.WriteLine("Integer is greater than 10");
                    break;
                case double value when value > 5.6 && value < 11:
                    Console.WriteLine("Integer is between 5.5 && 11");
                    break;
            }


            ///*----------- User Define Type ---------------- */

            obj = new Person()
            {
                Id = 1,
                Name = "Ahmed",
                Age = 21
            };

            switch (obj)
            {
                case int value when value < 10:
                    Console.WriteLine("Integer is less than 10");
                    break;
                case string value:
                    Console.WriteLine("String");
                    break;
                case Person value when value.Id == 1 && value.Name == "Ahmed":
                    Console.WriteLine("Person");
                    break;
            }



            #endregion




            #region c# 8.0 [Pattern Matching without alias name - switch Expressions - Property Pattern]

            // Pattern Matching without alias name
            object num = 5;

            switch (num)
            {

                case int when (int)num < 10:
                    Console.WriteLine("Interger Is Less Than 10");
                    break;
                case int when (int)num > 10:
                    Console.WriteLine("Interger Is greater Than 10");
                    break;
                case decimal:
                    Console.WriteLine("Decimal");
                    break;

                case double when (double)num > 5.6 && (double)num < 10.7:
                    Console.WriteLine("Double Between 5.6 & 10.7");
                    break;

            }

            // switch Expressions[Constant Pattern - Discard Pattern]
            //  Example One
            Console.WriteLine("Please Enter option Number: "); ;
            string option = Console.ReadLine();
            string massage;

            massage = option switch
            {
                "1" => "Option01",
                "2" => "Option02",
                "3" => "Option03",
                _ => "Invalid Option"
            };

            Console.WriteLine(massage);
           // Example two
            Person person = new Person()
            {
                Id = 1,
                Name = "Ahmed",
                Age = 20
            };

            string message = person switch
            {
                { Name: "Ahmed", Age: 20 } => "Hello Ahmed",
                { Name: "omar" } => "Hello Omar",
                _ => "We Don't Know You"
            };
            Console.WriteLine(message);
           // Example three
            // Nullable type

            int? x = 0;

            string massage01 = x switch
            {
                null => "Null Value",
                int num01 when num01 > 0 => "Positive number",
                int num01 when num01 < 0 => "negative number",
                0 => "Zero"
            };

            Console.WriteLine(massage);

            #endregion

            #region c# 9.0 [switch Expression With Relational Patterns - Logical Pattern - Enhanced Property Matching]
            // Relational pattern
           

            string message05 = x switch
            {
                < 10 => "Less Than 10",
                >= 10 and <= 20 => "Beteen 10 and 20",
                > 20 => "Greater Than 20"
            };

            // Logical Pattern

            int x01 = -40;

            string message01 = x switch
            {
                > 0 and < 10 => "number between 1 and 10",
                >= 10 and <= 20 => "Beteen 10 and 20",
                0 => "Number Is Zero",
                > 20 or < 0 => "number outside the range"
            };

            Console.WriteLine(message01);
            // Enhanced Property matching
           Person person01 = new Person()
           {
               Id = 1,
               Name = "Ahmed",
               Age = 13
           };

            string message02 = person switch
            {
                { Name: "Ahmed", Age: > 10 } => person01.Print(),
                { Name: "omar", Age: >= 20 and <= 24 } => "Hello Omar",
                { Age: > 50 and < 60 } => "Hello Old man",
                _ => "We Don't Know You"
            };

            Console.WriteLine(message02);


            #endregion

            #endregion


            #region Control Statement (ForLoop)

            // int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, };


            //for (int  i = 0; i < numbers.Length; i++)
            //{

            //    if (i == 3)
            //        continue;  // skip Current Interation
            //    Console.WriteLine(numbers[i]);

            //}

            //foreach (int number in numbers)
            //{

            //    Console.WriteLine(number);

            //}

            /*
                                          for     Vs    foreach

            1- Performance               faster          slower
            2- collection modification   avilabil         not avilabil
            3- Access To Index           true              false
             */
            #endregion


            #region While And Do While
            // Example 01-- > Do While

            int EvenNumber; bool isParse;

            do
            {

                Console.Write("Enter Your Even Number: ");
                isParse = int.TryParse(Console.ReadLine(), out EvenNumber);

            } while (!isParse || EvenNumber % 2 != 0);

            Console.WriteLine($"{EvenNumber} Is Even Number");

            // Example 02-- > While

            int number;
            Console.Write("Please intered number: ");
            bool isParse02 = int.TryParse(Console.ReadLine(), out number); // 5
            if (isParse02)
            {

                if (number <= 10)
                {
                    while (number <= 10)
                    {
                        Console.WriteLine(number); // 5 6 7 8 9 10
                        number++; // 6 7 8 9 10 11
                    }
                }
                else
                {
                    while (number >= 10)
                    {
                        Console.WriteLine(number);
                        number--;
                    }
                }

            }
            else
            {
                Console.WriteLine("Your Number is Wrong");
            }




            #endregion


            #region String

            // String => Sequece of character (one char -> 2 Bytes)
            //        => Immutable  

            // Difference Hash code
            string name = "Ahmed";
            Console.WriteLine($"Before Assign => {name.GetHashCode()}"); //  1952690567
            name = "Mohamed";
            Console.WriteLine($"After Assign => {name.GetHashCode()}"); //  -734712406

            // --------------------------------------------------------------
            string name01;
            // Declare for a reference from type string "name"
            // referecne name is referencing to default value of reference type [null]
            // CLR Will Allocate 4Bytes at stack for reference "name"
            // 0 bytes allocated at heap 


            // CLR Will Allocated Required Bytes At Heap [6 Bytes]
            name01 = new string("Ali");
            Console.WriteLine(name01.GetHashCode()); // 835939402
            // CLR Stored "Mohamed" in new position
            name01 = "Mohamed";
            Console.WriteLine(name01.GetHashCode()); // 93032443

            // --------------------------------------------------------------
            /*
             When you create a string in C#, the CLR checks 
            if the same value already exists in the string intern pool(Memory Cash string).
            If it does, the new variable is assigned the same reference to save memory 
            instead of creating a new object.
             */
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine($"name \"Mohamed\" => {name.GetHashCode()}"); // -1709261559
            Console.WriteLine($"name01 \"Mohamed\" => {name01.GetHashCode()}"); // -1709261559
            // The Same Hashcode
            // ---------------------------------------------------------------

            string name02 = "Amr";
            string name03 = "Mai";

            name03 = name02;

            Console.WriteLine($"Same Hashcode => {name03.GetHashCode()}");
            Console.WriteLine($"Same Hashcode => {name02.GetHashCode()}");
            // Same Hashcode

            name02 = "Osama";

            Console.WriteLine($"After Assign name02 = \"osama\" name02--=> {name02.GetHashCode()}"); // Defference Hashcode
            Console.WriteLine($"After Assign name02 = \"osama\" name03--=> {name03.GetHashCode()}"); // Defference Hashcode

            // ---------------------------------------------------------------

            string message04 = "Hello";
            Console.WriteLine($"{message04} => HashCode is => {message04.GetHashCode()}");
            message05 += "RouteAcademy"; // Store This in difference Location
            Console.WriteLine($"{message04} => HashCode is => {message04.GetHashCode()}");


            // ---------------------------------------------------------------
            #endregion

            #region String Methods

            //string message01 = " Hello Route ";
            //Console.WriteLine(message01.Length); // 13 count space
            //Console.WriteLine(message01.ToUpper()); 
            //Console.WriteLine(message01.ToLower()); 
            //Console.WriteLine(message01.Trim()); 
            //Console.WriteLine(message01.TrimEnd()); 
            //Console.WriteLine(message01.TrimStart()); 
            //Console.WriteLine(message01.Substring(2 , 4)); // llo
            //Console.WriteLine(message01.Replace('e' , 't'));


            #endregion


            #region StringBuilder

            StringBuilder message03 = new StringBuilder("Hello Route");

            /*
             string is immutable, meaning every change creates a new object in memory.
            StringBuilder is mutable, so it allows efficient modifications (like appending or replacing)
            without creating new objects.
            */

            Console.WriteLine(message03.GetHashCode());
            message03.Append(" Ahmed");
            Console.WriteLine(message03.GetHashCode());

            // message.Replace('o' , 'T');

            // message.Clear();

            message03.Remove(0, 5);

            message03.Insert(0, "Hi");

            int age = 29;

            message03.AppendFormat(" , your Age : {0}", age);

            message03.AppendJoin('_', " Ahmed ", " Ali ", " Osama ");


            Console.WriteLine(message03);

            #endregion

        }
    }
}