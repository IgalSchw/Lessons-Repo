using System;
using System.Collections.Generic;
using System.Text;

namespace Lessons.Lesson_6
{
    [Serializable]
    class MyArraySizeException : Exception
    {
        public string msg = string.Empty;
        public MyArraySizeException(string msg)
        {
           this.msg = msg;
        }

        
    }
}
