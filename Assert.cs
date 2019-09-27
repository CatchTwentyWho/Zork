using System;
using System.Diagnostics;

namespace Zork
{
    public static class Assert
    {
        [Conditional("DEBUG")]
        public static void IsTrue(bool expresion, string message = null)
        {
            if (expression == false)
            {
                throw new Exception(message);
            }
        }
    }
}