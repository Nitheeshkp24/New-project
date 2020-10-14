using System;

namespace New_project
{
    class Program
    {
       

        static void Main(string[] args)
        {
            string name;
            string department;
            int mark1;
            int mark2;
            Console.WriteLine("Enter name ");
             name = Console.ReadLine();
            Console.WriteLine("Enter department name");
            department = Console.ReadLine();
            Console.WriteLine("Enter the mark1");
            mark1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the mark2");
            mark2 = Convert.ToInt32(Console.ReadLine());
            

            //int mark1, mark2;


            Student obj = new Student();
            obj.getdetail(name, department, mark1, mark2);
            obj.display();


            

        }
    }
}
