using System;
class Nest
{
    static void Main(string[]args){
     
      for (int i = 1; i < 6; i++)
      {
              Console.WriteLine(i);
          
         for (int j = 0; j <= 3; j++)
         {
              Console.WriteLine("\a"+j);
               Console.WriteLine("");
         }
      }
           
    }
}