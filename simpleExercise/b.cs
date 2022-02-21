//Write a program that accepts the radius of a circle and computes both it’s area and circumference.
// area of a circle = 22/7r*r   perimeter pi*d
using System;
class Circle
{
    static void Main(string[]args){
        double area,perimeter,r;
        const double pi=3.14;
        Console.WriteLine("Enter the radius");
        r=Convert.ToDouble(Console.ReadLine());
         area=pi*r*r;
         perimeter=pi*2*r;
         Console.WriteLine("The area is="+area +" "+"The perimeter="+perimeter);
    }
}