using System;
using System.Collections;
using System.Collections.Generic;
namespace Cwiczenia
{
    internal class Llista<int32> : IEnumerable<int>, IEnumerable
    {
        private const int initlenght = 100;
        private int[] array = new int[initlenght];
        private int lenght = 0;
        
        

        public void Add(int args)
        {
            if (array.Length > lenght)
            {
                array[lenght++] = args;
                return;
            }
            
                int i = 0;
                int[] temparray = new int[array.Length + initlenght];
                foreach (int item in array)
                {
                    temparray[i] = item;
                    i++;
                }
                array = temparray;
            Add(args);
        }
        
        public void Remove(int args)
        {
            bool found = false;
            int index = 0;
            foreach (int item in array)
            {
                if (!found && item.Equals(args))
                {
                    found = true;
                }
                if (found && index + 1 < lenght)
                {
                    array[index] = array[index + 1];
                }
                index++;
            }
            lenght--;
            int i = (array.Length - lenght) / initlenght;
            if (i >= 1)
            {
                
                int[] temparray = new int[array.Length - initlenght];
                for (int j = 0; j < array.Length - initlenght; j++)
                {
                    temparray[j] = array[j];
                }
                array = temparray;
            }
        }
        public int Count()
        {
            return lenght;
        }
        public void AddRange(int[] args)
        {
            foreach (int item in args)
            {
                Add(item);
            }
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < lenght; i++)
            {
                yield return array[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

