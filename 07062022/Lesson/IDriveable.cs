using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson
{
    internal interface IDriveable
    {
        void Drive(double km);

        void Show()
        {
            Console.WriteLine("I am driveable!");
        }
    }
}
