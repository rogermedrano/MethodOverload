using System;
using System.Collections.Generic;

namespace MethodOverloading20


//Create a method named Add, that accepts two integers and returns the sum of those two integers
//Now create an overload of the Add method to account for being able to add two decimals together
//Now create an overload of the Add method that returns a string and accepts 3 parameters: 2 integers and 1 boolean
//If the boolean parameter is equal to true, the Add method will return the sum of the 2 numbers plus the word “dollars” at the end of the string.

//You must also account for the appropriate grammar of the string - so it can’t be “1 dollars”

//For example:  
//“5 dollars”
//“1 dollar”
//“16 dollars”


{
     class Program
    {
        public static void Main(string[] args)
        {
            var x = 1;
            var y = 3;
            var answer = Add(x, y);
            //Add(x, y);
            Console.WriteLine($"The integers {x} plus {y} equals {answer}");


            var a = 12.2m;
            var b = 21.10m;
            var decimalAnswer = Add(a, b);
            Console.WriteLine($"The decimals {a} plus {b} equals {decimalAnswer}");
                     

            var answer3 = Add(1, 0, true);

            //Console.WriteLine($"int add: {answer1} decimal add: {answer2}");
            Console.WriteLine(answer3);
        }





        //-----------------METHODS--------------------------------
        private static int Add(int num1, int num2)
        {
            return num1 + num2;            
        }

        //Add 2 decimals
        private static decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;
            // var answer = Add(num1, num2);
            //Console.WriteLine($"{num1} plus {num2} equals {answer}");
        }        
        //public static decimal AddDecimal(decimal a, decimal b)
        //{
        //    return a + b;      
        //}


        //Add 2 ints with BOOL
        public static string Add(int num1, int num2, bool isTrue)
        {
            var sum = num1 + num2;

            if (isTrue == true && sum == 1)
            {
                return $"{sum} dollar";
            }
            else if (isTrue == true && sum > 1)
            {
                return $"{sum} dollars";
            }
            //else
            //{
            //    return sum.ToString();
            //}

        }
    }
}
