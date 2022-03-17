using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Generics
{
    internal class HeroesTable<T> where T : Heroes
    {
        public T[] Knights { get; set; }

        public T this[int index]
        {
            get
            {
                if (ActualKnights() == 0)
                    return default (T);
                else if (index <= Knights.Length - 1)
                {
                    if (Knights[index] == null)
                    {
                        for (int i = index - 1; i >= 0; i--)
                        {
                            if (Knights[i] != null)
                                return Knights[i];
                        }
                        return default(T);
                    }
                    else
                        return Knights[index];
                }
                else
                {
                    return Knights[index % Knights.Length-1];
                }
            }
            set
            {

            }
        }

        public HeroesTable(int size)
        {
            Knights = new T[size];
        }

        public void Set(T knight, int index)
        {
            Knights[index] = knight;
        }

        public void Delete(int index)
        {
            Knights[index] = default(T);
        }

        public int ActualKnights()
        {
            int counter = 0;
            foreach (T knight in Knights)
            {
                if (knight != null)
                    counter++;
            }
            return counter;
        }
        public T[] AllKnights()
        {
            T[] allKnights = new T[ActualKnights()];
            int index = 0;
            foreach (T knight in Knights)
            {
                if (knight != null)
                {
                    allKnights[index] = knight;
                    index++;
                }
            }
            return allKnights;
        }
    }

}
