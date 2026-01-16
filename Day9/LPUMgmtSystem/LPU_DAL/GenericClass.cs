using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// Custom generic class created for demo
/// </summary>
namespace LPU_Common
{
    public class GenericClass<T>
        // we want this class acessible everywhere that is why we used public
        // this is a generic class, so <T>
    {
        /// <summary>
        /// custom generic method 
        /// </summary>
        public void SwapMe(ref T obj1, ref T obj2)
        {
            // If we don't use ref, these values won't get swapped in ACTUAL
            // And will be visible only in the class but not outside
            // Thus, we use ref keyword
            T temp;
            temp = obj1;
            obj1 = obj2;
            obj2 = temp;

        }
    }
}
