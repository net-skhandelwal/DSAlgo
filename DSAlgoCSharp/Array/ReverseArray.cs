using DSAlgoCSharp.Array.Contract;
using System;
using System.Collections.Generic;
using System.Text;

namespace DSAlgoCSharp.Array
{
    public class ReverseArray
    {
        public ReverseArray(IArrayTest MockDataRepo)
        {
            _data = MockDataRepo;
        }

        private readonly IArrayTest _data;

        public void RevArrayIteration(int n)
        {
            var array = _data.GetInputArray(n);
            Console.WriteLine($"Input: [{string.Join(", ",array)}]");
            int index = (n / 2);
            for(int i = 0; i < index; i++)
            {
                array[i] = array[i] + array[n - i - 1];
                array[n - i - 1] = array[i] - array[n - i - 1];
                array[i] = array[i] - array[n - i - 1];
            }
            Console.WriteLine($"Output: [{string.Join(", ", array)}]");
        }
    }
}
