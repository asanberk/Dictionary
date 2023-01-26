using System;

namespace Dictionary
{
    internal class Program
    {
        



    class MyDictionary<T, A>
        {
            A[] tempArray;
            A[] array;
            T[] array2;
            T[] tempArray2;
            public MyDictionary()
            {
                array = new A[0];
                array2 = new T[0];
            }

            public void Add(A key, T value)
            {

                tempArray = array;
                tempArray2 = array2;
                for (int i = 0; i < tempArray.Length; i++)
                {
                    tempArray[i] = array[i];
                }
                for (int i = 0; i < tempArray2.Length; i++)
                {
                    tempArray2[i] = array2[i];
                }
                array[array.Length - 1] = key;
                array2[array2.Length - 1] = value;

            }
            public int Length
            {
                get { return array.Length; }
            }
        }

    }
    }

