using System;

namespace Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee
            {
                Name = "Hikmet",
                Age = 25,
                Position = "Developer"
            };

            emp1.ShowInfo();

            Human human = new Human
            {
                Age = 5,
                Name = "Eli"
            };

            human.ShowInfo();

            human = new Employee
            {
                Name = "Hikmet",
                Age = 25,
                Position = "Developer"
            };

            human = emp1;


            Console.WriteLine(human.Name+" - "+human.Age);

            Human[] humans = new Human[] {
            emp1,
            new Human { Age = 4,Name = "Nezrin"},
            new Student{Age = 16,Name = "Fateh",GroupNo = "P227" }};


            foreach (var item in humans)
            {
                //if(item is Student)
                //{
                //    Console.WriteLine("Student var");
                //    break;
                //}

                item.ShowInfo();
            }

            Car car = new Car();

            IDriveable driveable = car;
            driveable = new Bycle();

            driveable.Show();
            
        }
    }
}
