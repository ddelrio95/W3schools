using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "John";
            int myNum = 15;
            int myNum1;
            myNum1 = 30;
            int myNum2 = 20;
            myNum2 = 40;
            const int constante = 50;
            //constante = 90; // es una constante
            Console.WriteLine(myNum2);
            Console.WriteLine(name);
            Console.WriteLine(myNum);
            Console.WriteLine(myNum1);
            Console.WriteLine(constante);


            int myNum3 = 5;
            double myDouble = 5.99D;
            char myLetter = 'D';
            bool myBool = true;
            string myText = "Hello";

            Console.WriteLine(myNum3);
            Console.WriteLine(myDouble);
            Console.WriteLine(myLetter);
            Console.WriteLine(myBool);
            Console.WriteLine(myText);

            string named = "Dario";
            Console.WriteLine("Hello " + named);

            string firstName = "Dario ";
            string lastName = "del Rio";
            string fullName = firstName + lastName;
            Console.WriteLine(fullName);

            int x = 5;
            int y = 10;
            Console.WriteLine(x + y); // Adding two variables

            int a = 5, b = 10, c = 15;
            Console.WriteLine(a + b + c); // Adding two variables in the same line

            // God
            const int minutesPerHour = 60;
            Console.WriteLine(minutesPerHour);

            // Int data can storage a value from -2147483648 to 2147483647
            int bigNumb = 1000;
            Console.WriteLine(bigNumb);

            //Log data can storage a whole number from -9223372036854775808 to 9223372036854775807
            long myLong = 150000000000L;
            Console.WriteLine(myLong);

            //Float data can storage a fractional number from 3.4e−038 to 3.4e+038
            float fractional = 5.75F;
            Console.WriteLine(fractional);

            //Double data can storage a fractional number from 1.7e−308 to 1.7e+308
            double doble = 19.99D;
            Console.WriteLine(doble);

            //Example between float and double
            float f1 = 35e3F;
            double d1 = 12E4D;
            Console.WriteLine(f1);
            Console.WriteLine(d1);

            //A boolen data determines true or false
            bool isCSharpFun = true;
            bool isFishTasty = false;

            Console.WriteLine(isCSharpFun);
            Console.WriteLine(isFishTasty);

            //The char data type is used to a single character
            char myGrade = 'B';
            Console.WriteLine(myGrade);

            //The string data type is used to storage a sequence of charcters
            string greeting = "Hello Dario";
            Console.WriteLine(greeting);

            //Type Casting
            //Inplicit Casting (small type to large type size)
            int myInt = 9;
            double myDouble1 = myInt; //Authomatic casting: int to a double
            
            Console.WriteLine(myInt); //output 9
            Console.WriteLine(myDouble1); //output 9

            //Explicit Casting (large type to small type size)
            double myDouble2 = 9.78;
            int myInt5 = (int)myDouble2;

            Console.WriteLine(myDouble2);
            Console.WriteLine(myInt5);

            //Type Conversion Methods
            int MyInt = 10;
            double MyDoublea = 5.25;
            bool MyBool = true;

            Console.WriteLine(Convert.ToString(MyInt)); // convert int to string
            Console.WriteLine(Convert.ToDouble(MyInt)); // convert int io double
            Console.WriteLine(Convert.ToInt32(MyDoublea)); // convert double to int
            Console.WriteLine(Convert.ToString(MyBool)); // convert bool to string


            // Get User Input
            Console.WriteLine("Enter your name: ");
            string name1 = Console.ReadLine();

            Console.WriteLine("Enter you age:");
            int age = Convert.ToInt32(Console.ReadLine());

         
            Console.Write("User name is " + name1);
            Console.WriteLine(" and your age is " + age);


            //Operadores
            int x1 = 100 + 50;

            int sum1 = 100 + 50;        // 150 (100 + 50)
            int sum2 = sum1 + 250;      // 400 (150 + 250)
            int sum3 = sum2 + sum2;     // 800 (400 + 400)

            // Math Calculations
            Math.Max(5, 10);
            Math.Min(5, 10);

            // Capital letter
            string txt = "Hello World";
            Console.WriteLine(txt.ToUpper());   // Outputs "HELLO WORLD"
            Console.WriteLine(txt.ToLower());   // Outputs "hello world"

            //String Concatination 
            string FirstName = "John ";
            string LastName = "Doe";
            string NaMe = string.Concat(FirstName, LastName);
            Console.WriteLine(NaMe);


            //Access String
            string perro = "Doberman";
            Console.WriteLine(perro[0]); //Outputs "D"

            string myString = "Hello";
            Console.WriteLine(myString.IndexOf("e"));  // Outputs "1"



            if (20 > 18)
            {
                Console.WriteLine("20 is greater than 18");
            }
            else
            {
                Console.WriteLine("It is not");
            }




            int time = 20;
            if (time < 18)
            {
                Console.WriteLine("Good day.");
            }
            else
            {
                Console.WriteLine("Good evening.");
            }
            // Outputs "Good evening."




            //Else if
            Console.WriteLine("Enter your current time: "); // Get the user current time
            int time1 = Convert.ToInt32(Console.ReadLine());


            if (time1 < 10)
            {
                Console.WriteLine("Good morning.");
            }
            else if (time1 < 20)
            {
                Console.WriteLine("Good day.");
            }
            else
            {
                Console.WriteLine("Good evening.");
            }





            //Switch 
            int day = 20;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Not Match.");
                    break;
            }
            // Outputs "Thursday" (day 4)


            //While Loop
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }

            // Do While
            int f = 0;
            do
            {
                Console.WriteLine(f);
                f++;
            }
            while (f < 5);



            // For Loops
            for (int i = 0; i < 5; i ++)
            {
                Console.WriteLine(i);
            }


            // Foreach loops
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            foreach (string i in cars)
            {
                Console.WriteLine(i);
;            }












        }


    }
}