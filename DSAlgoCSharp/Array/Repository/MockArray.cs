using DSAlgoCSharp.Array.Contract;
using System;
using System.Collections.Generic;
using System.Text;

namespace DSAlgoCSharp.Array.Repository
{
    public class MockArray : IArrayTest
    {
        private readonly Random _random = new Random();

        public int[] GetInputArray(int n, int min = 0, int max = 100000)
        {
            var arr = new int[n];
            int element;
            for(int i = 0; i < n; i++)
            {
                element = _random.Next(min,max);
                arr[i] = element;
            }
            return arr;
        }
    }
}
