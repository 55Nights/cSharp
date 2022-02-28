//Write a program that computes the sum of the squares of the first 15 positive integers and display the results using
//a)	while… loop.               
//b)	for… loop.
using System;
class Squares
{
    static void Main(string[]args){
        int sum=0;
        for (int i = 1; i <=15; i++)
        {
           sum=sum+(i*i);
           Console.WriteLine(sum);
        }
    }
}