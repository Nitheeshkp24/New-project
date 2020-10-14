using System;
using System.Collections.Generic;
using System.Text;

namespace New_project
{
   public class Student
    {
        string name, department;

        int mark1, mark2;

        public void getdetail(string name,string department,int mark1,int mark2)
        {
            this.name = name;
            this.department=department;
            this.mark1 = mark1;
            this.mark2 = mark2;
            

        }
        public void display()
        {
            Console.WriteLine("name:=" + name );
            Console.WriteLine("dep= " + department);
            Console.WriteLine("mark1= " + mark1);
            Console.WriteLine("mark2= " + mark2);
        }
    }
}
