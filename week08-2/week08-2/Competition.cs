using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week08_2
{
    public class Competition<T>
    {
        T[] items = new T[5];
        int count = 0;


        public void Add(T item)
        {
            if (count == 5)
                throw new Exception("Competition is full. There is no empty slot.");

            items[count] = item;
            count++;
        }
        
        public T this[int index]
        {
            get { return items[index]; }
            set { items[index] = value; }
        }

        public void Start()
        {
            for (int i = 0; i < count; i++)
            {
                var dog = items[i] as Dog;
                if(dog != null)
                {
                    dog.Run100meters();
                }
            }
        }

        public override string ToString()
        {
            Array.Sort(items);
            Array.Reverse(items);

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"The competition has {count} racer. And the result are as below");
            stringBuilder.AppendLine("--------------------------------------------------------");
            for (int i = 0; i < count; i++)
            {
                var dog = items[i] as Dog;
                if (dog != null)
                    stringBuilder.AppendLine("[" + (i+1) + "] " + dog.ToString());
            }

            return stringBuilder.ToString();
        }
    }
}
