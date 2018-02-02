using System;
using System.Collections.Generic;
using System.Text;

namespace YagoSession1Practice
{
    public static class StringHelpers
    {
        //this refers to itself so a way of extending myString.. this is refering to string object,
        public static bool IsNullOrWhiteSpace(this string myString)
        {
            return string.IsNullOrWhiteSpace(myString);
        }
    }
}
