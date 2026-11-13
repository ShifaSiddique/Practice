using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////int num = 99;
            ////Console.WriteLine("Bismillah " + num);

            ////string str = Console.ReadLine();
            ////Console.WriteLine(str);
            ////Console.ReadLine();
            //int a = 8;
            //float b = 10.6f;
            //double c = 14.6; // such numbe ris by default double here no need to mntion d
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);



            //// typecasting 
            ////implicit : automatcally casting smaller type to higher type
            //int myint = 7;
            //double doub = a;
            //Console.WriteLine(doub);
            //Console.WriteLine(myint);


            ////explicit casting:(manually) - converting a larger type to a smaller size type
            //double mydouble = 4.5;
            //int int2 = (int)mydouble;
            //Console.WriteLine(mydouble);
            //Console.WriteLine(int2);

            ////It is also possible to convert data types explicitly by using
            ////built-in methods, such as Convert.ToBoolean, Convert.ToDouble,
            ////Convert.ToString, Convert.ToInt32 (int) and Convert.ToInt64 (long):

            //int myinti = 45;
            //float myfloat = 6.7f;
            //Console.WriteLine(Convert.ToString(myfloat));
            //Console.WriteLine(myfloat.GetType());


            ////User Input
            //Console.Write("Enter Your name :");
            //string name = Console.ReadLine();
            //Console.WriteLine("Hi " + name);

            //// Console.ReadLine() hamesha ek Text (String) read karta hai,

            //// Operators
            //int first = 32;
            //int sceond = 43;
            //int sumfirst = first + 45;
            //Console.WriteLine(first + sceond);
            //Console.WriteLine(sumfirst);


            ////Basic Calculator
            //Console.Write("Enter a nuumber :");
            //int userip = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter a nuumber :");
            //int secip = Convert.ToInt32(Console.ReadLine());
            //int sum = userip + secip;
            //Console.WriteLine("Addition :" + sum);

            ////// Using string interpolation
            ////Console.WriteLine($"Adddition : {userip +secip}");
            ////Console.WriteLine($"Subtraction: {userip - secip}");
            ////Console.WriteLine($"Divide : {userip / secip}"); // gives quotient
            ////Console.WriteLine($"Remainder: {userip % secip}");
            ////Console.WriteLine($"Multiplication : {userip * secip}");


            //int a1 = 10;
   
            //Console.Write("Enter number to increment ,decrement in 10 :");
            //int a2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(a1+= a2);
            //Console.WriteLine(a1 -= a2); // the value of a1 would be the one afeter onrement as value is changed above once

            ////logical
            //int a = 10;
            //int b = 5;

            //Console.WriteLine(a > b && b < 3);
            //Console.WriteLine(a > b || b < 3);
            //Console.WriteLine(!(a > b));

            ////Math
            //Console.WriteLine (Math.Max(19, 34));
            //Console.WriteLine(Math.Min(12, 8));
            //Console.WriteLine(Math.Sqrt(64)); // returns suare root 
            //Console.WriteLine(Math.Round(3.333));

            //// String
            //string txt = "Hey Shifa always make dua";
            //Console.WriteLine("Length " + txt.Length);
            //Console.WriteLine(txt.ToLower());
            //Console.WriteLine(txt.ToUpper());

            ////conacatenation
            //string am = "First";
            //string dm = "scnd";
            //Console.WriteLine(am + dm);
            //Console.WriteLine(string.Concat(am, dm));  // another way to concat using string .concat

            ////Access strings
            //Console.WriteLine(am[0]);
            //Console.WriteLine(am.IndexOf("s"));

            
            //Console.WriteLine(txt);
            //int charposi = txt.IndexOf('S');
            //string getsubstring = txt.Substring(charposi);
            //Console.WriteLine(getsubstring);

            ////If Else
            ////Write a program that accepts an integer and determines whether it is even or odd.
            //Console.Write("Enter a number to check even /odd :");
            //int userip = Convert.ToInt32(Console.ReadLine());
            //if (userip % 2 == 0)
            //{
            //    Console.WriteLine("Even");
            //}
            //else
            //{
            //    Console.WriteLine("Oddd");
            //}

            ////Accept three integers and print the largest. Handle cases where two or all three numbers are equal.
            //Console.Write("Enter a number : ");
            //int num1 =Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter a number: ");
            //int num2 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter a number :");
            //int num3 = Convert.ToInt32(Console.ReadLine());

            //if (num1 == num2 && num2 == num3)
            //{
            //    Console.WriteLine("Numbers are equal");
            //}
            //else if (num1 > num2 && num1 > num3)
            //{
            //    Console.WriteLine($"{num1} is greater");

            //}
            //else  if(num2 >num1 && num2 > num3)
            //{
            //    Console.WriteLine($"{num2} is greater");

            //}
            //else { 
            //    Console.WriteLine($"{num3} is greater");
            //}

            ////Leap Year checker
            //Console.Write("Enter a year to check if its a leap year  : ");
            //int yearip = Convert.ToInt32(Console.ReadLine());
            //if (yearip % 400 == 0  || (yearip % 4 ==0 && yearip %100 !=0))
            //{
            //    Console.WriteLine($"{yearip} is a LeapYear");

            //}
            //else
            //{
            //    Console.WriteLine($"{yearip} is not a leap year");
            //}


            //Login Validation

            //Accept a username and password.
            //Display "Login Successful" only when both match
            //the predefined credentials; otherwise, display "Invalid Credentials".

            //Console.Write("Do You have  an account ? ");
            //string userinp = Console.ReadLine();
            //if (userinp.ToLower() == "yes")
            //{
            //    Console.Write("Enter username :");
            //    string username = Console.ReadLine();
            //    Console.Write("Enter password :");
            //    string password = Console.ReadLine();
            //}
            //else
            //{
            //    Console.WriteLine("Create an Account");
            //    Console.Write("Enter username :");
            //    string username = Console.ReadLine();
            //    Console.Write("Enter password :");
            //    string password = Console.ReadLine();
            //}

            //for(int i=1; i<=10; i++)
            //{
            //    Console.WriteLine(i);
            //}
            ////Solve more question of for loop here


            //Array 
            int[] arr = { 1, 3, 4, 6, 7 };
            //for (int i=0; i<arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}
            //Reverse array print 
            int  arln = arr.Length;
            Console.WriteLine(arln);
            for(int i=arln-1; i>=0; i--)
            {
                Console.WriteLine(arr[i]);
            }


            //sum
            int sm = 0;
            for(int i=0; i<arr.Length; i++)
            {
                sm += arr[i];
            }
            Console.WriteLine(sm);

            //largest position
            int max = arr[0];
            for(int i =0; i <arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];

                }
                
            }
            Console.WriteLine("Maximum" + max);

            //Check if numbers are even or odd
            int[] arr_ev_od = { 2, 5, 8, 11, 14, 17, 20 };
            int[] even;
            for(int i =0; i< arr_ev_od.Length; i++)
            
            {
                if (arr_ev_od[i]%2==0)
                {
                    Console.WriteLine("Even" + arr_ev_od[i]);
                }
                else
                {
                    Console.WriteLine("Odd" + arr_ev_od[i]);
                }
            }







        }
    }
}
