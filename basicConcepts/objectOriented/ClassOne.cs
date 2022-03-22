/*1)	i) Define a class that has the following specifications:
Private member variables:
	Name (an array of characters)
	Mark (an integer)
	Grade (a character)
	Reg_No (an array of characters)
Public member functions:
	input – to be used to input values into member variables.
	display – to display contents of member variables.
	A constructor to be used to initialize member variables.                              (6 mks)
ii) Declare two objects of the class defined above and initialize them with values.  
                                                                                                                              (3mks)
iii) Write C# statements that use the objects defined (ii) above to call the two functions input and display defined in (i) above. You need not write the whole program.                                                                                                               
*/
using System;
class Student
{
    private string Name, Reg_No;
    private int Mark;
    private char Grade;
    public Student(string Name,string Reg_No,int Mark,char Grade){
        this.Name=Name;
        this.Reg_No=Reg_No;
        this.Mark=Mark;
        this.Grade=Grade;

    }
    public void input(){
      Console.WriteLine("Enter the Name");
      Name=Console.ReadLine();
      Console.WriteLine("Enter the registration number");
       Reg_No=Console.ReadLine();
       Console.WriteLine("Enter the Mark ");
       Mark=Convert.ToInt32(Console.ReadLine());
       Console.WriteLine("Enter the Grade");
       Grade=Convert.ToChar(Console.ReadLine());
    }
    public void display(){
        Console.WriteLine("The Name" +Name);
        Console.WriteLine("The registration"  +Reg_No);
        Console.WriteLine("The mark" +Mark);
        Console.WriteLine("The grade" +Grade);
        Console.WriteLine("");
    }
}
class ClassOne
{
    public  static void Main(string[]args){
     Student s= new Student("Moses Mody","NBA-2022",76,'B');
     Student s1= new Student("lamelo BAll","NBA-2021",88,'A');
     s.input();
     s.display();
     s1.input();
     s1.display();
    }
}