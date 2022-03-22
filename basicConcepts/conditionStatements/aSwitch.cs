/*Write a program that when run, produces a menu showing beer brands and their prices and then prompts the user enter his/her choice (1,2,3 or 4). The user is then asked how many bottles he/she wants. He is then given the total cost (depending on the cost of the beer chosen) as the output. See sample dialog below. If he/she enters an invalid choice e.g. 8, he/she should get an error message.
Sample dialog
      
* * * * Jamal and Daughters Pub * * * *
Beer Brand		Price
1) Tusker			100/=
2) Pilsner			120/=
3) Smirnoff Ice		140/=
4) White Cap		 90/=
Enter your choice: 2
How many bottles of pilsner do you want? 11
11 bottles of pilsner will cost you Kshs. 1320
a) Use the switch statement.
*/
using System;
class Beer
{
    static void Main(string[]args){
       try
               {
                     int x,y;
                      Console.WriteLine("***Jamal and Daughter Pub****");
        Console.WriteLine("Beer Brand                            Price");
        Console.WriteLine("1) Tusker_____________________________100");
          Console.WriteLine("2) Pilsner___________________________120");
            Console.WriteLine("3) Smirnoff Ice_______________________140");
              Console.WriteLine("4) white cap_____________________________90");
               Console.WriteLine("Enter your choice");
               x=Convert.ToInt32(Console.ReadLine());
              
           switch (x)
           {
               case 1: Console.WriteLine("How many bottles of Tusker do u want");
                       y=Convert.ToInt32(Console.ReadLine());
                       Console.WriteLine(y+" bottles of Tusker will cost u ksh"+(y*100));
               break;
               case 2: Console.WriteLine("How many bottles of Pilsner do u want");
                      y=Convert.ToInt32(Console.ReadLine());
                      Console.WriteLine(y+" bottles of Pilsner will cost u ksh"+(y*120));
               break;
               case 3:   Console.WriteLine("How many bottles of Smirnoff ice do u want");
                     y=Convert.ToInt32(Console.ReadLine());
                      Console.WriteLine(y+" bottles of Smirnoff ice will cost u ksh"+(y*140));
               break;
               case 4:   Console.WriteLine("How many bottles of  white cap do u want");
                     y=Convert.ToInt32(Console.ReadLine());
                      Console.WriteLine(y+" bottles of  white cap will cost u ksh"+(y*90));
               break;
               default:  Console.WriteLine("Please select the valid options");
               break; 
           }
               }
               catch (System.Exception)
               {
                   
                 Console.WriteLine("Something went wrong");
               }

    }
}