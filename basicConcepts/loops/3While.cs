using System;
class Square
{
    static void Main(string[]args){
        int i=1,sum=0;
        i++;
        while (i<=15)
        {
             sum=sum+(i*i);
           Console.WriteLine(sum);
        }
    }
}