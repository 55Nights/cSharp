//Write a program that accepts the width and length of a rectangle and computes both it’s area and perimeter.
//area= l*w preimeter=2(l+w)
using System;
class Rectangle
{
   static void Main(string[]args) {
       int l,w,area,perimeter;
       Console.WriteLine("Enter the Width");
       w=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the Length");
       l=Convert.ToInt32(Console.ReadLine());
       area=l*w;
       perimeter= 2*(l+w);
        Console.WriteLine("The area is="+area+" "+"THe perimeter is="+perimeter);
   }
}