using System;
using System.Collections.Generic;
using System.Text;

namespace DSAlgoCSharp.Array.Contract
{
    public interface IArrayTest
    {
        int[] GetInputArray(int n, int min = 0, int max = 100000);
    }
}
