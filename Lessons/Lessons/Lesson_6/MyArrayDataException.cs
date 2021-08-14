using System;
using System.Collections.Generic;
using System.Text;

namespace Lessons.Lesson_6
{
    [Serializable]
    class MyArrayDataException : Exception
    {
        public int i { get; set; }
        public int j { get; set; }

        public MyArrayDataException(int i, int j)
        {
            this.i = i;
            this.j = j;
        }        
    }
}
