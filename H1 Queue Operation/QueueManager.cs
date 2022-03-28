using System;
using System.Collections.Generic;
using System.Text;

namespace H1_Queue_Operation
{
    public class QueueManager
    {
        Queue <Queue> queueList = new Queue <Queue> ();
        public void AddItems(string name, int age)
        {
            Queue queue = new Queue(name, age);
            queueList.Enqueue(queue);
        }

        public void DeleteItems()
        {
            queueList.Dequeue();
        }

        public int ShowNumItem()
        {
            return queueList.Count;
        }

        public (string, string Name, int Age) ShowMinMax()
        {
            Queue peek = queueList.Peek();
            return ("Next in queue is {0} {1}", peek.Name, peek.Age);
        }

        public string FindItem(string search)
        {
            foreach(var item in queueList)
            {
                if(item.Name == search)
                {
                    return item.Name;
                }
            }
            return search+" Wasn't found";
        }

        public Queue<Queue> AllItems()
        {
            return queueList;
        }

    }

}
