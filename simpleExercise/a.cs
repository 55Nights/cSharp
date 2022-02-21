//Write a program that accepts three numbers and computes their sum, product and average. 
using System;
class A
{
    static void Main(string[]args){
        int x,y,z,product,sum;
        double average;
       Console.WriteLine("Enter your first number");
       x=Convert.ToInt32(Console.ReadLine());
       Console.WriteLine("Enter your Second number");
       y=Convert.ToInt32(Console.ReadLine());
       Console.WriteLine("Enter your  third number");
       z=Convert.ToInt32(Console.ReadLine());
       sum=x+y+z;
       product=x+y+z;
       average=sum/3;
       Console.WriteLine("The sum is="+sum+" "+"The product is="+product+" "+"The average is="+average);
    }
}