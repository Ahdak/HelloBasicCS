using System;
namespace HelloBasicCS.poo
{
    public class GenericIndexer<T>
    {
        private T[] data;

        public GenericIndexer()
        {
            data = new T[10];
        }   

        public T this[int index]
        {
            get => data[index];
            set => data[index] = value;
        }

        public T this[T input]
        {
            get
            {
                foreach(T d in data)
                {
                    if (input.Equals(d))
                    {
                        return d;
                    }
                }
                return default;
            }
           
        }
    }
}
