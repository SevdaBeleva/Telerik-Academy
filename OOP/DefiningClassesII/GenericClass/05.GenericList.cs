using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass
{
    public class GenericList<T> where T : IComparable
    {
        private T[] elements;
        const int FixedCapacity = 200;
        int count;
        int capacity;

        public GenericList(int capacity)       
        {
           elements = new T[capacity];
        }

        public GenericList()
            : this(FixedCapacity)
        { 
        }

        public int Count
        {
            get { return this.count; }
        }

        public void Add(T element)     // add element in the list
        {
            if (count >= elements.Length)        // check if the list is full
            {
                throw new IndexOutOfRangeException(String.Format("The capacity of {0} has been exceeded", elements.Length));
            }
            else
            {
               this.elements[count] = element;
                count++;
            }
        }
        public T this[int index]   // get element by index
        {
            get
            {
                if (index >= count)     // check if index is in the list
                {
                    throw new IndexOutOfRangeException(String.Format("Invalid index {0}", index));
                }
                else
                {
                    T result = elements[index];
                    return result;
                }
                
            }
        }
        public void RemoveItem(int index)
        {
            T[] temp = new T[elements.Length - 1];
            
            for(int i = 0; i < temp.Length; i++)
            {
                if (!elements[i].Equals(index))
                {
                    temp[i] = elements[i];         
                }
            }
            elements = temp;
        }

        public void InsertItem(int index, T value)
        {
            if (index < this.capacity)
            {
                Array.Copy( this.elements, index, this.elements, index + 1, this.capacity - index );
            }
            this.elements[index] = value;
            this.capacity++;
            
        }

        public void ResizeArray()  //task 6 Implement auto-grow functionality
        {
            T[] resizedArray = new T[elements.Length * 2];
            Array.Copy(elements, resizedArray, Count);
            elements = resizedArray;
            
        }

    }
}
