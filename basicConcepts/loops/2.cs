//2)	Write a program that accepts a list of integers and computes their sum. The program should allow the user to enter any number of integers but an input of zero should terminate the list.
 //For example if the user enters 2 5 6 12 8 2 0 the sum should be 35. If he/she enters 2 4 5 0 the sum should be 11 and if he enters 5 4 6 0 12 43 2
 // the sum should 15 i.e. only numbers before zero are summed. The rest are ignored and the program terminated.
using System;
class Sum
{
    static void Main(string[]args){
         int sum = 0;
    int number = 0;

    // create an object of Scanner class
   
	   
    // do...while loop continues 
    // until entered number is positive
    do {
      // add only positive numbers
      sum += number;
      Console.WriteLine("Enter a number");
      number = Convert.ToInt32(Console.ReadLine());
    } while(number > 0); 
	   
    Console.WriteLine("Sum = " + sum);
   
     
        }
   
    }
