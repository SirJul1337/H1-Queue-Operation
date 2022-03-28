using System;
using System.Collections.Generic;
using System.Text;

namespace H1_Queue_Operation
{
    public class Queue
    {
        private int age;
        private string name;
        public Queue(string name, int age)
        {
            Name = name;
            Age = age;

        }   
        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        public int Age
        {
            get { return age; }
            set { age = value; }
        }

    }
}
