using System;
using System.Collections.Generic;
using System.Text;

namespace H1_Queue_Operation
{
    public class QueueManager
    {
        Queue <Queue> queueList = new Queue <Queue> ();

        public QueueManager()
        {
            Queue Camilla = new Queue("Camilla", 20);
            Queue Niklas = new Queue("Niklas", 18);
            Queue Anders = new Queue("Anders", 67);

            queueList.Enqueue (Camilla);
            queueList.Enqueue (Niklas);
            queueList.Enqueue (Anders);
        }

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

        public string ShowMinMax()
        {
            Queue [] queueArr = queueList.ToArray ();
            Queue last = queueArr [queueArr.Length - 1];
            Queue peek = queueList.Peek();
            string output = "First in queue " +peek.Name+" "+peek.Age+ "\nLast in queue "+ last.Name+" "+ last.Age;
            return output;
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

        public string AllItems()
        {
            string output = "";
            foreach(Queue item in queueList)
            {
                output += "\n"+item.Name+" "+ item.Age;
            }
            return output;
        }

    }

}
