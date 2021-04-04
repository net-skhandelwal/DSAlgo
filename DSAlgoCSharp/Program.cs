using DSAlgoCSharp.Array;
using DSAlgoCSharp.Array.Contract;
using DSAlgoCSharp.Array.Repository;
using System;

namespace DSAlgoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new ReverseArray( new MockArray());
            array.RevArrayRecursion(9);
        }
    }
}
