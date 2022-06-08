using System;

namespace ExtentionMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 45;
            num = num.Add(10);
            Console.WriteLine(num);

            //Car car = new Car();
            //car.Drive(10);


            string name = "aBbaS";

            name = name.ToCapitalize();


            Console.WriteLine(name);

            string word = "asf2dfdsfd";

            Console.WriteLine(word.HasDigit());

            int[] nums = new int[] { 1, 2, 3 };

            nums = nums.Add(78);
            nums = nums.Add(98);


            Console.WriteLine("Numbers:");
            foreach (var item in nums)
            {
                Console.WriteLine(item);
            }

        }
    }
}
