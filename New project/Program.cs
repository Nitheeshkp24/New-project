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
            Console.WriteLine("enter name dep mark1,mark2");
            name = Console.ReadLine();
            department = Console.ReadLine();
            mark1 = Convert.ToInt32(Console.ReadLine());
            mark2= Convert.ToInt32(Console.ReadLine());
            

            //int mark1, mark2;


            Student obj = new Student();
            obj.getdetail(name, department, mark1, mark2);
            obj.display();


            

        }
    }
}
