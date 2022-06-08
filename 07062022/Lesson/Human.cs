using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson
{
    internal class Human
    {
        public string Name;
        public byte Age;

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Name: {Name} - Age: {Age}");
        }
    }
}
